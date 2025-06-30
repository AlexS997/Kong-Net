using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace KongN.Classi
{


    public class SQLControl
    {
        private SqlConnection DBCon = new SqlConnection("Server=Server2019;Database=KONGNEW;User=sa;Pwd=Caronte00;");
        private SqlCommand DBCmd;

        // DB DATA
        public SqlDataAdapter DBDA;
        public DataTable DBDT;

        // QUERY PARAMETERS
        public List<SqlParameter> Params = new List<SqlParameter>();

        // QUERY STATISTICS
        public int RecordCount;
        public string Exception;

        public SQLControl()
        {
        }

        // ALLOW CONNECTION STRING OVERRIDE
        public SQLControl(string ConnectionString)
        {
            DBCon = new SqlConnection(ConnectionString);
        }

        // EXECUTE QUERY SUB
        public void ExecQuery(string Query, bool ReturnIdentity = false)
        {
            // RESET QUERY STATS
            RecordCount = 0;
            Exception = "";

            try
            {
                DBCon.Open();

                // CREATE DB COMMAND
                DBCmd = new SqlCommand(Query, DBCon);
                DBCmd.CommandTimeout = 600;
                // LOAD PARAMS INTO DB COMMAND
                Params.ForEach(p => DBCmd.Parameters.Add(p));

                // CLEAR PARAM LIST
                Params.Clear();

                // EXECUTE COMMAND & FILL DATASET
                DBDT = new DataTable();
                DBDA = new SqlDataAdapter(DBCmd);
                RecordCount = DBDA.Fill(DBDT);

                if (ReturnIdentity == true)
                {
                    string ReturnQuery = "SELECT @@IDENTITY As LastID;";
                    // @@IDENTITY - SESSION
                    // SCOPE_IDENTITY() - SESSION & SCOPE
                    // IDENT_CURRENT(tablename) - LAST IDENT IN TABLE, ANY SCOPE, ANY SESSION
                    DBCmd = new SqlCommand(ReturnQuery, DBCon);
                    DBDT = new DataTable();
                    DBDA = new SqlDataAdapter(DBCmd);
                    RecordCount = DBDA.Fill(DBDT);
                }
            }
            catch (System.Exception ex)
            {
                // CAPTURE ERROR
                //Exception = "ExecQuery Errore: " + Constants.vbNewLine + ex.Message;
                Exception = "ExecQuery Errore: " + "\r\n" + ex.Message;
            }
            finally
            {
                // CLOSE CONNECTION
                if (DBCon.State == ConnectionState.Open)
                    DBCon.Close();
            }
        }

        // ADD PARAMS
        public void AddParam(string Name, object Value)
        {
            SqlParameter NewParam = new SqlParameter(Name, Value);
            Params.Add(NewParam);
        }

        // ERROR CHECKING
        public bool HasException(bool Report = false)
        {
            if (string.IsNullOrEmpty(Exception))
                return false;
            if (Report == true)
            {


                MessageBox.Show(Exception, "Exception:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }
    }

}
