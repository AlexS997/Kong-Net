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
    public class AgentiProvvigioni
    {

        #region Properties
        public string Anno { get; set; }
        public string NumDoc { get; set; }
        public DateTime? DataDoc { get; set; }
        public string Cliente { get; set; }
        public string Denom { get; set; }
        public string Agente { get; set; }
        public string Descrizione { get; set; }
        public float? PercProv { get; set; }
        public double? TotMerce { get; set; }
        public double? TotDocum { get; set; }
        public string CodDoc { get; set; }
        public short? Nriga { get; set; }
        public double? Importo { get; set; }
        public short? NumRiga { get; set; }
        public string Partita { get; set; }
        public DateTime? DataScad { get; set; }
        public double? ImportoScadenza { get; set; }
        public double? Incassato { get; set; }
        public string CodArt { get; set; }
        public double? Qta { get; set; }
        public double? ImpUni { get; set; }
        public double? ValoreMov { get; set; }
        public double? Provvigioni { get; set; }
        public int ID { get; set; }
        #endregion

        //SQLControl SQL = new SQLControl(Global.connKongN);

        #region Add
        /// <summary>
        /// Adds a new record.
        /// </summary>
        public void Add()
        {

            using (SqlConnection con = new SqlConnection(Global.connKongN))
            {
                String sql = @"INSERT INTO [AgentiProvvigioni]
                    (
            	        [Anno],
            	        [NumDoc],
            	        [DataDoc],
            	        [Cliente],
            	        [Denom],
            	        [Agente],
            	        [Descrizione],
            	        [PercProv],
            	        [TotMerce],
            	        [TotDocum],
            	        [CodDoc],
            	        [Nriga],
            	        [Importo],
            	        [NumRiga],
            	        [Partita],
            	        [DataScad],
            	        [ImportoScadenza],
            	        [Incassato],
            	        [CodArt],
            	        [Qta],
            	        [ImpUni],
            	        [ValoreMov],
            	        [Provvigioni]
                    )
                    VALUES
                    (
            	        @Anno,
            	        @NumDoc,
            	        @DataDoc,
            	        @Cliente,
            	        @Denom,
            	        @Agente,
            	        @Descrizione,
            	        @PercProv,
            	        @TotMerce,
            	        @TotDocum,
            	        @CodDoc,
            	        @Nriga,
            	        @Importo,
            	        @NumRiga,
            	        @Partita,
            	        @DataScad,
            	        @ImportoScadenza,
            	        @Incassato,
            	        @CodArt,
            	        @Qta,
            	        @ImpUni,
            	        @ValoreMov,
            	        @Provvigioni
                    );";

                sql += "SELECT SCOPE_IDENTITY();";

                //SQL.AddParam("@Anno", Anno ?? (object)DBNull.Value);
                //SQL.AddParam("@NumDoc", NumDoc ?? (object)DBNull.Value);
                //SQL.AddParam("@DataDoc", DataDoc ?? (object)DBNull.Value);
                //SQL.AddParam("@Cliente", Cliente ?? (object)DBNull.Value);
                //SQL.AddParam("@Denom", Denom ?? (object)DBNull.Value);
                //SQL.AddParam("@Agente", Agente ?? (object)DBNull.Value);
                //SQL.AddParam("@Descrizione", Descrizione ?? (object)DBNull.Value);
                //SQL.AddParam("@PercProv", PercProv ?? (object)DBNull.Value);
                //SQL.AddParam("@TotMerce", TotMerce ?? (object)DBNull.Value);
                //SQL.AddParam("@TotDocum", TotDocum ?? (object)DBNull.Value);
                //SQL.AddParam("@CodDoc", CodDoc ?? (object)DBNull.Value);
                //SQL.AddParam("@Nriga", Nriga ?? (object)DBNull.Value);
                //SQL.AddParam("@Importo", Importo ?? (object)DBNull.Value);
                //SQL.AddParam("@NumRiga", NumRiga ?? (object)DBNull.Value);
                //SQL.AddParam("@Partita", Partita ?? (object)DBNull.Value);
                //SQL.AddParam("@DataScad", DataScad ?? (object)DBNull.Value);
                //SQL.AddParam("@ImportoScadenza", ImportoScadenza ?? (object)DBNull.Value);
                //SQL.AddParam("@Incassato", Incassato ?? (object)DBNull.Value);
                //SQL.AddParam("@CodArt", CodArt ?? (object)DBNull.Value);
                //SQL.AddParam("@Qta", Qta ?? (object)DBNull.Value);
                //SQL.AddParam("@ImpUni", ImpUni ?? (object)DBNull.Value);
                //SQL.AddParam("@ValoreMov", ValoreMov ?? (object)DBNull.Value);
                //SQL.AddParam("@Provvigioni", Provvigioni ?? (object)DBNull.Value);

                //SQL.ExecQuery(sql);


                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Anno", SqlDbType.VarChar, 4).Value = Anno == null ? (Object)DBNull.Value : Anno;
                    cmd.Parameters.Add("@NumDoc", SqlDbType.VarChar, 8).Value = NumDoc == null ? (Object)DBNull.Value : NumDoc;
                    cmd.Parameters.Add("@DataDoc", SqlDbType.DateTime, 8).Value = DataDoc == null ? (Object)DBNull.Value : DataDoc;
                    cmd.Parameters.Add("@Cliente", SqlDbType.VarChar, 10).Value = Cliente == null ? (Object)DBNull.Value : Cliente;
                    cmd.Parameters.Add("@Denom", SqlDbType.VarChar, 60).Value = Denom == null ? (Object)DBNull.Value : Denom;
                    cmd.Parameters.Add("@Agente", SqlDbType.VarChar, 4).Value = Agente == null ? (Object)DBNull.Value : Agente;
                    cmd.Parameters.Add("@Descrizione", SqlDbType.VarChar, 40).Value = Descrizione == null ? (Object)DBNull.Value : Descrizione;
                    cmd.Parameters.Add("@PercProv", SqlDbType.Float, 8).Value = PercProv == null ? (Object)DBNull.Value : PercProv;
                    cmd.Parameters.Add("@TotMerce", SqlDbType.Float, 8).Value = TotMerce == null ? (Object)DBNull.Value : TotMerce;
                    cmd.Parameters.Add("@TotDocum", SqlDbType.Float, 8).Value = TotDocum == null ? (Object)DBNull.Value : TotDocum;
                    cmd.Parameters.Add("@CodDoc", SqlDbType.VarChar, 6).Value = CodDoc == null ? (Object)DBNull.Value : CodDoc;
                    cmd.Parameters.Add("@Nriga", SqlDbType.SmallInt, 2).Value = Nriga == null ? (Object)DBNull.Value : Nriga;
                    cmd.Parameters.Add("@Importo", SqlDbType.Float, 8).Value = Importo == null ? (Object)DBNull.Value : Importo;
                    cmd.Parameters.Add("@NumRiga", SqlDbType.SmallInt, 2).Value = NumRiga == null ? (Object)DBNull.Value : NumRiga;
                    cmd.Parameters.Add("@Partita", SqlDbType.VarChar, 10).Value = Partita == null ? (Object)DBNull.Value : Partita;
                    cmd.Parameters.Add("@DataScad", SqlDbType.DateTime, 8).Value = DataScad == null ? (Object)DBNull.Value : DataScad;
                    cmd.Parameters.Add("@ImportoScadenza", SqlDbType.Float, 8).Value = ImportoScadenza == null ? (Object)DBNull.Value : ImportoScadenza;
                    cmd.Parameters.Add("@Incassato", SqlDbType.Float, 8).Value = Incassato == null ? (Object)DBNull.Value : Incassato;
                    cmd.Parameters.Add("@CodArt", SqlDbType.VarChar, 20).Value = CodArt == null ? (Object)DBNull.Value : CodArt;
                    cmd.Parameters.Add("@Qta", SqlDbType.Float, 8).Value = Qta == null ? (Object)DBNull.Value : Qta;
                    cmd.Parameters.Add("@ImpUni", SqlDbType.Float, 8).Value = ImpUni == null ? (Object)DBNull.Value : ImpUni;
                    cmd.Parameters.Add("@ValoreMov", SqlDbType.Float, 8).Value = ValoreMov == null ? (Object)DBNull.Value : ValoreMov;
                    cmd.Parameters.Add("@Provvigioni", SqlDbType.Float, 8).Value = Provvigioni == null ? (Object)DBNull.Value : Provvigioni;

                    // Execute the insert statement and get value of the identity column.
                    ID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                con.Close();
            }

        }
        #endregion

        #region Update
        /// <summary>
        /// Updates an existing record.
        /// </summary>
        public void Update()
        {

            using (SqlConnection con = new SqlConnection(Global.connKongN))
            {
                String sql = @"UPDATE	[AgentiProvvigioni]
								SET		[Anno] = @Anno,
										[NumDoc] = @NumDoc,
										[DataDoc] = @DataDoc,
										[Cliente] = @Cliente,
										[Denom] = @Denom,
										[Agente] = @Agente,
										[Descrizione] = @Descrizione,
										[PercProv] = @PercProv,
										[TotMerce] = @TotMerce,
										[TotDocum] = @TotDocum,
										[CodDoc] = @CodDoc,
										[Nriga] = @Nriga,
										[Importo] = @Importo,
										[NumRiga] = @NumRiga,
										[Partita] = @Partita,
										[DataScad] = @DataScad,
										[ImportoScadenza] = @ImportoScadenza,
										[Incassato] = @Incassato,
										[CodArt] = @CodArt,
										[Qta] = @Qta,
										[ImpUni] = @ImpUni,
										[ValoreMov] = @ValoreMov,
										[Provvigioni] = @Provvigioni
								WHERE	[iD] = @iD;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Anno", SqlDbType.VarChar, 4).Value = Anno == null ? (Object)DBNull.Value : Anno;
                    cmd.Parameters.Add("@NumDoc", SqlDbType.VarChar, 8).Value = NumDoc == null ? (Object)DBNull.Value : NumDoc;
                    cmd.Parameters.Add("@DataDoc", SqlDbType.DateTime, 8).Value = DataDoc == null ? (Object)DBNull.Value : DataDoc;
                    cmd.Parameters.Add("@Cliente", SqlDbType.VarChar, 10).Value = Cliente == null ? (Object)DBNull.Value : Cliente;
                    cmd.Parameters.Add("@Denom", SqlDbType.VarChar, 60).Value = Denom == null ? (Object)DBNull.Value : Denom;
                    cmd.Parameters.Add("@Agente", SqlDbType.VarChar, 4).Value = Agente == null ? (Object)DBNull.Value : Agente;
                    cmd.Parameters.Add("@Descrizione", SqlDbType.VarChar, 40).Value = Descrizione == null ? (Object)DBNull.Value : Descrizione;
                    cmd.Parameters.Add("@PercProv", SqlDbType.Float, 8).Value = PercProv == null ? (Object)DBNull.Value : PercProv;
                    cmd.Parameters.Add("@TotMerce", SqlDbType.Float, 8).Value = TotMerce == null ? (Object)DBNull.Value : TotMerce;
                    cmd.Parameters.Add("@TotDocum", SqlDbType.Float, 8).Value = TotDocum == null ? (Object)DBNull.Value : TotDocum;
                    cmd.Parameters.Add("@CodDoc", SqlDbType.VarChar, 6).Value = CodDoc == null ? (Object)DBNull.Value : CodDoc;
                    cmd.Parameters.Add("@Nriga", SqlDbType.SmallInt, 2).Value = Nriga == null ? (Object)DBNull.Value : Nriga;
                    cmd.Parameters.Add("@Importo", SqlDbType.Float, 8).Value = Importo == null ? (Object)DBNull.Value : Importo;
                    cmd.Parameters.Add("@NumRiga", SqlDbType.SmallInt, 2).Value = NumRiga == null ? (Object)DBNull.Value : NumRiga;
                    cmd.Parameters.Add("@Partita", SqlDbType.VarChar, 10).Value = Partita == null ? (Object)DBNull.Value : Partita;
                    cmd.Parameters.Add("@DataScad", SqlDbType.DateTime, 8).Value = DataScad == null ? (Object)DBNull.Value : DataScad;
                    cmd.Parameters.Add("@ImportoScadenza", SqlDbType.Float, 8).Value = ImportoScadenza == null ? (Object)DBNull.Value : ImportoScadenza;
                    cmd.Parameters.Add("@Incassato", SqlDbType.Float, 8).Value = Incassato == null ? (Object)DBNull.Value : Incassato;
                    cmd.Parameters.Add("@CodArt", SqlDbType.VarChar, 20).Value = CodArt == null ? (Object)DBNull.Value : CodArt;
                    cmd.Parameters.Add("@Qta", SqlDbType.Float, 8).Value = Qta == null ? (Object)DBNull.Value : Qta;
                    cmd.Parameters.Add("@ImpUni", SqlDbType.Float, 8).Value = ImpUni == null ? (Object)DBNull.Value : ImpUni;
                    cmd.Parameters.Add("@ValoreMov", SqlDbType.Float, 8).Value = ValoreMov == null ? (Object)DBNull.Value : ValoreMov;
                    cmd.Parameters.Add("@Provvigioni", SqlDbType.Float, 8).Value = Provvigioni == null ? (Object)DBNull.Value : Provvigioni;
                    cmd.Parameters.Add("@iD", SqlDbType.Int, 4).Value = ID;
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deletes an existing record.
        /// </summary>
        public static void Delete(int iD)
        {

            using (SqlConnection con = new SqlConnection(Global.connKongN))
            {
                String sql = @"DELETE FROM [AgentiProvvigioni] WHERE [iD] = @iD;";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@iD", SqlDbType.Int, 4).Value = iD;
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
        }
        #endregion

        #region Get
        /// <summary>
        /// Gets an existing record.
        /// </summary>
        public static AgentiProvvigioni Get(int iD)
        {

            using (SqlConnection con = new SqlConnection(Global.connKongN))
            {
                String sql = @"SELECT	[Anno],
										[NumDoc],
										[DataDoc],
										[Cliente],
										[Denom],
										[Agente],
										[Descrizione],
										[PercProv],
										[TotMerce],
										[TotDocum],
										[CodDoc],
										[Nriga],
										[Importo],
										[NumRiga],
										[Partita],
										[DataScad],
										[ImportoScadenza],
										[Incassato],
										[CodArt],
										[Qta],
										[ImpUni],
										[ValoreMov],
										[Provvigioni],
										[iD]
								FROM	[AgentiProvvigioni]
								WHERE	[iD] = @iD";

                AgentiProvvigioni agentiProvvigioni = new AgentiProvvigioni();

                con.Open();

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@iD", SqlDbType.Int, 4).Value = iD;

                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.Read())
                        {
                            agentiProvvigioni.Anno = reader["Anno"] == DBNull.Value ? null : reader["Anno"].ToString();
                            agentiProvvigioni.NumDoc = reader["NumDoc"] == DBNull.Value ? null : reader["NumDoc"].ToString();
                            agentiProvvigioni.DataDoc = reader["DataDoc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["DataDoc"]);
                            agentiProvvigioni.Cliente = reader["Cliente"] == DBNull.Value ? null : reader["Cliente"].ToString();
                            agentiProvvigioni.Denom = reader["Denom"] == DBNull.Value ? null : reader["Denom"].ToString();
                            agentiProvvigioni.Agente = reader["Agente"] == DBNull.Value ? null : reader["Agente"].ToString();
                            agentiProvvigioni.Descrizione = reader["Descrizione"] == DBNull.Value ? null : reader["Descrizione"].ToString();
                            agentiProvvigioni.PercProv = reader["PercProv"] == DBNull.Value ? (float?)null : Convert.ToSingle(reader["PercProv"]);
                            agentiProvvigioni.TotMerce = reader["TotMerce"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["TotMerce"]);
                            agentiProvvigioni.TotDocum = reader["TotDocum"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["TotDocum"]);
                            agentiProvvigioni.CodDoc = reader["CodDoc"] == DBNull.Value ? null : reader["CodDoc"].ToString();
                            agentiProvvigioni.Nriga = reader["Nriga"] == DBNull.Value ? (short?)null : Convert.ToInt16(reader["Nriga"]);
                            agentiProvvigioni.Importo = reader["Importo"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["Importo"]);
                            agentiProvvigioni.NumRiga = reader["NumRiga"] == DBNull.Value ? (short?)null : Convert.ToInt16(reader["NumRiga"]);
                            agentiProvvigioni.Partita = reader["Partita"] == DBNull.Value ? null : reader["Partita"].ToString();
                            agentiProvvigioni.DataScad = reader["DataScad"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["DataScad"]);
                            agentiProvvigioni.ImportoScadenza = reader["ImportoScadenza"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["ImportoScadenza"]);
                            agentiProvvigioni.Incassato = reader["Incassato"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["Incassato"]);
                            agentiProvvigioni.CodArt = reader["CodArt"] == DBNull.Value ? null : reader["CodArt"].ToString();
                            agentiProvvigioni.Qta = reader["Qta"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["Qta"]);
                            agentiProvvigioni.ImpUni = reader["ImpUni"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["ImpUni"]);
                            agentiProvvigioni.ValoreMov = reader["ValoreMov"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["ValoreMov"]);
                            agentiProvvigioni.Provvigioni = reader["Provvigioni"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["Provvigioni"]);
                            agentiProvvigioni.ID = Convert.ToInt32(reader["iD"]);
                        }
                    }
                }

                return agentiProvvigioni;
            }
        }
        #endregion

        #region GetAll
        /// <summary>
        /// Gets all records.
        /// </summary>
        public static DataTable GetAll()
        {

            using (SqlConnection con = new SqlConnection(Global.connKongN))
            {
                DataTable dataTable = new DataTable();

                con.Open();

                String sql = @"SELECT	[Anno],
										[NumDoc],
										[DataDoc],
										[Cliente],
										[Denom],
										[Agente],
										[Descrizione],
										[PercProv],
										[TotMerce],
										[TotDocum],
										[CodDoc],
										[Nriga],
										[Importo],
										[NumRiga],
										[Partita],
										[DataScad],
										[ImportoScadenza],
										[Incassato],
										[CodArt],
										[Qta],
										[ImpUni],
										[ValoreMov],
										[Provvigioni],
										[iD]
								FROM	[AgentiProvvigioni];";

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
