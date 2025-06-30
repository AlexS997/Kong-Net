using KongN.Classi;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Syncfusion.PdfViewer.Base;
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
using Syncfusion.WinForms.DataGrid.Enums;


namespace KongN.Profili
{
    public partial class FrmProfiliUtenti : Form
    {


        SQLControl connKongN = new SQLControl(Global.connKongN);
        SQLControl SQLAPI = new SQLControl(Global.connKongN);
        DataTable dt = new DataTable();


        private string stringApi = "";

        private void Grid_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow && e.RowIndex % 2 == 0)
                e.Style.BackColor = Color.AliceBlue;
            else
                e.Style.BackColor = Color.White;
        }


        public FrmProfiliUtenti()
        {
            InitializeComponent();

            Grid.QueryRowStyle += Grid_QueryRowStyle;
        }


        private void FrmProfiliUtenti_Load(object sender, EventArgs e)
        {
            Services.Tracker.Track(this);
            CaricaRecord();
        }


        private void CaricaRecord()
        {

            string query = "Select * From ProfiliUtentiTutti ORDER by username";
            connKongN.ExecQuery(query);
            if (connKongN.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Eccezione");
                return;

            }

            else
            {

                Grid.DataSource = connKongN.DBDT;

            }

           
            query = "Select * from Automatismi ";

            SQLAPI.ExecQuery(query);
            if (SQLAPI.HasException(true))
            {
                MessageBox.Show(" Si è verificata un'Eccezione nell'apertura della tabella Automatismi");
                btnPreleva.Enabled = false;

                return;

            }

            else
            {

                stringApi = SQLAPI.DBDT.Rows[0].Field<string>("getAllUsername");

            }

        }


        private void VuotaTabella()
        {
            try
            {
                //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[connKong].ConnectionString))
                //{
                //    con.Open();
                //    using (SqlCommand command = new SqlCommand("DELETE FROM ProfiliUtentiTutti", con))
                //    {
                //        command.ExecuteNonQuery();
                //    }
                //    con.Close();
                //}


                string query = "DELETE FROM ProfiliUtentiTutti";
                connKongN.ExecQuery(query);

                if (connKongN.HasException(true))
                {
                    MessageBox.Show("Si è verificato un errore nella cancellazione dei dati", "Messaggio di Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }



            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Si è verificato un Errore: {0}", ex.Message));
                return;
            }
        }



        private void SalvaRecord()


        //esempio

        //string sql = "INSERT INTO T (A, B, C) VALUES (@A, @B, @C)";
        //using (SqlConnection conn = new SqlConnection(connectionString))
        //{   
        //   conn.Open();   
        //   foreach (DataRow r in myTable.Rows)   
        //   {      
        //       SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandText = sql;      
        //       cmd.Parameters.AddWithValue("@A", r["A"]);      
        //       cmd.Parameters.AddWithValue("@B", r["B"]);      
        //       cmd.Parameters.AddWithValue("@C", r["C"]);      
        //       cmd.ExecuteNonQuery();   
        //   }
        //}

        {
            // cancella i record della tabella  
            VuotaTabella();
            string sql =@"INSERT INTO ProfiliUtentiTutti (ActualProfile, Username, Location, comment) VALUES (@ActualProfile, @Username, @Location, @comment)";
            // cursore attendere
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                foreach (DataRow r in dt.Rows)
                {


                    // se la lunghezza del campo comment è maggiore di 200 caratteri, tronca il campo a 200 caratteri
                    if (r["comment"].ToString().Length > 200)
                    {
                        r["comment"] = r["comment"].ToString().Substring(0, 200);
                    }
                    connKongN.AddParam("@ActualProfile", r["ActualProfile"]);
                    connKongN.AddParam("@Username", r["Username"]);
                    connKongN.AddParam("@Location", r["Location"]);
                    connKongN.AddParam("@comment", r["comment"]);
                    connKongN.ExecQuery(sql);
                    if (connKongN.HasException(true))
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Si è verificato un errore nell'inserimento dei dati", "Messaggio di Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Si è verificato un errore nell'inserimento dei dati : " + ex, "Messaggio di Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cursor.Current = Cursors.Default;
            MessageBox.Show("I Record Sono Stati Salvati.", "Messaggio di sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);








            //-----------------------------------------------------
            // come era prima con sqlbulkcopy
            //-----------------------------------------------------

            //string csDestination = ConfigurationManager.ConnectionStrings[connKong].ConnectionString;//"put here the a connection string to the database";

            //using (SqlConnection connection = new SqlConnection(csDestination))
            //using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
            //using (SqlCommand cmd = new SqlCommand("DELETE FROM ProfiliUtentiTutti", connection))


            //{
            //    try
            //    {
            //        connection.Open();
            //        // cancella i record della tabella
            //        cmd.ExecuteNonQuery();

            //        bulkCopy.DestinationTableName = "ProfiliUtentiTutti";
            //        bulkCopy.WriteToServer(dt);
            //        MessageBox.Show("I Record Sono Stati Salvati.", "Messaggio di sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        CaricaRecord();
            //    }
            //    catch (Exception e)
            //    {

            //        MessageBox.Show("Si è verificato un errore con una eccezzione " + e, "Messaggio di Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;

            //    }

            //}
        }




        //private void btnStampa_Click(object sender, EventArgs e)


        //{

        //    try
        //    {
        //        FrmStampa f = new FrmStampa();


        //        //ReportDocument cr = new ReportDocument();
        //        string ReportName = "_ProfiliTutti.rpt";


        //        //cr.Load(@"Report\\" + ReportName);
        //        // f.crViewer.ReportSource = cr;

        //        f.crViewer.Refresh();

        //        var conn = ConfigurationManager.ConnectionStrings[connKong].ConnectionString;
        //        var csb = new SqlConnectionStringBuilder(conn);
        //        String DataSource = csb.DataSource;
        //        string Username = csb.UserID;
        //        string Password = csb.Password;
        //        string InitialCatalog = csb.InitialCatalog;




        //        //cr.SetDatabaseLogon(Username, Password);
        //        f.ShowDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Si è verificato un errore :" + ex.Message, "Messaggio di Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);


        //    }


        //}


        private void btnEsci_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPreleva_Click(object sender, EventArgs e)
        {
            if (Grid.RowCount > 0)
            {
                switch (MessageBox.Show("Attenzione, se prelevi nuovamente i nuovi valori prenderanno il posto dei vecchi. Confermi?", "Messaggio di Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.Yes:
                        VuotaTabella();

                        break;

                    case DialogResult.No:

                        break;


                }
            }



            //mikrotik / userman
            /* GetAll
             * preleva tutti i profili da usermanager
             * 
             */
            Cursor.Current = Cursors.WaitCursor;
            //lblAttendere.Visible = true;
            // JClass jclass = new JClass("http://server.local:8092/mikrotik/userman");
            JClass jclass = new JClass(stringApi);
            JObject j = await jclass.SendRequest();
            JArray jArray = jclass.ReturnRequest(j);

            if (jArray == null)
            {
                MessageBox.Show("Array Vuoto :");

            }

            else
            {

                Grid.DataSource = jArray;


                dt = JsonConvert.DeserializeObject<DataTable>(jArray.ToString());


                Cursor.Current = Cursors.Default;



            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (Grid.RowCount == 0)
                return;
            else

                SalvaRecord();
        }

        private void btnProfiliDiretti_Click(object sender, EventArgs e)
        {
            // cursore attendere
            Cursor.Current = Cursors.WaitCursor;

            dt = Cmk.mkGetAll();
            if (dt.Rows.Count == 0)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Non ci sono profili diretti da mostrare. Molto probabilmente si è verificato un errore.", "Messaggio di Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Grid.DataSource = dt;
            }
            Cursor.Current = Cursors.Default;
            MessageBox.Show("I profili sono stati Prelevati.", System.Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

}