using FastReport.DataVisualization.Charting;
using KongN.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Utenti
{
    public partial class FrmCambiaPassword : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        public int _ID { get; set; }
        public bool _chiChiama { get; set; }
        public MethodInvoker _Crypta { get; set; }
        public MethodInvoker _Decripta { get; set; }



        public FrmCambiaPassword()
        {
            InitializeComponent();
        }

        private void FrmCambiaPassword_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            LoadData();

            txtPassword.Text = "";
            txtConfermaPassword.Text = "";

        }

        private void LoadData()
        {
            string query = "SELECT Password FROM Utenti WHERE ID = " + _ID;
            connKong.ExecQuery(query);

            if (connKong.RecordCount > 0)
            {
                txtPassword.Text = connKong.DBDT.Rows[0]["Password"].ToString();
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Sei sicuro? Questa azione interromperà il Programma.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:
                    // chiude il programma
                    Environment.ExitCode = 0;
                    if (_chiChiama == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        Application.Exit();
                    }

                    break;

                case DialogResult.No:

                    break;

            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = @"UPDATE Utenti SET Password = @Password, UltimoCambioPassword = @UltimoCambioPassword WHERE ID = " + _ID;

            connKong.AddParam("@Password", txtPassword.Text);
            connKong.AddParam("@UltimoCambioPassword", DateTime.Now);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore durante il salvataggio della password utente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Password salvata correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // adesso deve andare a inserire la password salvata nella tabella UtentiPassword
            query = "INSERT INTO UtentiPassword (idUtente, Password, DataPassword) VALUES (@idUtente, @Password, @DataPassword)";

            connKong.AddParam("@idUtente", _ID);
            connKong.AddParam("@Password", EncryptDecrypt.Encrypt(txtPassword.Text));
            connKong.AddParam("@DataPassword", DateTime.Now);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Si è verificato un errore nel salvataggio della password, iD Utente " + _ID);

                return;
            }

            this.Close();
        }

        private bool Check()
        {
            bool result = true;

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Inserire la Password", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();

                result = false;
                return result;
            }

            if (txtPassword.Text != txtConfermaPassword.Text)
            {
                MessageBox.Show("Le Password non corrispondono", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfermaPassword.Focus();

                result = false;
                return result;
            }

            if (ValPassword.ValidatePassword(txtPassword.Text, out string ErrorMessage) == false)
            {
                MessageBox.Show(ErrorMessage, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();

                result = false;
                return result;
            }


            ControllaUltimePassword conta = new ControllaUltimePassword();
            conta._id = _ID;
            conta._password = txtPassword.Text;

            if (conta.PasswordTrovata() == true)
            {
                MessageBox.Show("La password è stata utilizzata nelle ultime 10 volte, ne devi usare un'altra", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();

                result = false;
                return result;
            }

            return result;
        }

        //crypta la password on close
        private void FrmCambiaPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Crypta();
        }

        private void lblEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                txtConfermaPassword.PasswordChar = '\0';
                lblEye.Image = Properties.Resources.eye;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfermaPassword.PasswordChar = '*';
                lblEye.Image = Properties.Resources.eye_open;
            }
        }
    }
}
