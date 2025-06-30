using FastReport.DevComponents.AdvTree;
using KongN.Classi;
using KongN.Find;
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

namespace KongN.Voip
{
    public partial class FrmNumeriVoIP : Form
    {
        SQLControl connKong = new SQLControl(Global.connKongN);
        SQLControl connAna = new SQLControl(Global.connAna);

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

        public FrmNumeriVoIP()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmNumeriVoIP_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();


        }

        private void LoadData()
        {
            string query = "SELECT * FROM VoIPNumerovoip";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Numero VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            bsNumeri.DataSource = connKong.DBDT;

            ReadOnlyControls(true);
        }

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

        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Enabled = !x;
                }
                if(c is Button)
                {
                    ((Button)c).Enabled = !x;
                }
                if(c is SfDateTimeEdit)
                {
                    ((SfDateTimeEdit)c).Enabled = !x;
                }
            }
        }

        public void LeggiCampi(DataTable numeri)
        {
            txtId.Text = numeri.Rows[0]["iD"].ToString();
            txtPass.Text = numeri.Rows[0]["Password"].ToString();
            txtNumeroVoip.Text = numeri.Rows[0]["Numerovoip"].ToString();
            txtNumeroPortato.Text = numeri.Rows[0]["Numeroportato"].ToString();
            txtMigrazione.Text = numeri.Rows[0]["Migrazione"].ToString();
            txtMigrazioneOperatore.Text = numeri.Rows[0]["Migrazioneoperatore"].ToString();
            txtTipo.Text = numeri.Rows[0]["Tipo"].ToString();
            txtSeriale.Text = numeri.Rows[0]["Seriale"].ToString();
            txtIdOfferta.Text = numeri.Rows[0]["iDOfferta"].ToString();
            txtIdContratto.Text = numeri.Rows[0]["iDContratto"].ToString();
            txtDenom.Text = numeri.Rows[0]["Denom"].ToString();
            txtCodCli.Text = numeri.Rows[0]["CodCli"].ToString();
            txtNote.Text = numeri.Rows[0]["Note"].ToString();

            chkStato.Checked = numeri.Rows[0]["Stato"] != DBNull.Value && Convert.ToBoolean(numeri.Rows[0]["Stato"]);
            chkCancellato.Checked = numeri.Rows[0]["Cancellato"] != DBNull.Value && Convert.ToBoolean(numeri.Rows[0]["Cancellato"]);

            dtpInizio.Value = numeri.Rows[0]["Datainizio"] == DBNull.Value ? dtpInizio.Value = null : Convert.ToDateTime(numeri.Rows[0]["Datainizio"].ToString());
            dtpPort.Value = numeri.Rows[0]["Dataport"] == DBNull.Value ? dtpPort.Value = null : Convert.ToDateTime(numeri.Rows[0]["Dataport"].ToString());
            dtpFine.Value = numeri.Rows[0]["Datafine"] == DBNull.Value ? dtpFine.Value = null : Convert.ToDateTime(numeri.Rows[0]["Datafine"].ToString());
            dtpUltimaFatt.Value = numeri.Rows[0]["DataUltimaFatturazione"] == DBNull.Value ? dtpUltimaFatt.Value = null : Convert.ToDateTime(numeri.Rows[0]["DataUltimaFatturazione"].ToString());


        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsNumeri, "iD");
            txtPass.DataBindings.Add("Text", bsNumeri, "Password");
            txtNumeroVoip.DataBindings.Add("Text", bsNumeri, "Numerovoip");
            txtNumeroPortato.DataBindings.Add("Text", bsNumeri, "Numeroportato");
            txtMigrazione.DataBindings.Add("Text", bsNumeri, "Migrazione");
            txtMigrazioneOperatore.DataBindings.Add("Text", bsNumeri, "Migrazioneoperatore");
            txtTipo.DataBindings.Add("Text", bsNumeri, "Tipo");
            txtSeriale.DataBindings.Add("Text", bsNumeri, "Seriale");
            txtIdOfferta.DataBindings.Add("Text", bsNumeri, "iDOfferta");
            txtIdContratto.DataBindings.Add("Text", bsNumeri, "iDContratto");
            txtDenom.DataBindings.Add("Text", bsNumeri, "Denom");
            txtCodCli.DataBindings.Add("Text", bsNumeri, "CodCli");
            txtNote.DataBindings.Add("Text", bsNumeri, "Note");

            chkStato.DataBindings.Add("Checked", bsNumeri, "Stato");
            chkCancellato.DataBindings.Add("Checked", bsNumeri, "Cancellato");

            dtpInizio.DataBindings.Add("Value", bsNumeri, "Datainizio", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");
            dtpPort.DataBindings.Add("Value", bsNumeri, "Dataport", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");
            dtpFine.DataBindings.Add("Value", bsNumeri, "Datafine", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");
            dtpUltimaFatt.DataBindings.Add("Value", bsNumeri, "DataUltimaFatturazione", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd-MM-yyyy");

        }

        private void btnOfferta_Click(object sender, EventArgs e)
        {
            string query = "Select * from VoIPofferte ORDER BY Descrizione";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Offerte VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connKong.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData
                txtIdOfferta.Text = frm._ReturnData["idofferta"].ToString();
                lblOfferta.Text = frm._ReturnData["Descrizione"].ToString();

            }
        }

        private void btnContratto_Click(object sender, EventArgs e)
        {
            //string query = "Select * from Contratti ORDER BY IdContratto";

            string query = "SELECT  Clienti.CodCli, Clienti.Denom, Contratti.IdContratto, Contratti.TipoContr, Contratti.FStato" +
                " FROM Clienti INNER JOIN Contratti ON Clienti.CodCli = Contratti.CodCli" +
                " WHERE (Contratti.FStato = 'A') AND (Clienti.Stato = 'A') and TipoContr='VOIP'" +
                " ORDER BY Clienti.CodCli";
            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Contratti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connAna.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                // riporta i campi prendendoli da frm._ReturnData
                txtIdContratto.Text = frm._ReturnData["IdContratto"].ToString();
                txtDenom.Text = frm._ReturnData["Denom"].ToString();
                txtCodCli.Text = frm._ReturnData["CodCli"].ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
            txtIdOfferta.ReadOnly = true;
            txtIdContratto.ReadOnly = true;
            txtDenom.ReadOnly = true;
            txtCodCli.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtId.ReadOnly = true;
            txtIdOfferta.ReadOnly = true;
            txtIdContratto.ReadOnly = true;
            txtDenom.ReadOnly = true;
            txtCodCli.ReadOnly = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From VoIPNumerovoip Where iD = @iD";
            connKong.AddParam("@iD", txtId.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Numero VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati eliminati correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);



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
                bsNumeri.Find("iD", pos);
                ReadOnlyControls(true);
            }
            else
            {
                LoadData();
                ReadOnlyControls(true);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
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
                query = "INSERT INTO VoIPNumerovoip (iDContratto, CodCli, Denom, Password, Numerovoip, Numeroportato, Migrazione, Migrazioneoperatore, " +
                    "iDOfferta, Tipo, Seriale, Note, Stato, Cancellato, Datainizio, Dataport, Datafine, DataUltimaFatturazione) " +
                    "VALUES (@iDContratto, @CodCli, @Denom, @Password, @Numerovoip, @Numeroportato, @Migrazione, @Migrazioneoperatore, " +
                    "@iDOfferta, @Tipo, @Seriale, @Note, @Stato, @Cancellato, @Datainizio, @Dataport, @Datafine, @DataUltimaFatturazione)";
            }
            else
            {
                query = "UPDATE VoIPNumerovoip SET iDContratto = @iDContratto, CodCli = @CodCli, Denom = @Denom, Password = @Password, " +
                    "Numerovoip = @Numerovoip, Numeroportato = @Numeroportato, Migrazione = @Migrazione, Migrazioneoperatore = @Migrazioneoperatore, " +
                    "iDOfferta = @iDOfferta, Tipo = @Tipo, Seriale = @Seriale, Note = @Note, Stato = @Stato, Cancellato = @Cancellato, " +
                    "Datainizio = @Datainizio, Dataport = @Dataport, Datafine = @Datafine, DataUltimaFatturazione = @DataUltimaFatturazione where iD = @iD";
            }

            connKong.AddParam("@iD", txtId.Text);
            connKong.AddParam("@iDContratto", txtIdContratto.Text);
            connKong.AddParam("@CodCli", txtCodCli.Text);
            connKong.AddParam("@Denom", txtDenom.Text);
            connKong.AddParam("@Password", txtPass.Text);
            connKong.AddParam("@Numerovoip", txtNumeroVoip.Text);
            connKong.AddParam("@Numeroportato", txtNumeroPortato.Text);
            connKong.AddParam("@Migrazione", txtMigrazione.Text);
            connKong.AddParam("@Migrazioneoperatore", txtMigrazioneOperatore.Text);
            connKong.AddParam("@iDOfferta", txtIdOfferta.Text);
            connKong.AddParam("@Tipo", txtTipo.Text);
            connKong.AddParam("@Seriale", txtSeriale.Text);
            connKong.AddParam("@Note", txtNote.Text);

            connKong.AddParam("@Stato", chkStato.Checked);
            connKong.AddParam("@Cancellato", chkCancellato.Checked);

            connKong.AddParam("@Datainizio", dtpInizio.Value);
            connKong.AddParam("@Dataport", dtpPort.Value);
            connKong.AddParam("@Datafine", dtpFine.Value);
            connKong.AddParam("@DataUltimaFatturazione", dtpUltimaFatt.Value);

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

            if (string.IsNullOrEmpty(txtIdContratto.Text))
            {
                MessageBox.Show("Il campo Id Contratto è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdContratto.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtIdOfferta.Text))
            {
                MessageBox.Show("Il campo Id Offerta è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdOfferta.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtNumeroVoip.Text))
            {
                MessageBox.Show("Il campo Numero VoIP è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroVoip.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtNumeroPortato.Text) && !string.IsNullOrEmpty(txtMigrazione.Text))
            {
                MessageBox.Show("Il campo Numero Portato è obbligatorio se il campo Migrazione è valorizzato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPortato.Focus();
                result = false;
                return result;
            }

            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
