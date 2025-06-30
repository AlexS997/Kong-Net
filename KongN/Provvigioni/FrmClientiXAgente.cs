using KongN.Classi;
using KongN.Stampa;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KongN.Provvigioni
{
    public partial class FrmClientiXAgente : Form
    {

        SQLControl sqlANA = new SQLControl(Global.connAna);

        DataTable dt = new DataTable();

        public FrmClientiXAgente()
        {
            InitializeComponent();
        }

        private void FrmClientiXAgente_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
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

            string s = "SELECT Clienti.CodCli, Clienti.Denom, TabAge.CodAge, TabAge.Descrizione " +
                    " FROM  Clienti INNER JOIN CliFatt3 ON Clienti.CodCli = CliFatt3.CodCli INNER JOIN " +
                         " TabAge ON CliFatt3.CodAge = TabAge.CodAge" +
                        " ORDER BY Clienti.CodCli ";
            sqlANA.ExecQuery(s);

            if (sqlANA.HasException(true))
            {
                MessageBox.Show("Errore durante l'estrazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dt = sqlANA.DBDT;


            Grid.DataSource = dt;



            lblRecord.Text = "Record: " + dt.Rows.Count.ToString();
            lblRecord.Visible = true;
        }

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            string query = "SELECT Clienti.CodCli, Clienti.Denom, TabAge.CodAge, TabAge.Descrizione " +
                    " FROM  Clienti INNER JOIN CliFatt3 ON Clienti.CodCli = CliFatt3.CodCli INNER JOIN " +
                         " TabAge ON CliFatt3.CodAge = TabAge.CodAge" +
                        " ORDER BY Clienti.CodCli ";

            sqlANA.ExecQuery(query);

            if (sqlANA.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati ContrattiNON.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();
            dt = sqlANA.DBDT;

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
                { "ReportTitle", "Clienti con Provvigioni" },
                 { "Param2", 123 }
             };
            // Crea un'istanza della form Stampa e passa i parametri


            // crea una variabile stringa che contiene dove sono gli eseguibili

            string path = Application.StartupPath;
            // crea una variabile stringa che contiene il percorso del report
            string reportPath = path + @"\Reports\";
            string reportName = "ClientiXAgente.frx";



            FormStampa stampa = new FormStampa(dt, reportPath, reportName, "Table", parameters);



            // Mostra il report
            stampa.ShowReport();
        }
    }
}
