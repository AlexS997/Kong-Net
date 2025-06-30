using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Contratti
{
    public partial class FrmRateContratto: Form
    {

        SQLControl connKongN = new SQLControl(Global.connKongN);

        public string _iDContratto { get; set; }
        public string _tipoContratto { get; set; }
        public string _codCli { get; set; }
        public string _denom { get; set; }



        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }


        public FrmRateContratto()
        {
            InitializeComponent();
        }

        private void FrmRateContratto_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            LoadData();

            lblContratto.Text = "Contratto: " + _iDContratto;
            lblTipoContratto.Text = "Tipo Contratto : " + _tipoContratto;
            lblCodCli.Text = "Cliente : " + _codCli;
            lblDenom.Text = "Denominazione : " + _denom;
        }

        private void LoadData()
        {
            
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
