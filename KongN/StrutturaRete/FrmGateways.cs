using KongN.Classi;
using KongN.ClassiTabelle;
using KongN.Funzioni;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.StrutturaRete
{
    public partial class FrmGateways : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;

        public FrmGateways()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmGateways_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM [2_gateways]";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Gateways.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClsFunzioni.FillComboBox("SELECT * FROM [1_fonti] order by FONTE", "iDFonte", "FONTE", cboIdFonte);

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }

            ReadOnlyControls(true);
        }

        public void LeggiCampi(DataTable gateways)
        {
            txtIDGateway.Text = gateways.Rows[0]["iDGateway"].ToString();
            txtGateway.Text = gateways.Rows[0]["Gateway"].ToString();
            txtDescrizione.Text = gateways.Rows[0]["Descrizione"].ToString();
            txtNote.Text = gateways.Rows[0]["Note"].ToString();
            cboIdFonte.SelectedValue = gateways.Rows[0]["iDFonte"].ToString();

            gateways.Rows[0]["Latitudine"] = gateways.Rows[0]["Latitudine"] == DBNull.Value ? gateways.Rows[0]["Latitudine"] = 0 : gateways.Rows[0]["Latitudine"];
            numLat.Value = Convert.ToDecimal(gateways.Rows[0]["Latitudine"]);
            
            gateways.Rows[0]["Longitudine"] = gateways.Rows[0]["Longitudine"] == DBNull.Value ? gateways.Rows[0]["Longitudine"] = 0 : gateways.Rows[0]["Longitudine"];
            numLong.Value = Convert.ToDecimal(gateways.Rows[0]["Longitudine"]);

            bsGateways.DataSource = gateways;
        }


        public void AbbinaCampi()
        {
            txtIDGateway.DataBindings.Add("Text", bsGateways, "iDGateway");
            txtGateway.DataBindings.Add("Text", bsGateways, "Gateway");
            txtDescrizione.DataBindings.Add("Text", bsGateways, "Descrizione");
            txtNote.DataBindings.Add("Text", bsGateways, "Note");
            numLat.DataBindings.Add("Text", bsGateways, "Latitudine");
            numLong.DataBindings.Add("Text", bsGateways, "Longitudine");
            cboIdFonte.DataBindings.Add("SelectedValue", bsGateways, "iDFonte");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ReadOnlyControls(bool x)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = x;
                }

                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).ReadOnly = x;
                    ((NumericUpDown)c).Enabled = !x;
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).Enabled = !x;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtIDGateway.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtIDGateway.Text);
                ClearFields();
                LoadData();
                bsGateways.Find("iDGateway", pos);
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
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtIDGateway.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtIDGateway.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtIDGateway.Text == "")
            {
                query = "INSERT INTO [2_gateways] (GATEWAY, Descrizione, Note, idFonte, Latitudine, Longitudine) " +
                    "VALUES (@GATEWAY, @Descrizione, @Note, @idFonte, @Latitudine, @Longitudine)";
            }
            else
            {
                query = "UPDATE [2_gateways] SET GATEWAY = @GATEWAY, Descrizione = @Descrizione, Note = @Note, " +
                    "idFonte = @idFonte, Latitudine = @Latitudine, Longitudine = @Longitudine where iDGateway = @iDGateway";
            }

            connKong.AddParam("@iDGateway", txtIDGateway.Text);
            connKong.AddParam("@GATEWAY", txtGateway.Text);
            connKong.AddParam("@Descrizione", txtDescrizione.Text);
            connKong.AddParam("@Note", txtNote.Text);
            connKong.AddParam("@idFonte", cboIdFonte.SelectedValue);
            connKong.AddParam("@Latitudine", numLat.Value);
            connKong.AddParam("@Longitudine", numLong.Value);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Gateway.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();

        }

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtGateway.Text))
            {
                MessageBox.Show("Inserire il nome del gateway.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGateway.Focus();
                result = false;
                return result;
            }

            if (string.IsNullOrEmpty(txtDescrizione.Text))
            {
                MessageBox.Show("Inserire il testo del descrizione.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescrizione.Focus();
                result = false;
                return result;
            }

            if (cboIdFonte.SelectedIndex == -1)
            {
                MessageBox.Show("Il campo id Fonte è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
                return result;
            }

            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool c = CheckEsiste();
            if (c == true)
            {
                MessageBox.Show("Impossibile cancellare il record. Esistono Ponti collegati a questo Gateway.");
                return;
            }

            switch (MessageBox.Show("Attenzione!!!! Confermi la cancellazione?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:

                    string query = "DELETE FROM [2_gateways] WHERE iDGateway = @iDGateway";

                    connKong.AddParam("@iDGateway", txtIDGateway.Text);

                    connKong.ExecQuery(query);

                    if (connKong.HasException(true))
                    {
                        MessageBox.Show("Errore nella cancellazione dei dati Gateway.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Dati Gateway cancellati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;

                case DialogResult.No:

                    break;

            }

            LoadData();
        }

        private bool CheckEsiste()
        {
            string s = "SELECT COUNT(*) FROM [3_ponti] WHERE idGateway = " + txtIDGateway.Text;
            connKong.ExecQuery(s);

            if (connKong.HasException())
            {
                MessageBox.Show("Si è verificato un errore nel recupero dati.");
                return true;
            }

            int n = Convert.ToInt32(connKong.DBDT.Rows[0][0]);


            if (n > 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnVediMappa_Click(object sender, EventArgs e)
        {
            FrmMappa frm = new FrmMappa();

            frm._TipoMarker = 0; // Gateway
            frm._dt = Ordinata();
            if (chkTutti.Checked == true)
            {
                frm.chiChiama = 1;

            }
            else
            {
                frm.chiChiama = 0; // mappa singola
            }


            frm.ShowDialog();



            if (MapPunto._Latitude != 0 && MapPunto._Longitude != 0)
            {
                numLat.Text = MapPunto._Latitude.ToString();
                numLong.Text = MapPunto._Longitude.ToString();
            }
        }

        private DataTable Ordinata()
        {
            string query = "";
            if (chkTutti.Checked == true)
            {
                query = "SELECT * From [2_gateways] WHERE  (NOT (Latitudine IS NULL)) AND (NOT (Longitudine IS NULL)) ORDER BY Latitudine";
            }
            else
            {
                query = "SELECT * From [2_gateways] WHERE  (NOT (Latitudine IS NULL)) AND (NOT (Longitudine IS NULL)) AND idGateway = " + txtIDGateway.Text;
            }

            connKong.ExecQuery(query);
            if (connKong.HasException())
            {
                MessageBox.Show("Si è verificato un errore nel recupero dati.");
                return null;
            }


            return connKong.DBDT;
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
