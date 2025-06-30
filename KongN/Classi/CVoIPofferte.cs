using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.Classi
{
    public class CVoIPofferte
    {

        #region Properties
        public int Idofferta { get; set; }
        public string Descrizione { get; set; }
        public int? Minfisso { get; set; }
        public int? Minmobile { get; set; }
        public bool? Scatto { get; set; }
        public double? CostoMensile { get; set; }
        public double? CostoScatto { get; set; }
        public string Note { get; set; }
        #endregion

        //SQLControl connKong = new SQLControl(Global.connKongN);

        #region Get
        /// <summary>
        /// Gets an existing record.
        /// </summary>
        public CVoIPofferte Get(int idofferta)
        {

            using (SqlConnection con = new SqlConnection(Global.connKongN))
            {
                String sql = @"SELECT	[idofferta],
										[Descrizione],
										[Minfisso],
										[Minmobile],
										[Scatto],
										[CostoMensile],
										[CostoScatto],
										[Note]
								FROM	[VoIPofferte]
								WHERE	[idofferta] = @idofferta;";

                CVoIPofferte voIPofferte = new CVoIPofferte();

                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@idofferta", SqlDbType.Int, 4).Value = idofferta;

                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.Read())
                        {
                            voIPofferte.Idofferta = Convert.ToInt32(reader["idofferta"]);
                            voIPofferte.Descrizione = reader["Descrizione"] == DBNull.Value ? null : reader["Descrizione"].ToString();
                            voIPofferte.Minfisso = reader["Minfisso"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Minfisso"]);
                            voIPofferte.Minmobile = reader["Minmobile"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Minmobile"]);
                            voIPofferte.Scatto = reader["Scatto"] == DBNull.Value ? (bool?)null : Convert.ToBoolean(reader["Scatto"]);
                            voIPofferte.CostoMensile = reader["CostoMensile"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["CostoMensile"]);
                            voIPofferte.CostoScatto = reader["CostoScatto"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["CostoScatto"]);
                            voIPofferte.Note = reader["Note"] == DBNull.Value ? null : reader["Note"].ToString();
                        }
                    }
                }

                return voIPofferte;
            }
        }
        #endregion

        #region GetAll
        /// <summary>
        /// Gets all records.
        /// </summary>
        public DataTable GetAll()
        {

            using (SqlConnection con = new SqlConnection(Global.connKongN))
            {
                DataTable dataTable = new DataTable();

                con.Open();

                String sql = @"SELECT	[idofferta],
										[Descrizione],
										[Minfisso],
										[Minmobile],
										[Scatto],
										[CostoMensile],
										[CostoScatto],
										[Note]
								FROM	[VoIPofferte];";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        dataTable.Load(reader);
                    }
                }

                return dataTable;
            }
        }
        #endregion
    }
}
