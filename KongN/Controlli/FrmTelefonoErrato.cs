using KongN.Classi;
using KongN.Stampa;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Controlli
{
    public partial class FrmTelefonoErrato : Form
    {

        SQLControl Telefono = new SQLControl(Global.connKongN);
        SQLControlSP sqlSP = new SQLControlSP(Global.connKongN);

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }

        public FrmTelefonoErrato()
        {
            InitializeComponent();

        }

        private void FrmTelefonoErrato_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            lblRecord.Visible = false;
        }


        private void btnEstrai_Click(object sender, EventArgs e)
        {
            CancellaTabelle();


            sqlSP.ExecStoredProcedure("sp_ClientiTelefono");

            if (sqlSP.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;
            }


            string query = "Select * from ClientiTelefono Order BY Codcli";

            Telefono.ExecQuery(query);
            if (Telefono.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Eccezione");
                return;

            }

            Grid.DataSource = Telefono.DBDT;
            int r = Telefono.DBDT.Rows.Count;
            lblRecord.Visible = true;
            lblRecord.Text = "Record Estratti: " + r.ToString();

            return;
        }

        private void CancellaTabelle()
        {
            string query = "Delete from ClientiTelefono";

            Telefono.ExecQuery(query);

            if (Telefono.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;

            }

            return;
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            //// Check if there is data in Grid
            //if (Telefono.DBDT == null || Telefono.DBDT.Rows.Count == 0)
            //{
            //    MessageBox.Show("Non ci sono dati per generare il rapporto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Look for the path of the .frx report file
            //string reportPath = @"C:\Path\Reports";
            //string reportName = "ReportClientiTelefono.frx";

            //// Create the instance of the report form and generate the report
            //FormStampa formRapport = new FormStampa(Telefono.DBDT, reportPath, reportName, "ClientiTelefono", null);

            //formRapport.ShowReport();



            string query = "Select * from ClientiTelefono Order BY Codcli";

            Telefono.ExecQuery(query);

            if (Telefono.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Telefono.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();
            dt = Telefono.DBDT;

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
                { "ReportTitle", "Clienti con Telefono Errato" },
                 { "Param2", 123 }
             };
            // Crea un'istanza della form Stampa e passa i parametri


            // crea una variabile stringa che contiene dove sono gli eseguibili

            string path = Application.StartupPath;
            // crea una variabile stringa che contiene il percorso del report
            string reportPath = path + @"\Reports\";
            string reportName = "ClientiTelefono.frx";



            FormStampa stampa = new FormStampa(dt, reportPath, reportName, "Table", parameters);



            // Mostra il report
            stampa.ShowReport();
        }
    }
}
