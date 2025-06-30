using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Utenti
{
    public partial class FrmVedi : Form
    {

        public DataTable _DT { get; set; }

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.Transparent;
        }

        public FrmVedi()
        {
            InitializeComponent();
        }

        private void FrmVedi_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            // Verifica se _DT è popolato
            if (_DT != null && _DT.Rows.Count > 0)
            {
                // Assegna _DT come DataSource della griglia
                Grid.DataSource = _DT;
            }
            else
            {
                MessageBox.Show("Nessun dato disponibile per la visualizzazione.");
            }

            if (_DT.Rows.Count > 0)
            {
                Grid.DataSource = _DT;

            }
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
