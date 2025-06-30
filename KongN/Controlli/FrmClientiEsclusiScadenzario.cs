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
    public partial class FrmClientiEsclusiScadenzario : Form
    {

        SQLControl Clienti = new SQLControl(Global.connAna);
        DataTable dt = new DataTable();

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }


        public FrmClientiEsclusiScadenzario()
        {
            InitializeComponent();

        }


        private void FrmClientiEsclusiScadenzario_Load(object sender, EventArgs e)
        {

            Services.Tracker.Track(this);
            lblRecord.Visible = false;

        }


        private void btnEstrai_Click(object sender, EventArgs e)
        {
            Estrai();
        }


        private void Estrai()
        {

            string sqlQuery = "SELECT CodCli,Denom,U_EscludiScadenziario  FROM  Clienti Where U_EscludiScadenziario = 1";
            Clienti.ExecQuery(sqlQuery);


            if (Clienti.HasException(true))
            {
                MessageBox.Show(this + " - Errore durante l'estrazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Grid.DataSource = Clienti.DBDT;
            int r = Clienti.DBDT.Rows.Count;
            lblRecord.Visible = true;
            lblRecord.Text = "Record Estratti: " + r.ToString();
            dt = Clienti.DBDT;

        }


        private void btnStampa_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodCli, Denom, Ind, Prov, Loc, Tel, PIva, CF FROM Clienti Where U_EscludiScadenziario = 1";

            Clienti.ExecQuery(query);

            if (Clienti.HasException(true))
            {
                MessageBox.Show("Errore nel caricamento dei dati Clienti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = new DataTable();
            dt = Clienti.DBDT;

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
                { "ReportTitle", "Clienti Esclusi Scadenzario" },
                 { "Param2", 123 }
             };
            // Crea un'istanza della form Stampa e passa i parametri


            // crea una variabile stringa che contiene dove sono gli eseguibili

            string path = Application.StartupPath;
            // crea una variabile stringa che contiene il percorso del report
            string reportPath = path + @"\Reports\";
            string reportName = "ClientiEsclusiScadenzario.frx";



            FormStampa stampa = new FormStampa(dt, reportPath, reportName, "Table", parameters);



            // Mostra il report
            stampa.ShowReport();
        }


        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
