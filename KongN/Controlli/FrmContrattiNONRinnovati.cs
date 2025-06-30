using KongN.Classi;
using KongN.Stampa;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Controlli
{
    public partial class FrmContrattiNONRinnovati : Form
    {

        SQLControlSP sqlSP = new SQLControlSP(Global.connKongN);
        SQLControl ContrattiNON = new SQLControl(Global.connKongN);

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }

        public FrmContrattiNONRinnovati()
        {
            InitializeComponent();
        }

        private void FrmContrattiNONRinnovati_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            lblRecord.Visible = false;
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            Estrai();
        }

        private void Estrai()
        {
            CancellaTabelle();


            if (rbuNonRinnovati.Checked)
            {
                sqlSP.AddParam("@Rinnovo", 1);
            }

            sqlSP.ExecStoredProcedure("sp_ContrattiNONRinnovati");

            if (sqlSP.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;
            }


            string query = "Select * from ContrattiNON Order BY CodCli, IdContratto";

            ContrattiNON.ExecQuery(query);
            if (ContrattiNON.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Eccezione");
                return;

            }

            Grid.DataSource = ContrattiNON.DBDT;

            int r = ContrattiNON.DBDT.Rows.Count;
            lblRecord.Visible = true;
            lblRecord.Text = "Record Estratti: " + r.ToString();

            return;
        }

        private void CancellaTabelle()
        {
            string ConNon = @"Delete from ContrattiNON DBCC CHECKIDENT ('ContrattiNON', RESEED, 0)";

            ContrattiNON.ExecQuery(ConNon);

            if (ContrattiNON.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;

            }

            return;
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            //// Check if there is data in Grid
            //if (ContrattiNON.DBDT == null || ContrattiNON.DBDT.Rows.Count == 0)
            //{
            //    MessageBox.Show("Non ci sono dati per generare il rapporto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            //// Crea un dizionario di parametri
            //var parameters = new Dictionary<string, object>
            // {
            //    { "ReportTitle", "ContrattiNON" },
            //     { "Param2", 123 }
            // };


            //string path = Application.StartupPath;
            //// Look for the path of the .frx report file
            //string reportPath = path + @"\Reports\";
            //string reportName = "ReportContrattiNONRinnovati.frx";

            //// Create the instance of the report form and generate the report
            //FormStampa formRapport = new FormStampa(ContrattiNON.DBDT, reportPath, reportName, "Table", parameters);

            //formRapport.ShowReport();

            string query = "Select * from ContrattiNON Order BY CodCli, IdContratto";

            ContrattiNON.ExecQuery(query);

            if (ContrattiNON.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati ContrattiNON.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();
            dt = ContrattiNON.DBDT;

            // verifica se ci sono dati nel datatable
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono dati per generare il rapporto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // crea un nuovo report
            // Crea un dizionario di parametri
            var parameters = new Dictionary<string, object>
             {
                { "ReportTitle", "Contratti NON Rinnovati" },
                 { "Param2", 123 }
             };
            // Crea un'istanza della form Stampa e passa i parametri


            // crea una variabile stringa che contiene dove sono gli eseguibili

            string path = Application.StartupPath;
            // crea una variabile stringa che contiene il percorso del report
            string reportPath = path + @"\Reports\";
            string reportName = "ContrattiNON.frx";



            FormStampa stampa = new FormStampa(dt, reportPath, reportName, "Table", parameters);



            // Mostra il report
            stampa.ShowReport();

        }
    }
}
