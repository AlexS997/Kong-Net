using KongN.Classi;
using KongN.ClassiTabelle;
using KongN.Funzioni;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Apparati
{
    public partial class FrmApparati : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;

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

        public FrmApparati()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmApparati_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();

            txtIdUtente.Visible = false;
            dtpModifica.Visible = false;
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Apparati";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Apparati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClsFunzioni.FillComboBox("SELECT * FROM ApparatiTipi order by Descrizione", "iD", "Descrizione", cboTipo);

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);

            }


            bsApparati.DataSource = connKong.DBDT;

            ReadOnlyControls(true);
        }

        public void LeggiCampi(DataTable apparati)
        {
            txtId.Text = apparati.Rows[0]["iD"].ToString();
            txtDescrizione.Text = apparati.Rows[0]["Descrizione"].ToString();
            txtApparato.Text = apparati.Rows[0]["Apparato"].ToString();
            txtLuogoApparato.Text = apparati.Rows[0]["LuogoApparato"].ToString();
            txtIndirizzoIP.Text = apparati.Rows[0]["IndirizzoIP"].ToString();
            txtUsername.Text = apparati.Rows[0]["Username"].ToString();
            txtPassword.Text = apparati.Rows[0]["Password"].ToString();
            txtIdUtente.Text = apparati.Rows[0]["iDUtente"].ToString();
            txtNote.Text = apparati.Rows[0]["Note"].ToString();

            dtpInstallazione.Value = apparati.Rows[0]["DataInstallazione"] == DBNull.Value ? dtpInstallazione.Value = null : Convert.ToDateTime(apparati.Rows[0]["DataInstallazione"].ToString());
            dtpModifica.Value = apparati.Rows[0]["DataModifica"] == DBNull.Value ? dtpModifica.Value = null : Convert.ToDateTime(apparati.Rows[0]["DataModifica"].ToString());

            cboTipo.SelectedValue = apparati.Rows[0]["Tipo"];
        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsApparati, "iD");
            txtDescrizione.DataBindings.Add("Text", bsApparati, "Descrizione");
            txtApparato.DataBindings.Add("Text", bsApparati, "Apparato");
            txtLuogoApparato.DataBindings.Add("Text", bsApparati, "LuogoApparato");
            txtIndirizzoIP.DataBindings.Add("Text", bsApparati, "IndirizzoIP");
            txtUsername.DataBindings.Add("Text", bsApparati, "Username");
            txtPassword.DataBindings.Add("Text", bsApparati, "Password");
            txtIdUtente.DataBindings.Add("Text", bsApparati, "iDUtente");
            txtNote.DataBindings.Add("Text", bsApparati, "Note");

            dtpInstallazione.DataBindings.Add("Value", bsApparati, "DataInstallazione", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");
            dtpModifica.DataBindings.Add("Value", bsApparati, "DataModifica", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy HH:mm");

            cboTipo.DataBindings.Add("SelectedValue", bsApparati, "Tipo");

        }

        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
                if (c is SfDateTimeEdit)
                {
                    ((SfDateTimeEdit)c).Enabled = !x;
                }
                if(c is ComboBox)
                {
                    ((ComboBox)c).Enabled = !x;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtId.Text);
                ClearFields();
                LoadData();
                bsApparati.Find("iD", pos);
                ReadOnlyControls(true);
            }
            else
            {
                LoadData();
            }
        }

        private void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Tag?.ToString() != "idUtente")
                {
                    ((TextBox)c).Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
            ClearFields();
            txtIdUtente.Text = Global.ID.ToString();
            dtpModifica.Value = DateTime.Now;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
            txtIdUtente.Text = Global.ID.ToString();
            dtpModifica.Value = DateTime.Now;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From Apparati Where iD = @iD";
            connKong.AddParam("@iD", txtId.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Apparati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);



            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtId.Text == "")
            {
                query = "INSERT INTO Apparati (Descrizione, Note, Apparato, LuogoApparato, IndirizzoIP, Username, Password, DataInstallazione, Tipo, iDUtente, DataModifica) " +
                    "VALUES (@Descrizione, @Note, @Apparato, @LuogoApparato, @IndirizzoIP, @Username, @Password, @DataInstallazione, @Tipo, @iDUtente, @DataModifica)";
            }
            else
            {
                query = "UPDATE Apparati SET Descrizione = @Descrizione, Note = @Note, Apparato = @Apparato, LuogoApparato = @LuogoApparato, " +
                    "IndirizzoIP = @IndirizzoIP, Username = @Username, Password = @Password, DataInstallazione = @DataInstallazione, " +
                    "Tipo = @Tipo, iDUtente = @iDUtente, DataModifica = @DataModifica where iD = @iD";
            }

            connKong.AddParam("@iD", txtId.Text);
            connKong.AddParam("@Descrizione", txtDescrizione.Text);
            connKong.AddParam("@Note", txtNote.Text);
            connKong.AddParam("@Apparato", txtApparato.Text);
            connKong.AddParam("@LuogoApparato", txtLuogoApparato.Text);
            connKong.AddParam("@IndirizzoIP", txtIndirizzoIP.Text);
            connKong.AddParam("@Username", txtUsername.Text);
            connKong.AddParam("@Password", txtPassword.Text);
            connKong.AddParam("@iDUtente", txtIdUtente.Text);

            connKong.AddParam("@Tipo", cboTipo.SelectedValue);

            connKong.AddParam("@DataInstallazione", dtpInstallazione.Value);
            connKong.AddParam("@DataModifica", dtpModifica.Value);


            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Apparati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtDescrizione.Text))
            {
                MessageBox.Show("Il campo Descrizione è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescrizione.Focus();
                result = false;
                return result;
            }

            return result;
        }
    }
}
