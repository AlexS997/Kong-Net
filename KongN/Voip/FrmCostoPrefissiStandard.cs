using KongN.Classi;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Voip
{
    public partial class FrmCostoPrefissiStandard : Form
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

        public FrmCostoPrefissiStandard()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
            _buttonManager.DisableButton("btnDelete");
            _buttonManager.DisableButton("btnEdit");
            _buttonManager.DisableButton("btnAdd");
        }

        private void FrmCostoPrefissiStandard_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();

        }

        private void LoadData()
        {

            string query = "SELECT * FROM VoiPPrefissiStandard";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Prefissi Standard VoIP.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);
            }

            bsPrefissi.DataSource = connKong.DBDT;

            ReadOnlyControls(true);
        }
        
        public void LeggiCampi(DataTable prefissi)
        {
            txtPrefisso.Text = prefissi.Rows[0]["CODICE"].ToString();
            txtDESTINAZIONESTD.Text = prefissi.Rows[0]["DESTINAZIONESTD"].ToString();

            prefissi.Rows[0]["RATE"] = prefissi.Rows[0]["RATE"] == DBNull.Value ? prefissi.Rows[0]["RATE"] = 0 : prefissi.Rows[0]["RATE"];
            numCosto.Value = Convert.ToDecimal(prefissi.Rows[0]["RATE"]);
        }

        public void AbbinaCampi()
        {
            txtPrefisso.DataBindings.Add("Text", bsPrefissi, "CODICE");
            numCosto.DataBindings.Add("Text", bsPrefissi, "RATE");
            txtDESTINAZIONESTD.DataBindings.Add("Text", bsPrefissi, "DESTINAZIONESTD");
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

    }
}
