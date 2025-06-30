using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.Classi
{
    [Serializable]
    public class AppConfiguration
    {
        public string ConnKongN { get; set; }
        public string ConnANA { get; set; }
        public string ConnComune { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Server { get; set; } = string.Empty;
        public string Database { get; set; } = string.Empty;
        public int Esercizio { get; set; } = 0;

        // definisce i parametri di configurazione dell'applicazione per l'aggiornamento
        public string FileUltimaVersione { get; set; } = string.Empty;
        public string FileSetup { get; set; } = string.Empty;
        public string NomeSetup { get; set; } = string.Empty;

        // chiave per l'accesso a Google Maps
        public static string Key { get; } = @"AIzaSyDQzV822fvoiuxBSgqrperhOPQf_VdkNXc";

        public AppConfiguration()
        { }


        public bool CaricaConfigurazione(string filename)
        {
            bool esito = false;
            //try
            //{
            //     Newtonsoft.Json.JsonConvert.DeserializeObject<AppConfiguration>(System.IO.File.ReadAllText("AppConfiguration.json"));
            //    //Newtonsoft.Json.JsonConvert.DeserializeObject<Corso.Models.AppConfiguration>(System.IO.File.ReadAllText("AppConfiguration.json"));
            //    esito = true;
            //}
            //catch (Exception)
            //{

            //    esito = false;
            //}

            //return esito;

            if (string.IsNullOrWhiteSpace(filename)) { return false; }
            try
            {
                AppConfiguration appConfiguration = JsonConvert.DeserializeObject<AppConfiguration>(System.IO.File.ReadAllText(filename));
                Global.connKongN = appConfiguration.ConnKongN;
                Global.connAna = appConfiguration.ConnANA;
                Global.connComune = appConfiguration.ConnComune;
                this.UserName = appConfiguration.UserName;
                this.Password = appConfiguration.Password;
                this.Server = appConfiguration.Server;
                this.Database = appConfiguration.Database;
                this.Esercizio = appConfiguration.Esercizio;


                // file di configurazione per l'aggiornamento

                Global.FileUltimaVersione = appConfiguration.FileUltimaVersione;
                Global.FileSetup = appConfiguration.FileSetup;
                Global.NomeSetup = appConfiguration.NomeSetup;
                esito = true;
            }
            catch (Exception)
            {

                esito = false;
            }

            return esito;



        }
    }
}

