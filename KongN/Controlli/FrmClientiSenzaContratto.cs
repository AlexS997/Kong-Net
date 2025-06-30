using KongN.Classi;
using KongN.Stampa;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KongN.Controlli
{
    public partial class FrmClientiSenzaContratto : Form
    {

        SQLControl Profili = new SQLControl(Global.connKongN);
        SQLControl Contratti = new SQLControl(Global.connAna);

        DataTable dt = new DataTable();

        public FrmClientiSenzaContratto()
        {
            InitializeComponent();

            Grid.QueryRowStyle += Grid_QueryRowStyle;
            Grid.QueryCellStyle += Grid_QueryCellStyle;
        }

        private void FrmClientiSenzaContratto_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);

            label.Text = "Questa procedura ha senso solo se sono stati prelevati i profili\n da UserManager da relativemente poco tempo.\n" +
                "Se si è sicuri di voler proseguire, premere il pulsante 'Estrai' e poi 'Stampa'.";

            lblRecord.Visible = false;
            Bar.Visible = false;
        }


        private void btnEstrai_Click(object sender, EventArgs e)
        {
            if (ContollaPresenzaProfili())
            {
                Estrai();
            }
        }

        private bool ContollaPresenzaProfili()
        {

            string sqlString = "SELECT COUNT(*) FROM ProfiliUtentiTutti";
            Profili.ExecQuery(sqlString);

            if (Profili.HasException(true))
            {
                MessageBox.Show("Errore durante l'estrazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Profili.RecordCount == 0)
            {
                MessageBox.Show("Non ci sono profili caricati da analizzare. Prima Prelevali da UserManager", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Estrai()
        {

            string k = "Select ActualProfile,Username,Comment From ProfiliUtentiTutti ORDER BY ActualProfile";
            Profili.ExecQuery(k);

            if (Profili.HasException(true))
            {
                MessageBox.Show("Errore durante l'estrazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int r = Profili.DBDT.Rows.Count;
            lblRecord.Visible = true;
            lblRecord.Text = "Record Estratti: " + r.ToString();

            dt = Profili.DBDT;

            dt.Columns.Add("IdContratto", typeof(string));
            dt.Columns.Add("CodCli", typeof(string));
            dt.Columns.Add("Denom", typeof(string));
            dt.Columns.Add("TipoContr", typeof(string));
            dt.Columns.Add("FStato", typeof(string));
            dt.Columns.Add("U_UserName", typeof(string));
            dt.Columns.Add("ProfiloKing", typeof(string));
            dt.Columns.Add("U_Ricaricabile", typeof(string));


            Bar.Visible = true;
            Bar.Maximum = dt.Rows.Count;
            Bar.Minimum = 0;

            foreach (DataRow row in dt.Rows)
            {
                Bar.Value += 1;
                string profilo = row["ActualProfile"].ToString();
                string userman = row["Username"].ToString();

                string query = "SELECT Contratti.IdContratto, Contratti.CodCli, Clienti.Denom, Contratti.TipoContr, Contratti.FStato, Contratti.U_Ricaricabile, Contratti.U_UserName, DettVociContr.ArtMag AS ProfiloKing" +
                    " FROM   Contratti INNER JOIN" +
             " Clienti ON Contratti.CodCli = Clienti.CodCli INNER JOIN" +
             " DettVociContr ON Contratti.IdContratto = DettVociContr.IdContratto INNER JOIN" +
             " Articoli ON DettVociContr.ArtMag = Articoli.CodArt" +
                    " WHERE(Contratti.FStato = 'A') AND  Articoli.U_ArticoloKong = 1 AND " +
                    "(Contratti.U_UserName = '" + userman + "')" +
                    " ORDER BY Contratti.IdContratto";


                Contratti.ExecQuery(query);
                if (Contratti.HasException(true))
                {
                    MessageBox.Show("Errore durante l'estrazione dei dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Grid.DataSource = dt;

                if (Contratti.RecordCount == 0)
                {
                    row["IdContratto"] = "N/A";
                    row["CodCli"] = "N/A";
                    row["Denom"] = "N/A";
                    row["TipoContr"] = "N/A";
                    row["FStato"] = "N/A";
                    row["U_UserName"] = "N/A";
                    row["ProfiloKing"] = "N/A";
                    row["U_Ricaricabile"] = "N/A";

                }
                else
                {
                    row["IdContratto"] = Contratti.DBDT.Rows[0]["IdContratto"].ToString();
                    row["CodCli"] = Contratti.DBDT.Rows[0]["CodCli"].ToString();
                    row["Denom"] = Contratti.DBDT.Rows[0]["Denom"].ToString();
                    row["TipoContr"] = Contratti.DBDT.Rows[0]["TipoContr"].ToString();
                    row["FStato"] = Contratti.DBDT.Rows[0]["FStato"].ToString();
                    row["U_UserName"] = Contratti.DBDT.Rows[0]["U_UserName"].ToString();
                    row["ProfiloKing"] = Contratti.DBDT.Rows[0]["ProfiloKing"].ToString();
                    row["U_Ricaricabile"] = Contratti.DBDT.Rows[0]["U_Ricaricabile"].ToString();
                }

            }


            Grid.Refresh();

            Bar.Visible = false;

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Grid Color Style
        private void Grid_QueryCellStyle(object sender, QueryCellStyleEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                //change the color for that row with a given column and cell condition
                var record = Grid.View.Records[e.RowIndex - 1].Data as DataRowView;
                if (record != null && record["IdContratto"].ToString() == "N/A")
                {
                    e.Style.BackColor = Color.LightGoldenrodYellow;
                }

                if (record != null && record["ProfiloKing"].ToString().Trim() != record["ActualProfile"].ToString().Trim() && record["ProfiloKing"].ToString().Trim() != "N/A")
                {
                    e.Style.BackColor = Color.LightGreen;
                }
            }
        }

        private void Grid_QueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }
        #endregion

        private void btnStampa_Click(object sender, EventArgs e)
        {

            // verifica se ci sono dati nel datatable
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Non ci sono dati per generare il rapporto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crea un'istanza della form Stampa e passa i parametri
            var parameters = new Dictionary<string, object>
             {
                { "ReportTitle", "Clienti Senza Contratto" },
                 { "Param2", 123 }
             };


            // crea una variabile stringa che contiene dove sono gli eseguibili
            string path = Application.StartupPath;

            // crea una variabile stringa che contiene il percorso del report
            string reportPath = path + @"\Reports\";
            string reportName = "ClientiSenzaContratto.frx";


            FormStampa stampa = new FormStampa(dt, reportPath, reportName, "Table", parameters);


            // Mostra il report
            stampa.ShowReport();
        }
    }
}
