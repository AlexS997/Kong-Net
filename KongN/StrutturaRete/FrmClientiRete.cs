using KongN.Classi;
using KongN.Find;
using KongN.Funzioni;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.StrutturaRete
{
    public partial class FrmClientiRete : Form
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

        public FrmClientiRete()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmClientiRete_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
            FillRecord();

            btnVediMappa.Enabled = true;
        }

        private void LoadData() 
        {
            string query = "SELECT * FROM [5_Clientirete]";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Ponti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClsFunzioni.FillComboBox("SELECT * FROM [4_pannelli] order by PANNELLO", "iDPannelli", "PANNELLO", cboLoc);


            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }

            bsClienti.DataSource = connKong.DBDT;

            ReadOnlyControls(true);

        }

        public void LeggiCampi(DataTable clRete)
        {

            txtiD.Text = clRete.Rows[0]["iD"].ToString();
            txtUsername.Text = clRete.Rows[0]["Username"].ToString();
            txtCodCli.Text = clRete.Rows[0]["CodCli"].ToString();
            txtDenom.Text = clRete.Rows[0]["Denom"].ToString();
            txtActualProfile.Text = clRete.Rows[0]["ActualProfile"].ToString();
            txtNote.Text = clRete.Rows[0]["Note"].ToString();

            clRete.Rows[0]["Latitudine"] = clRete.Rows[0]["Latitudine"] == DBNull.Value ? clRete.Rows[0]["Latitudine"] = 0 : clRete.Rows[0]["Latitudine"];
            numLat.Value = Convert.ToDecimal(clRete.Rows[0]["Latitudine"]);

            clRete.Rows[0]["Longitudine"] = clRete.Rows[0]["Longitudine"] == DBNull.Value ? clRete.Rows[0]["Longitudine"] = 0 : clRete.Rows[0]["Longitudine"];
            numLong.Value = Convert.ToDecimal(clRete.Rows[0]["Longitudine"]);

            cboLoc.SelectedValue = clRete.Rows[0]["iDPannelli"];

        }

        public void AbbinaCampi()
        {
            txtiD.DataBindings.Add("Text", bsClienti, "iD");
            txtUsername.DataBindings.Add("Text", bsClienti, "Username");
            txtCodCli.DataBindings.Add("Text", bsClienti, "CodCli");
            txtDenom.DataBindings.Add("Text", bsClienti, "Denom");
            txtActualProfile.DataBindings.Add("Text", bsClienti, "ActualProfile");
            txtNote.DataBindings.Add("Text", bsClienti, "Note");



            cboLoc.DataBindings.Add("SelectedValue", bsClienti, "iDPannelli");

            numLat.DataBindings.Add("Text", bsClienti, "Latitudine");
            numLong.DataBindings.Add("Text", bsClienti, "Longitudine");

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

                if (c is Button)
                {
                    ((Button)c).Enabled = !x;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtiD.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtiD.Text);
                ClearFields();
                LoadData();
                bsClienti.Find("iD", pos);
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
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
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
            txtiD.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtiD.ReadOnly = true;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodCli, Denom FROM Clienti WHERE Stato= 'A' ORDER BY Denom";

            connAna.ExecQuery(query);

            if (connAna.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Clienti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connAna.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {
                txtCodCli.Text = frm._ReturnData["CodCli"].ToString();
                txtDenom.Text = frm._ReturnData["Denom"].ToString();
            }
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtCodCli.Text = "";
            txtDenom.Text = "";
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
                query = "INSERT INTO [5_Clientirete] (Username, CodCli, Denom, iDpannelli, Location, ActualProfile, Latitudine, Longitudine, Note) " +
                    "VALUES (@Username, @CodCli, @Denom, @iDpannelli, @Location, @ActualProfile, @Latitudine, @Longitudine, @Note)";
            }
            else
            {
                query = "UPDATE [5_Clientirete] SET Username = @Username, CodCli = @CodCli, Denom = @Denom, iDpannelli = @iDpannelli, " +
                    "Location = @Location, ActualProfile = @ActualProfile, Latitudine = @Latitudine, Longitudine = @Longitudine, Note = @Note where iD = @iD";
            }

            connKong.AddParam("@iD", txtiD.Text);
            connKong.AddParam("@Username", txtUsername.Text);
            connKong.AddParam("@CodCli", txtCodCli.Text);
            connKong.AddParam("@Denom", txtDenom.Text);
            connKong.AddParam("@Location", cboLoc.SelectedValue);
            connKong.AddParam("@ActualProfile", txtActualProfile.Text);
            connKong.AddParam("@Latitudine", numLat.Value);
            connKong.AddParam("@Longitudine", numLong.Value);
            connKong.AddParam("@Note", txtNote.Text);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati ClientiRete.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            _buttonManager.HandleButtonClick((ToolStripButton)sender);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Attenzione!!!! Confermi la cancellazione?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:

                    string query = "DELETE FROM [5_Clientirete] WHERE iD = @iD";

                    connKong.AddParam("@iD", txtiD.Text);

                    connKong.ExecQuery(query);

                    if (connKong.HasException(true))
                    {
                        MessageBox.Show("Errore nella cancellazione dei dati Clienti Rete.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Dati Clienti Rete cancellati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();

                    break;

                case DialogResult.No:

                    break;


            }
        }

        private void btnEsclusione_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Sei sicuro di voler aggiungere questo nominativo alla tabella di esclusione?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:
                    InserisciInTabellaEsclusione();
                    FillRecord();
                    LoadData();
                    break;

                case DialogResult.No:

                    break;

            }
        }

        private void InserisciInTabellaEsclusione()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Non  c'è nulla da inserire", "Messaggio di Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO [6_TabellaEsclusionePannelli] ([UserName]) VALUES ('" + txtUsername.Text + "')";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'inserimento del nominativo nella tabella di esclusione", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // adesso cancella il nominativo dalla tabella 5_clientirete
            query = "DELETE FROM [5_Clientirete] WHERE [Username] = '" + txtUsername.Text + "'";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nella cancellazione del nominativo dalla tabella 5_clientirete", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Operazione terminata", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FillRecord()
        {
            // cancella i record che sono presenti nella tabella di esclusione
            string query = "DELETE FROM [5_Clientirete] WHERE [Username] IN (SELECT [UserName] FROM [6_TabellaEsclusionePannelli])";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nella cancellazione dei dati dalla tabella 5_clientirete", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnVediMappa_Click(object sender, EventArgs e)
        {
            FrmMappa frm = new FrmMappa();

            frm._TipoMarker = 2; // cliente
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
                query = "SELECT * From [5_ClientiRete] WHERE  (NOT (Latitudine IS NULL)) AND (NOT (Longitudine IS NULL)) ORDER BY Latitudine";

            }
            else
            {
                query = "SELECT * From [5_ClientiRete] WHERE  (NOT (Latitudine IS NULL)) AND (NOT (Longitudine IS NULL)) AND id = " + txtiD.Text;
            }

            connKong.ExecQuery(query);
            if (connKong.HasException())
            {

                return null;
            }


            return connKong.DBDT;
        }

    }
}
