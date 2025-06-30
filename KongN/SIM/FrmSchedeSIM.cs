using KongN.Classi;
using KongN.ClassiTabelle;
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

namespace KongN.SIM
{
    public partial class FrmSchedeSIM : Form
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

        public FrmSchedeSIM()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmSchedeSIM_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();

        }

        private void LoadData()
        {
            string query = "SELECT * FROM SchedeSim";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Schede Sim.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);

                foreach (DataRow row in connKong.DBDT.Rows)
                {
                    foreach (DataColumn column in connKong.DBDT.Columns)
                    {
                        if (row[column] == DBNull.Value)
                        {
                            row[column] = GetDefaultValue(column.DataType);
                        }
                    }
                }
            }


            bsSim.DataSource = connKong.DBDT;

            ReadOnlyControls(true);
        }

        //if there is a null value in the database, it will be replaced with the default value
        private object GetDefaultValue(Type dataType)
        {
            if (dataType == typeof(string))
                return string.Empty;
            if (dataType == typeof(DateTime))
                return DateTime.MinValue;
            if (dataType == typeof(int))
                return 0;
            if (dataType == typeof(bool))
                return false;
            return DBNull.Value;
        }

        public void LeggiCampi(DataTable sim)
        {
            txtId.Text = sim.Rows[0]["iD"].ToString();
            txtPuk.Text = sim.Rows[0]["Puk"].ToString();
            txtUtente.Text = sim.Rows[0]["Utente"].ToString();
            txtIMEI.Text = sim.Rows[0]["IMEI"].ToString();
            txtTelefono.Text = sim.Rows[0]["Telefono"].ToString();
            txtAPN.Text = sim.Rows[0]["APN"].ToString();
            txtFornitore.Text = sim.Rows[0]["Fornitore"].ToString();
            txtTipoAbbonamento.Text = sim.Rows[0]["TipoAbbonamento"].ToString();
            txtRiferimentoOperatore.Text = sim.Rows[0]["RiferimentoOperatore"].ToString();

            dtpDataAttivazione.Value = sim.Rows[0]["DataAttivazione"] == DBNull.Value ? dtpDataAttivazione.Value = null : Convert.ToDateTime(sim.Rows[0]["DataAttivazione"].ToString());

            chkInMagazzino.Checked = sim.Rows[0]["InMagazzino"] != DBNull.Value && Convert.ToBoolean(sim.Rows[0]["InMagazzino"]);
            chkDismessa.Checked = sim.Rows[0]["Dismessa"] != DBNull.Value && Convert.ToBoolean(sim.Rows[0]["Dismessa"]);
            chkAttiva.Checked = sim.Rows[0]["Attiva"] != DBNull.Value && Convert.ToBoolean(sim.Rows[0]["Attiva"]);

        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsSim, "iD");
            txtPuk.DataBindings.Add("Text", bsSim, "Puk");
            txtUtente.DataBindings.Add("Text", bsSim, "Utente");
            txtIMEI.DataBindings.Add("Text", bsSim, "IMEI");
            txtTelefono.DataBindings.Add("Text", bsSim, "Telefono");
            txtAPN.DataBindings.Add("Text", bsSim, "APN");
            txtFornitore.DataBindings.Add("Text", bsSim, "Fornitore");
            txtTipoAbbonamento.DataBindings.Add("Text", bsSim, "TipoAbbonamento");
            txtRiferimentoOperatore.DataBindings.Add("Text", bsSim, "RiferimentoOperatore");

            dtpDataAttivazione.DataBindings.Add("Value", bsSim, "DataAttivazione", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");

            chkInMagazzino.DataBindings.Add("Checked", bsSim, "InMagazzino");
            chkDismessa.DataBindings.Add("Checked", bsSim, "Dismessa");
            chkAttiva.DataBindings.Add("Checked", bsSim, "Attiva");
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
                if (c is Button)
                {
                    ((Button)c).Enabled = !x;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = !x;
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtId.Text);
                ClearFields();
                LoadData();
                bsSim.Find("iD", pos);
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
                if (c is SfDateTimeEdit)
                {
                    ((SfDateTimeEdit)c).Value = null;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ReadOnlyControls(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
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
                query = "INSERT INTO SchedeSim (Puk, Utente, IMEI, Telefono, APN, Fornitore, TipoAbbonamento, RiferimentoOperatore, InMagazzino, Dismessa, Attiva, DataAttivazione) " +
                    "VALUES (@Puk, @Utente, @IMEI, @Telefono, @APN, @Fornitore, @TipoAbbonamento, @RiferimentoOperatore, @InMagazzino, @Dismessa, @Attiva, @DataAttivazione)";
            }
            else
            {
                query = "UPDATE SchedeSim SET Puk = @Puk, Utente = @Utente, IMEI = @IMEI, Telefono = @Telefono, " +
                    "APN = @APN, Fornitore = @Fornitore, TipoAbbonamento = @TipoAbbonamento, RiferimentoOperatore = @RiferimentoOperatore, " +
                    "InMagazzino = @InMagazzino, Dismessa = @Dismessa, Attiva = @Attiva, DataAttivazione = @DataAttivazione where iD = @iD";
            }

            connKong.AddParam("@iD", txtId.Text);
            connKong.AddParam("@Puk", txtPuk.Text);
            connKong.AddParam("@Utente", txtUtente.Text);
            connKong.AddParam("@IMEI", txtIMEI.Text);
            connKong.AddParam("@Telefono", txtTelefono.Text);
            connKong.AddParam("@APN", txtAPN.Text);
            connKong.AddParam("@Fornitore", txtFornitore.Text);
            connKong.AddParam("@TipoAbbonamento", txtTipoAbbonamento.Text);
            connKong.AddParam("@RiferimentoOperatore", txtRiferimentoOperatore.Text);
            connKong.AddParam("@InMagazzino", chkInMagazzino.Checked);
            connKong.AddParam("@Dismessa", chkDismessa.Checked);
            connKong.AddParam("@Attiva", chkAttiva.Checked);
            connKong.AddParam("@DataAttivazione", dtpDataAttivazione.Value);


            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati SchedeSIM.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
        }

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtUtente.Text))
            {
                MessageBox.Show("Il campo Username è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUtente.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtFornitore.Text))
            {
                MessageBox.Show("Il campo Fornitore è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornitore.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtIMEI.Text))
            {
                MessageBox.Show("Il campo IMEI è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIMEI.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtTipoAbbonamento.Text))
            {
                MessageBox.Show("Il campo TipoAbbonamento è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipoAbbonamento.Focus();
                result = false;
                return result;
            }

            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From SchedeSim Where iD = @iD";
            connKong.AddParam("@iD", txtId.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Schede SIM.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);



            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEsclusione_Click(object sender, EventArgs e)
        {
            FrmSchedeSimFatture frm = new FrmSchedeSimFatture();
            frm._idSchedaSim = Convert.ToInt32(txtId.Text);
            frm.ShowDialog();
        }
    }
}
