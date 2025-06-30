using KongN.Classi;
using KongN.Find;
using KongN.Funzioni;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.StrutturaRete
{
    public partial class FrmPonti : Form
    {

        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;

        public FrmPonti()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmPonti_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
            ReadOnlyControls(true);
            btnVediMappa.Enabled = true;
        }

        private void LoadData()
        {
            string query = "SELECT * FROM [3_ponti]";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Ponti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClsFunzioni.FillComboBox("SELECT * FROM [2_gateways] order by GATEWAY", "iDGateway", "GATEWAY", cboIdGateway);

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }
        }

        public void LeggiCampi(DataTable ponti)
        {

            txtiDPonti.Text = ponti.Rows[0]["iDPonti"].ToString();
            txtPonte.Text = ponti.Rows[0]["Ponte"].ToString();
            txtNote.Text = ponti.Rows[0]["Note"].ToString();
            txtIdPontePadre.Text = ponti.Rows[0]["idPontePadre"].ToString();
            txtDipendenza.Text = ponti.Rows[0]["Dipendenza"].ToString();

            cboIdGateway.SelectedValue = ponti.Rows[0]["idGateway"].ToString();

            ponti.Rows[0]["Latitudine"] = ponti.Rows[0]["Latitudine"] == DBNull.Value ? ponti.Rows[0]["Latitudine"] = 0 : ponti.Rows[0]["Latitudine"];
            numLat.Value = Convert.ToDecimal(ponti.Rows[0]["Latitudine"]);

            ponti.Rows[0]["Longitudine"] = ponti.Rows[0]["Longitudine"] == DBNull.Value ? ponti.Rows[0]["Longitudine"] = 0 : ponti.Rows[0]["Longitudine"];
            numLong.Value = Convert.ToDecimal(ponti.Rows[0]["Longitudine"]);

            bsPonti.DataSource = ponti;
        }

        public void AbbinaCampi()
        {
            txtiDPonti.DataBindings.Add("Text", bsPonti, "iDPonti");
            txtPonte.DataBindings.Add("Text", bsPonti, "Ponte");
            txtNote.DataBindings.Add("Text", bsPonti, "Note");
            txtIdPontePadre.DataBindings.Add("Text", bsPonti, "idPontePadre");
            txtDipendenza.DataBindings.Add("Text", bsPonti, "Dipendenza");

            cboIdGateway.DataBindings.Add("SelectedValue", bsPonti, "idGateway");

            numLat.DataBindings.Add("Text", bsPonti, "Latitudine");
            numLong.DataBindings.Add("Text", bsPonti, "Longitudine");

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtiDPonti.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtiDPonti.ReadOnly = true;
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

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtiDPonti.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtiDPonti.Text);
                ClearFields();
                LoadData();
                bsPonti.Find("iDPonti", pos);
                ReadOnlyControls(true);
            }
            else
            {
                LoadData();
                ReadOnlyControls(true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtiDPonti.Text == "")
            {
                query = "INSERT INTO [3_ponti] (Ponte, Note, idPontePadre, idGateway, Dipendenza, Latitudine, Longitudine) " +
                    "VALUES (@Ponte, @Note, @idPontePadre, @idGateway, @Dipendenza, @Latitudine, @Longitudine)";
            }
            else
            {
                query = "UPDATE [3_ponti] SET Ponte = @Ponte, Note = @Note, idPontePadre = @idPontePadre, " +
                    "idGateway = @idGateway, Dipendenza = @Dipendenza, Latitudine = @Latitudine, Longitudine = @Longitudine where iDPonti = @iDPonti";
            }

            connKong.AddParam("@iDPonti", txtiDPonti.Text);
            connKong.AddParam("@Ponte", txtPonte.Text);
            connKong.AddParam("@Note", txtNote.Text);
            connKong.AddParam("@idPontePadre", txtIdPontePadre.Text);
            connKong.AddParam("@idGateway", cboIdGateway.SelectedValue);
            connKong.AddParam("@Dipendenza", txtDipendenza.Text);
            connKong.AddParam("@Latitudine", numLat.Value);
            connKong.AddParam("@Longitudine", numLong.Value);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Ponti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            ReadOnlyControls(true);

        }

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtPonte.Text))
            {
                MessageBox.Show("Il campo Ponte è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPonte.Focus();
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
                MessageBox.Show("Impossibile cancellare il record. Esistono Pannelli collegati a questo Gateway.");
                return;
            }

            switch (MessageBox.Show("Attenzione!!!! Confermi la cancellazione?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:

                    string query = "DELETE FROM [3_ponti] WHERE iDPonti = @iDPonti";

                    connKong.AddParam("@iDPonti", txtiDPonti.Text);

                    connKong.ExecQuery(query);

                    if (connKong.HasException(true))
                    {
                        MessageBox.Show("Errore nella cancellazione dei dati ponti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Dati Ponti cancellati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;

                case DialogResult.No:

                    break;

            }

            LoadData();
            ReadOnlyControls(true);
        }

        private bool CheckEsiste() 
        {
            string s = "SELECT COUNT(*) FROM [4_pannelli] WHERE idPonti = " + txtiDPonti.Text;
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

        private void btnPulisciPadre_Click(object sender, EventArgs e)
        {
            txtIdPontePadre.Text = "";
            lblDescrizionePontePadre.Text = "Nessun Ponte Padre";
        }

        private void btnPadre_Click(object sender, EventArgs e)
        {
            string query = "Select * from [3_ponti] Order By Ponte";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Clienti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // effettua la ricerca del cliente
            FormFind frm = new FormFind();
            frm._DT = connKong.DBDT;

            frm.ShowDialog();

            if (frm._ReturnData != null)
            {

                txtIdPontePadre.Text = frm._ReturnData["iDPonti"].ToString();
                lblDescrizionePontePadre.Text = frm._ReturnData["Ponte"].ToString();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVediMappa_Click(object sender, EventArgs e)
        {
            FrmMappa frm = new FrmMappa();

            frm._TipoMarker = 1; // ponte
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
                query = "SELECT * From [3_ponti] WHERE  (NOT (Latitudine IS NULL)) AND (NOT (Longitudine IS NULL)) ORDER BY Latitudine";

            }
            else
            {
                query = "SELECT * From [3_ponti] WHERE  (NOT (Latitudine IS NULL)) AND (NOT (Longitudine IS NULL)) AND idPonti = " + txtiDPonti.Text;
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
