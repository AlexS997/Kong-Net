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
    public class CVoIPprefissi
    {
        #region Properties
        public string Stato { get; set; }
        public int? Tipo { get; set; }
        public double? Costo { get; set; }
        public string Prefisso { get; set; }
        public double? Scatto { get; set; }
        public int? IDNazione { get; set; }
        public int ID { get; set; }
        #endregion

        #region Get
        /// <summary>
        /// Gets an existing record.
        /// </summary>
        public CVoIPprefissi Get(int iD)
        {

            using (SqlConnection con = new SqlConnection(Global.connKongN))
            {
                String sql = @"SELECT	[stato],
										[tipo],
										[costo],
										[prefisso],
										[scatto],
										[iDNazione],
										[iD]
								FROM	[VoIPprefissi]
								WHERE	[iD] = @iD;";

                CVoIPprefissi voIPprefissi = new CVoIPprefissi();

                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@iD", SqlDbType.Int, 4).Value = iD;

                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.Read())
                        {
                            voIPprefissi.Stato = reader["stato"] == DBNull.Value ? null : reader["stato"].ToString();
                            voIPprefissi.Tipo = reader["tipo"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["tipo"]);
                            voIPprefissi.Costo = reader["costo"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["costo"]);
                            voIPprefissi.Prefisso = reader["prefisso"] == DBNull.Value ? null : reader["prefisso"].ToString();
                            voIPprefissi.Scatto = reader["scatto"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["scatto"]);
                            voIPprefissi.IDNazione = reader["iDNazione"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["iDNazione"]);
                            voIPprefissi.ID = Convert.ToInt32(reader["iD"]);
                        }
                    }
                }

                return voIPprefissi;
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

                String sql = @"SELECT	[stato],
										[tipo],
										[costo],
										[prefisso],
										[scatto],
										[iDNazione],
										[iD]
								FROM	[VoIPprefissi];";

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
