using KongN.Classi;
using KongN.Funzioni;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.StrutturaRete
{
    public partial class FrmPannelli : Form
    {
        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;

        public FrmPannelli()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmPannelli_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
            ReadOnlyControls(true);
        }

        private void LoadData()
        {
            string query = "SELECT * FROM [4_pannelli]";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Pannelli.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClsFunzioni.FillComboBox("SELECT * FROM [3_ponti] order by Ponte", "iDPonti", "Ponte", cboIdPonti);
            ClsFunzioni.FillComboBox("SELECT * FROM [4_tecnologia] order by Tecnologia", "iD", "Tecnologia", cboTecnologia);


            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }
        }

        public void LeggiCampi(DataTable pannelli)
        {

            txtIDPannelli.Text = pannelli.Rows[0]["iDPannelli"].ToString();
            txtPONTE.Text = pannelli.Rows[0]["PONTE"].ToString();
            txtPANNELLO.Text = pannelli.Rows[0]["PANNELLO"].ToString();
            txtNote.Text = pannelli.Rows[0]["Note"].ToString();

            cboIdPonti.SelectedValue = pannelli.Rows[0]["idPonti"].ToString();
            cboTecnologia.SelectedValue = pannelli.Rows[0]["Tecnologia"].ToString();

            pannelli.Rows[0]["Apertura"] = pannelli.Rows[0]["Apertura"] == DBNull.Value ? pannelli.Rows[0]["Apertura"] = 0 : pannelli.Rows[0]["Apertura"];
            numApertura.Value = Convert.ToDecimal(pannelli.Rows[0]["Apertura"]);

            pannelli.Rows[0]["Distanza"] = pannelli.Rows[0]["Distanza"] == DBNull.Value ? pannelli.Rows[0]["Distanza"] = 0 : pannelli.Rows[0]["Distanza"];
            numDistanza.Value = Convert.ToDecimal(pannelli.Rows[0]["Distanza"]);

            pannelli.Rows[0]["Direzione"] = pannelli.Rows[0]["Direzione"] == DBNull.Value ? pannelli.Rows[0]["Direzione"] = 0 : pannelli.Rows[0]["Direzione"];
            numDirezione.Value = Convert.ToDecimal(pannelli.Rows[0]["Direzione"]);

            bsPannelli.DataSource = pannelli;
        }

        public void AbbinaCampi()
        {
            txtIDPannelli.DataBindings.Add("Text", bsPannelli, "iDPannelli");
            txtPONTE.DataBindings.Add("Text", bsPannelli, "PONTE");
            txtPANNELLO.DataBindings.Add("Text", bsPannelli, "PANNELLO");
            txtNote.DataBindings.Add("Text", bsPannelli, "Note");

            cboIdPonti.DataBindings.Add("SelectedValue", bsPannelli, "idPonti");
            cboTecnologia.DataBindings.Add("SelectedValue", bsPannelli, "Tecnologia");

            numApertura.DataBindings.Add("Text", bsPannelli, "Apertura");
            numDistanza.DataBindings.Add("Text", bsPannelli, "Distanza");
            numDirezione.DataBindings.Add("Text", bsPannelli, "Direzione");
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

        public bool Check()
        {
            bool result = true;

            if (string.IsNullOrEmpty(txtPANNELLO.Text))
            {
                MessageBox.Show("Il campo Pannello è obbligatorio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPANNELLO.Focus();
                result = false;
                return result;
            }

            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtIDPannelli.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtIDPannelli.Text);
                ClearFields();
                LoadData();
                bsPannelli.Find("iDPannelli", pos);
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
            txtIDPannelli.ReadOnly = true;
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnlyControls(false);
            txtIDPannelli.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }

            string query = "";

            if (txtIDPannelli.Text == "")
            {
                query = "INSERT INTO [4_pannelli] (PONTE, Note, PANNELLO, idPonti, Apertura, Distanza, Direzione, Tecnologia) " +
                    "VALUES (@PONTE, @Note, @PANNELLO, @idPonti, @Apertura, @Distanza, @Direzione, @Tecnologia)";
            }
            else
            {
                query = "UPDATE [4_pannelli] SET PONTE = @PONTE, Note = @Note, PANNELLO = @PANNELLO, " +
                    "idPonti = @idPonti, Apertura = @Apertura, Distanza = @Distanza, Direzione = @Direzione, Tecnologia = @Tecnologia where iDPannelli = @iDPannelli";
            }

            connKong.AddParam("@iDPannelli", txtIDPannelli.Text);
            connKong.AddParam("@PONTE", txtPONTE.Text);
            connKong.AddParam("@Note", txtNote.Text);
            connKong.AddParam("@PANNELLO", txtPANNELLO.Text);
            connKong.AddParam("@idPonti", cboIdPonti.SelectedValue);
            connKong.AddParam("@Apertura", numApertura.Value);
            connKong.AddParam("@Distanza", numDistanza.Value);
            connKong.AddParam("@Direzione", numDirezione.Value);
            connKong.AddParam("@Tecnologia", cboTecnologia.SelectedValue);

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Pannelli.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Dati salvati correttamente.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            ReadOnlyControls(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Attenzione!!!! Il programma non controlla se ci sono dei clienti attaccati a questo pannello.  Confermi la cancellazione?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:

                    string query = "DELETE FROM [4_pannelli] WHERE iDPannelli = @iDPannelli";

                    connKong.AddParam("@iDPannelli", txtIDPannelli.Text);

                    connKong.ExecQuery(query);

                    if (connKong.HasException(true))
                    {
                        MessageBox.Show("Errore nella cancellazione dei dati ponti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Dati Pannello cancellati correttamente.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;

                case DialogResult.No:

                    break;


            }
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
