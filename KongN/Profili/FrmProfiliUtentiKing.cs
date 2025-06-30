using KongN.Classi;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace KongN.Profili
{
    public partial class FrmProfiliUtentiKing : Form
    {

        SQLControl SQL = new SQLControl(Global.connKongN);
        SQLControl cnANA = new SQLControl(Global.connAna);


        public FrmProfiliUtentiKing()
        {
            InitializeComponent();
        }


        private void FrmProfiliUtentiKing_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            Services.Tracker.Track(this);
            CaricaRecord();

        }


        private void CaricaRecord()
        {
            string query = "Select * from ProfiliKing Order by CodCli";
            SQL.ExecQuery(query);

            if (SQL.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;

            }
            else
            {
                Grid.DataSource = SQL.DBDT;
                //Grid.Refresh();
                lblRecord.Text = "Record estratti: " + SQL.RecordCount.ToString();
            }
        }


        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEstraiDaKing_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Attenzione se prelevi i dati da King questi prenderanno il posto di quelli presenti attualmente. Confermi?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:
                    CancellaRecord();
                    EstraiDaKing();

                    break;

                case DialogResult.No:

                    break;

            }
        }


        private void CancellaRecord()
        {
            string query = "Delete from ProfiliKing";

            SQL.ExecQuery(query);
            if (SQL.HasException(true))
            {
                MessageBox.Show("Si è verificata un'Eccezione");
                return;

            }
            else
            {
                Grid.DataSource = SQL.DBDT;
            }
        }


        private void CancellaTabelle()
        {
            string queryKong = @"Delete from ProfiliKing DBCC CHECKIDENT ('ProfiliKing', RESEED, 0)";

            SQL.ExecQuery(queryKong);

            if (SQL.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Eccezione");
                return;
            }
        }


        private void EstraiDaKing()
        {

            CancellaTabelle();


            // esempio di come si può fare la connessione con la stringa di connessione

            //var conn = ConfigurationManager.ConnectionStrings[connKong].ConnectionString;
            //var csb = new SqlConnectionStringBuilder(conn);
            //String DataSource = csb.DataSource;
            //string Username = csb.UserID;
            //string Password = csb.Password;
            //string InitialCatalog = csb.InitialCatalog;

            SqlConnectionStringBuilder builderK = new SqlConnectionStringBuilder(Global.connKongN);

            string dataSourceK = builderK.DataSource;
            string initialCatalogK = builderK.InitialCatalog;
            string userIdK = builderK.UserID;
            string passwordK = builderK.Password;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Global.connAna);

            string dataSource = builder.DataSource;
            string initialCatalog = builder.InitialCatalog;
            string userId = builder.UserID;
            string password = builder.Password;





            //SqlConnectionStringBuilder csbAna = new SqlConnectionStringBuilder(Global.connAna);
            //SqlConnectionStringBuilder csbKongN = new SqlConnectionStringBuilder(Global.connKongN);

            //string combinedConnectionString = $"Data Source={csbAna.DataSource};Initial Catalog={csbAna.InitialCatalog};User ID={csbAna.UserID};Password={csbAna.Password};" +
            //                                  $"Data Source={csbKongN.DataSource};Initial Catalog={csbKongN.InitialCatalog};User ID={csbKongN.UserID};Password={csbKongN.Password};";

           // SQLControl connNew = new SQLControl(combinedConnectionString);


            string stato = chkAncheDisdetti.Checked ? "" : "AND c.FStato = 'A'";


            string query = $"Insert into {initialCatalogK} .DBO.ProfiliKing(IdContratto, CodCli, Denom, TipoContr, FStato, U_UserName, U_Ricaricabile, ArtMag, DescrAgg) ";
                   query += $"select C.IdContratto , c.CodCli, cli.Denom, c.TipoContr, c.FStato, c.U_UserName, c.U_Ricaricabile, d.ArtMag, d.DescrAgg from {initialCatalog}.dbo.Contratti as C ";
                   query += $"INNER JOIN {initialCatalog}.dbo.DettVociContr as D ";
                   query += "ON c.IdContratto = d.IdContratto ";
                   query += $"INNER JOIN {initialCatalog}.dbo.Clienti AS Cli ";
                   query += "ON c.Codcli = Cli.CodCli ";
                   query += $"WHERE (c.TipoContr  in (select CodTipo from {initialCatalog}.dbo.TipiContr AS B Where B.U_Connessione = 1)) ";
                   query += stato;
                   query += " ORDER BY c.CodCli, d.ArtMag";


            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        Console.WriteLine($"{rowsAffected} le righe sono state inserite.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Si è verificato un errore: {ex.Message}");
                }
            }


            string query2 = "Delete from ProfiliKing where ProfiliKing.ArtMag not in (select ArticoliProvvigioni.CodArt from ArticoliProvvigioni)";
            SQL.ExecQuery(query2);

            if (SQL.HasException(true))
            {
                MessageBox.Show("Si è verificato un'Errore leggendo i dati dalla tabella ArticoliProvvigioni");
                return;
            }

            MessageBox.Show("Informazioni Aggiornate", "Messaggio di Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CaricaRecord();
        }


        private void btnPreleva_Click(object sender, EventArgs e)
        {
            if (Grid.RowCount == 0)
            {
                MessageBox.Show("La Tabella dei Profili di King è vuota, prima devi prelevarli .", "Messaggio di Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            if (UnisciTabelle()) Preleva();
        }


        private bool UnisciTabelle()
        {
            bool result = false;

            DataTable dt = new DataTable();

            string Ana = "Select * from TipiContr WHERE U_Connessione = 1";

            cnANA.ExecQuery(Ana);

            if (cnANA.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Errore recuperando i dati dalla tabella TipiContr Del Database");

                result = false;
                return result;
            }
            else
            {
                dt = cnANA.DBDT;
            }


            StringBuilder sb = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                sb.Append(row["CodTipo"].ToString());
                sb.Append(",");
            }
            // Remove the trailing comma from the end of the stringbuilder
            sb.Length = sb.Length - 1;



            //prima cancella la tabella temporanea  
            string query = "Delete from ProfiliKingTemp dbcc checkident ('ProfiliKingTemp', reseed, 0)";

            using (SqlConnection cn = new SqlConnection(Global.connKongN))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                try
                {
                    cn.Open();

                    cmd.ExecuteNonQuery();

                    // poi la riempie con i dati della tabella ProfiliKing
                    query = "Insert into ProfiliKingTemp (IdContratto, CodCli, Denom, TipoContr, FStato, U_UserName, U_Ricaricabile, ArtMag, DescrAgg) " +
                            "Select IdContratto, CodCli, Denom, TipoContr, FStato, U_UserName, U_Ricaricabile, ArtMag, DescrAgg from ProfiliKing";

                    cmd = new SqlCommand(query, cn);
                    cmd.ExecuteNonQuery();

                    // poi la riempie con i dati della tabella ProfiliUtentiTutti che hanno i campi U_UserName e Username uguali
                    query = "UPDATE ProfiliKingTemp " +
                                "SET ActualProfile = ProfiliUtentiTutti.ActualProfile, Username = ProfiliUtentiTutti.Username, Comment = ProfiliUtentiTutti.Comment " +
                                "FROM ProfiliKingTemp INNER JOIN ProfiliUtentiTutti ON ProfiliKingTemp.U_UserName = ProfiliUtentiTutti.Username";

                    cmd = new SqlCommand(query, cn);
                    cmd.ExecuteNonQuery();

                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Si è verificato il seguente errore :" + ex, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
                finally
                {
                    cn.Close();
                }
            }

            return result;
        }


        private void Preleva()
        {
            try
            {
                SqlConnection connKongN = new SqlConnection(Global.connKongN);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dtProfili = new DataTable();

                string query = "SELECT * FROM ProfiliKingTemp";  

                if (chkSoloErrati.Checked && rbuKing.Checked)
                {
                    query += " WHERE ActualProfile <> ArtMag";
                }

                if (rbuUsermanager.Checked)
                {
                    query = "SELECT * FROM ProfiliUtentiTutti T WHERE NOT EXISTS (" +
                            "SELECT * FROM ProfiliKingTemp U WHERE U.U_UserName = T.Username)";
                }

                dataAdapter.SelectCommand = new SqlCommand(query, connKongN);




                dataAdapter.Fill(dtProfili);

                if (dtProfili.Rows.Count == 0)
                {
                    MessageBox.Show("La tabella è vuota.", "Messaggio di Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Grid.DataSource = dtProfili;

                lblRecord.Text = "Record estratti: " + dtProfili.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore :" + ex.Message, "Messaggio di Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnStampa_Click(object sender, EventArgs e)
        {

        }


        #region Grid Color Style
        private void Grid_QueryCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryCellStyleEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex-2 < Grid.View.Records.Count)
            {
                var record = Grid.View.Records[e.RowIndex -2].Data as DataRowView;

                if (record != null)
                {
                    string artMagValue = record.Row.Table.Columns.Contains("ArtMag") ? record["ArtMag"].ToString() : string.Empty;
                    string actualProfileValue = record.Row.Table.Columns.Contains("ActualProfile") ? record["ActualProfile"].ToString() : string.Empty;

                    if (!record.Row.Table.Columns.Contains("ActualProfile"))
                    {
                        if (e.RowIndex % 2 == 0)
                        {
                            e.Style.BackColor = Color.AliceBlue;
                        }
                        else
                        {
                            e.Style.BackColor = Color.White;
                        }
                        return;
                    }

                    if (artMagValue != actualProfileValue &&  artMagValue != "")
                    {
                        e.Style.BackColor = Color.LemonChiffon;
                        return;
                    }
                    else if (artMagValue == "" && actualProfileValue == "")
                    {
                        if (e.RowIndex % 2 == 0)
                        {
                            e.Style.BackColor = Color.AliceBlue;
                        }
                        else
                        {
                            e.Style.BackColor = Color.White;
                        }
                    }

                }
            }
        }

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.Style.BackColor = Color.AliceBlue;
                }
                else
                {
                    e.Style.BackColor = Color.White;
                }
            }
        }
        #endregion

    }
}
