using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.Classi
{
    public class TipiColonne
    {
        public string Nome { get; set; } = "";
        public int Lunghezza { get; set; } = 0;
        public int Decimali { get; set; } = 0;
        public Type Tipo { get; set; }
    }

    public class ClsTableSchema
    {
        public List<TipiColonne> Colonnes = new List<TipiColonne>();
        public DataTable Ta = new DataTable();

        // Constructor with connection string and table name
        public ClsTableSchema(string connectionString, string tableName)
        {
            Apri(connectionString, tableName);
        }

        // Open the connection and get the schema of the table
        public void Apri(string connectionString, string tableName)
        {
            using (SqlConnection Cn = new SqlConnection(connectionString))
            {
                Cn.Open();

                /*Crează o interogare SQL simplă care selectează toate coloanele din tabel, 
                 * dar nu extrage date (WHERE 1 = 0 este o condiție care nu va returna niciun rând, dar va returna doar schema). */
                string sqlQuery = $"SELECT * FROM {tableName} WHERE 1 = 0";

                using (SqlCommand Co = new SqlCommand(sqlQuery, Cn))
                {
                    using (SqlDataReader Dr = Co.ExecuteReader())
                    {
                        DataTable Schema = Dr.GetSchemaTable();

                        for (int n = 0; n < Schema.Rows.Count; n++)
                        {
                            var _colonna = new TipiColonne()
                            {
                                Nome = Schema.Rows[n]["ColumnName"].ToString(),
                                Lunghezza = Convert.ToInt32(Schema.Rows[n]["ColumnSize"]),
                                Decimali = Convert.ToInt32(Schema.Rows[n]["NumericScale"]),
                                Tipo = Schema.Rows[n]["DataType"] as Type
                            };

                            Colonnes.Add(_colonna);
                        }

                        Ta.Load(Dr);
                    }
                }
            }
        }
    }
}
