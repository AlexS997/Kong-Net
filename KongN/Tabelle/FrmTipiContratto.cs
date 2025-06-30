using KongN.Classi;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Tabelle
{
    public partial class FrmTipiContratto : Form
    {

        private void dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        public FrmTipiContratto()
        {
            InitializeComponent();

            dataGridView.RowPrePaint += dataGridView_RowPrePaint;
        }

        private void FrmTipiContratto_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
        }

        private bool Check()
        {
            bool check = true;
            if (string.IsNullOrEmpty(txtDescrizione.Text))
            {
                MessageBox.Show("Descrizione non può essere vuota");
                check = false;
            }
            if (string.IsNullOrEmpty(txtCodice.Text))
            {
                MessageBox.Show("Codice non può essere vuoto");
                check = false;
            }
            return check;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
