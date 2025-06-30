using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using MikrotikDotNet;
namespace KongN.Classi
{
   
   

   
    
public class Cmk
    {
        SQLControl Mik = new SQLControl(Global.connKongN);

        // chiama un metodo per aprire la tabella automatismi e leggere i parametri per la connessione al mikrotik
        internal DataTable mkGetParametri()
        {
            string sql = "Select * from Automatismi ";
            Mik.ExecQuery(sql);
            if (Mik.HasException(true) || Mik.DBDT.Rows.Count == 0)
            {
                return new DataTable();
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("IP", typeof(string));
            dt.Columns.Add("USERNAME", typeof(string));
            dt.Columns.Add("PASSWORD", typeof(string));

            DataRow row = dt.NewRow();
            row["IP"] = Mik.DBDT.Rows[0]["MikrotikIP"].ToString();
            row["USERNAME"] = Mik.DBDT.Rows[0]["MikrotikUser"].ToString();
            row["PASSWORD"] = Mik.DBDT.Rows[0]["MikrotikPass"].ToString();
            dt.Rows.Add(row);

            return dt;
        }

        public static DataTable mkGetAll()
        {
            Cmk instance = new Cmk();
            DataTable paramTable = instance.mkGetParametri();
            if (paramTable.Rows.Count == 0)
            {
                // La tabella è vuota, non fare nulla
                return new DataTable();
            }

            string IP = paramTable.Rows[0]["IP"].ToString();
            string USERNAME = paramTable.Rows[0]["USERNAME"].ToString();
            string PASSWORD = paramTable.Rows[0]["PASSWORD"].ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("ActualProfile", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Location", typeof(string));
            dt.Columns.Add("Comment", typeof(string));

            try
            {
                using (var conn = new MKConnection(IP, USERNAME, PASSWORD))
                {
                    conn.Open();
                    var cmd = conn.CreateCommand("tool user-manager user print");

                    var result = cmd.ExecuteReader<EUser>();

                    foreach (var line in result)
                    {
                        dt.Rows.Add(line.ActualProfile, line.Username, line.Location, line.Comment);
                    }
                }

                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }


        public static bool mkSetUser(string username, string profile)
        {
            Cmk instance = new Cmk();
            DataTable paramTable = instance.mkGetParametri();
            if (paramTable.Rows.Count == 0)
            {
                // La tabella è vuota, non fare nulla
                return false;
            }

            string IP = paramTable.Rows[0]["IP"].ToString();
            string USERNAME = paramTable.Rows[0]["USERNAME"].ToString();
            string PASSWORD = paramTable.Rows[0]["PASSWORD"].ToString();
          

            try
            {
                using (var conn = new MKConnection(IP, USERNAME, PASSWORD))
                {
                    conn.Open();
                    var cmd = conn.CreateCommand("tool user-manager user clear-profiles");

                    cmd.Parameters.Add("Numbers", username);
                    cmd.ExecuteNonQuery();
                    cmd = conn.CreateCommand("tool user-manager user create-and-activate-profile");
                    cmd.Parameters.Add("Numbers", username);
                    cmd.Parameters.Add("Customer", "admin");
                    cmd.Parameters.Add("Profile", profile);
                    cmd.ExecuteNonQuery();
                   

                }
                mkReboot(username);
                return true;
            }
            catch (Exception)

            {
               
                return false;
            }
        }

        public static DataTable mkGetUser(string username)
        {

            Cmk instance = new Cmk();
            DataTable paramTable = instance.mkGetParametri();
            if (paramTable.Rows.Count == 0)
            {
                // La tabella è vuota, non fare nulla

                return new DataTable();
            }

            string IP = paramTable.Rows[0]["IP"].ToString();
            string USERNAME = paramTable.Rows[0]["USERNAME"].ToString();
            string PASSWORD = paramTable.Rows[0]["PASSWORD"].ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("ActualProfile", typeof(string));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Comment", typeof(string));

            try
            {
                using (var conn = new MKConnection(IP, USERNAME, PASSWORD))
                {
                    conn.Open();
                    var cmd = conn.CreateCommand("tool user-manager user print where username=" + username);

                    var result = cmd.ExecuteReader<EUser>();

                    foreach (var line in result)

                    {
                        // Console.WriteLine($"{ip.Id} - {ip.Address} - {ip.Interface}"); //MKID switched to Id
                        // Console.WriteLine($"{line.ActualProfile} - { line.Username} - {line.Comment}");
                        // Comment = "{line.Comment}";




                        dt.Rows.Add(line.ActualProfile, line.Username);




                    }

                }
                return dt;

            }
            catch (Exception)
            {
                
                return dt ;
            }





        }

        public static void mkReboot(string username)
        {
            Cmk instance = new Cmk();
            DataTable paramTable = instance.mkGetParametri();
            if (paramTable.Rows.Count == 0)
            {
                // La tabella è vuota, non fare nulla
                return ;
            }

            string IP = paramTable.Rows[0]["IP"].ToString();
            string USERNAME = paramTable.Rows[0]["USERNAME"].ToString();
            string PASSWORD = paramTable.Rows[0]["PASSWORD"].ToString();



            using (var conn = new MKConnection(IP, USERNAME, PASSWORD))
            {
                conn.Open();
                var cmd = conn.CreateCommand("tool user-manager session print where user=" + username);
                var result = cmd.ExecuteReader<sessionMikrotik>();
                if (result.Count() != 0)
                {
                    // fatto da me
                    var line = result.FirstOrDefault();



                    //foreach (var line in result)  originale Andrea

                    //string ipGateway = line.HostIp; originale Andrea
                    string ipGateway = line.HostIp;


                    var conGateway = new MKConnection(ipGateway, USERNAME, PASSWORD);
                    conGateway.Open();
                    cmd = conGateway.CreateCommand("ppp active print where name=" + username);
                    var resultp = cmd.ExecuteReader<pppMikrotik>();

                    //foreach (var line in result) originale Andrea
                    var linep = resultp.FirstOrDefault();
                    // string idPPP = line.MKID; originale Andrea
                    string idPPP = linep.MKID;

                    cmd = conGateway.CreateCommand("ppp active remove");
                    cmd.Parameters.Add("MKID", idPPP);
                    cmd.ExecuteNonQuery();
                   
                }


            }






        }

        class sessionMikrotik
        {

            public string HostIp { get; set; }

        }

        class pppMikrotik
        {

            public string MKID { get; set; }

        }
        class EUser
        {
            public string Username { get; set; }  //MKID always referce to .id field in response.
            public string ActualProfile { get; set; } // Use PascalCase naming style for properties. it will convert from/to kebab-case naming.
            public string Comment { get; set; }
            public string Location { get; set; }

        }
        // Altri metodi della classe Cmk...
    }
    }





