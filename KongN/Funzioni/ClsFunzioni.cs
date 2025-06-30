using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using KongN.Classi;


namespace KongN.Funzioni
{
    internal class ClsFunzioni
    {
        public static void FillComboBox(string sql, string Value_Member, string Display_Member, ComboBox combo)
        {
            DataTable dt = new DataTable();


            // aggiunta fatta in data 30/10/2023 per fare inmodo che prenda òa stringa 
            // di connessione giusta nel file app.config se siamo in Debug o in Release 
            // in modo da poter lavorare con il database di test o quello di produzione


            //string connectionString = ConfigurationManager.ConnectionStrings[connKong].ConnectionString;
            //using (var connection = new SqlConnection(connectionString))
            using (var connection = new SqlConnection(Global.connKongN))
            {
                using (var cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(" Error : " + e.ToString());
                    }
                }
            }
            combo.DataSource = dt;
            combo.ValueMember = Value_Member;
            combo.DisplayMember = Display_Member;
        }


    }
}
