using KongN.Classi;
using KongN.ClassiTabelle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.SMS
{
    public partial class FrmStoricoSMS : Form
    {
        SQLControl connKong = new SQLControl(Global.connKongN);
        ButtonManager _buttonManager;
        public FrmStoricoSMS()
        {
            InitializeComponent();
            AbbinaCampi();

            _buttonManager = new ButtonManager(nav);
            _buttonManager.DisableButton("btnSave");
            _buttonManager.DisableButton("btnUndo");
            _buttonManager.DisableButton("btnAdd");
            _buttonManager.DisableButton("btnEdit");
            _buttonManager.DisableButton("btnSearch");
            _buttonManager.DisableButton("btnRefresh");
        }

        private void FrmStoricoSMS_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Sms";

            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Ponti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connKong.DBDT.Rows.Count > 0)
            {
                LeggiCampi(connKong.DBDT);

            }

            bsStorico.DataSource = connKong.DBDT;
        }

        public void LeggiCampi(DataTable antivirus)
        {
            txtId.Text = antivirus.Rows[0]["Id"].ToString();
        }

        public void AbbinaCampi()
        {
            txtId.DataBindings.Add("Text", bsStorico, "Id");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler eliminare i dati?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "DELETE FROM SMSStorico WHERE ID = @iD";

            connKong.AddParam("@iD", txtId.Text);
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                MessageBox.Show("Errore nell'eliminazione dei dati Sms.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Il Record è stato cancellato correttamente.", "Eliminazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
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
