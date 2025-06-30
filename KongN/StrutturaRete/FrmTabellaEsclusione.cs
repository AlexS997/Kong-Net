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

namespace KongN.StrutturaRete
{
    public partial class FrmTabellaEsclusione : Form
    {
        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;

        public FrmTabellaEsclusione()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmTabellaEsclusione_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
            ReadOnlyControls(true);
        }

        private void LoadData()
        {
            string query = "SELECT * FROM [6_TabellaEsclusionePannelli]";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Pannelli.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }
        }

        public void LeggiCampi(DataTable esclusione)
        {

            txtiD.Text = esclusione.Rows[0]["iD"].ToString();
            txtUsername.Text = esclusione.Rows[0]["UserName"].ToString();


            bsEsclusione.DataSource = esclusione;
        }

        public void AbbinaCampi()
        {
            txtiD.DataBindings.Add("Text", bsEsclusione, "iD");
            txtUsername.DataBindings.Add("Text", bsEsclusione, "UserName");
        }

        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtiD.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtiD.Text);
                ClearFields();
                LoadData();
                bsEsclusione.Find("iD", pos);
                ReadOnlyControls(true);
            }
            else
            {
                LoadData();
                ReadOnlyControls(true);
            }
        }

        private void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ReadOnlyControls(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Attenzione!!!! Confermi la cancellazione?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:


                    break;

                case DialogResult.No:

                    break;

            }

            LoadData();
            ReadOnlyControls(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtiD.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtiD.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtiD.Text == "")
            {
                query = "INSERT INTO [6_TabellaEsclusionePannelli] (UserName) VALUES (@UserName)";
            }
            else
            {
                query = "UPDATE [6_TabellaEsclusionePannelli] SET UserName = @UserName where iD = @iD";
            }

            connKong.AddParam("@iD", txtiD.Text);
            connKong.AddParam("@UserName", txtUsername.Text);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
        }

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Il campo Username è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                result = false;
                return result;
            }

            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
