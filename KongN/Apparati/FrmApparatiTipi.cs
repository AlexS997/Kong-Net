using KongN.Classi;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Apparati
{
    public partial class FrmApparatiTipi : Form
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

        public FrmApparatiTipi()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
        }

        private void FrmApparatiTipi_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM ApparatiTipi";
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Tipi Apparati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }

            bsTipi.DataSource = connKong.DBDT;

            ReadOnlyControls(true);
        }

        public void LeggiCampi(DataTable pannelli)
        {
            txtiD.Text = pannelli.Rows[0]["iD"].ToString();
            txtDescrizione.Text = pannelli.Rows[0]["Descrizione"].ToString();
        }

        public void AbbinaCampi()
        {
            txtiD.DataBindings.Add("Text", bsTipi, "iD");
            txtDescrizione.DataBindings.Add("Text", bsTipi, "Descrizione");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (txtiD.Text != "")
            {
                // prende la posizione del record dove eravamo posizionati
                int pos = Convert.ToInt32(txtiD.Text);
                ClearFields();
                LoadData();
                bsTipi.Find("iD", pos);
            }
            else
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "Delete From ApparatiTipi Where iD = @iD";
            connKong.AddParam("@iD", txtiD.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Tipi Apparati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (txtiD.Text == "")
            {
                query = "INSERT INTO ApparatiTipi (Descrizione) VALUES (@Descrizione)";
            }
            else
            {
                query = "UPDATE ApparatiTipi SET Descrizione = @Descrizione where iD = @iD";
            }

            connKong.AddParam("@iD", txtiD.Text);
            connKong.AddParam("@Descrizione", txtDescrizione.Text);


            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel salvataggio dei dati Tipi Apparati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
