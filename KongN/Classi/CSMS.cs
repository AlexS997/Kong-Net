using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KongN.Classi
{
    internal class CSMS
    {

        public CSMS() { }
        #region Public
        public float _credito { get; set; }
        public string _messaggio { get; set; }
        public string _numero { get; set; }

        public string _Status { get; set; }
        public string _Id { get; set; }
        public string _user { get; set; }
        public string _pass { get; set; }
        public float? _costo { get; set; }
        public string _iDMessaggio { get; set; }

        public string _creditoAPI { get; set; }

        public string _sendAPI { get; set; }

        public string _estimateAPI { get; set; }

        public string _searchAPI { get; set; }


        private static readonly HttpClient client = new HttpClient();

        SQLControl sql = new SQLControl(Global.connKongN);
        #endregion




        public async Task<Dictionary<string, string>> InviaSMS()
        {
            GetCredenziali();

            var ReturnValue = new Dictionary<string, string>
                {
                    { "status", "0" },
                    { "id", "0" },
                    { "statusDetail", "0" }
                };

            var values = new Dictionary<string, string>
                {
                    { "from", "EtruriaWiFi" },
                    { "to", _numero  },
                    { "text", _messaggio }
                 };


            try
            {
                //string url = "https://api.smstools.it/rest/api/sms/send";
                string url = _sendAPI;


                string p = await PostHTTPRequestAsync(url, values);
                JObject j = JObject.Parse(p);

                JArray status = (JArray)j.SelectToken("sms");
                string _Status = (string)status[0]["status"];
                string _iD = (string)status[0]["id"];
                string _StatusDetail = (string)status[0]["statusDetail"];
                //ReturnValue["status"]=_Status;
                // se il valore ritornato come id è null vuol dire che il messaggio non è stato inserito
                // si verifica per esempio nel caso di messaggio duplicato
                if (_iD == null)
                {
                    _iD = "0";
                    _StatusDetail = "Errore in invio SMS";
                    _Status = "KO";

                }
                else
                {

                    ReturnValue["id"] = _iD;
                    ReturnValue["status"] = _Status;
                    ReturnValue["statusDetail"] = _StatusDetail;

                }



                return ReturnValue;
            }
            catch (Exception)
            {
                return ReturnValue;
            }
        }



        public async Task<Dictionary<string, string>> ControllaCredito()
        {

            //----------------------------------------------------------------------------------
            // Questa parte si occupa di vedere se il credito è sufficiente prima di inviare il messaggio   
            // dovra essere spostata in un altro metodo
            // se il costruttore riceve un parametro booleano uguale a false allora vuol dire
            // che è stato chiamato dalla form Prima e deve  usare l'altro metodo che controlla solo il credito residuo e basta
            //------------------------------- ;

            GetCredenziali();


            var ValoreRitorno = new Dictionary<string, string>
                {
                    { "credito", "0" },
                    { "costo", "0" }
                };



            try
            {

                var values = new Dictionary<string, string>
                    {
                        { "from", "EtruriaWiFi" },
                        { "to", _numero  },
                        { "text", _messaggio }
                    };

                //string urlCredito = "https://api.smstools.it/rest/api/sms/estimate";

                string urlCredito = _estimateAPI;


                var pCredito = await PostHTTPRequestAsync(urlCredito, values);






                JObject jCredito = JObject.Parse(pCredito);

                float _credito = (float)jCredito.SelectToken("userCredit");
                float _costo = (float)jCredito.SelectToken("cost");


                ValoreRitorno["credito"] = _credito.ToString();
                ValoreRitorno["costo"] = _costo.ToString();



                // ritorna i valori del dizionario se è riuscito a leggere il credito   
                return ValoreRitorno;
            }
            catch (Exception)
            {
                //ritorna un dizionario a zero se si è verificato un errore
                return ValoreRitorno;
            }

        }



        public async Task<string> ControllaCredito(bool Prima = true)
        {

            //----------------------------------------------------------------------------------
            // metodo con overload che restituisce solo il creditore residuo
            //------------------------------- ;

            //_numero = "393939958006";
            //_messaggio = "prova";


            var ValoreRitorno = new Dictionary<string, string>
                {
                    { "credito", "0" },

                };

            GetCredenziali();


            try
            {

                //    var values = new Dictionary<string, string>

                //{
                //    { "from", "EtruriaWiFi" },
                //    { "to", _numero  },
                //    { "text", _messaggio }
                //};
                // string urlCredito = "https://api.smstools.it/rest/api/user";

                string urlCredito = _creditoAPI;

                // var request = new HttpRequestMessage(HttpMethod.Get, "https://api.smstools.it/rest/api/user");


                var pCredito = await GetHTTPRequestAsync(urlCredito);




                JObject jCredito = JObject.Parse(pCredito);

                float _credito = (float)jCredito.SelectToken("credit");




                // ritorna i valori del dizionario se è riuscito a leggere il credito   
                return _credito.ToString();
            }
            catch (Exception)
            {
                //ritorna un dizionario a zero se si è verificato un errore
                return "0";
            }


        }


        private async Task<string> PostHTTPRequestAsync(string url, Dictionary<string, string> data)
        {
            GetCredenziali();


            //var _user = ConfigurationManager.AppSettings["SMSUser"];
            //var _pass = ConfigurationManager.AppSettings["SMSPass"];


            try
            {

                using (HttpContent formContent = new FormUrlEncodedContent(data))
                {
                    //var authString = Convert.ToBase64String(Encoding.UTF8.GetBytes("SMSH02SUKBJKCZBKZWMDZ:PNH2Q4DY1ZL9W7OPT35JB6GJSLB6EUH5"));

                    var authString = Convert.ToBase64String(Encoding.UTF8.GetBytes(_user + ":" + _pass));
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authString);
                    using (HttpResponseMessage response = await client.PostAsync(url, formContent).ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();
                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    }

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        private async Task<string> GetHTTPRequestAsync(string url)
        {
            GetCredenziali();
            //var _user = System.Configuration.ConfigurationManager.AppSettings["SMSUser"];
            //var _pass = System.Configuration.ConfigurationManager.AppSettings["SMSPass"];
            try
            {

                // var authString = Convert.ToBase64String(Encoding.UTF8.GetBytes("SMSH02SUKBJKCZBKZWMDZ:PNH2Q4DY1ZL9W7OPT35JB6GJSLB6EUH5"));
                var authString = Convert.ToBase64String(Encoding.UTF8.GetBytes(_user + ":" + _pass));
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authString);
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    //response.EnsureSuccessStatusCode();
                    return await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public async Task<string> ControllaStatoSMS()
        {

            GetCredenziali();
            string id = _iDMessaggio;

            //string url = "https://api.smstools.it/rest/api/sms/search?id=" + id + "&transactionId=null&msisdn=null&fromDate=null&toDate=null&status=null&offset=0&limit=20";
            //string url = "https://api.smstools.it/rest/api/sms/search?id=" + id;
            string url = _searchAPI + id;

            string p = await GetHTTPRequestAsync(url);
            JObject j = JObject.Parse(p);
            JArray status = (JArray)j.SelectToken("smsList");
            string s = (string)status[0]["status"];
            return s;


            //private async void  btnControlla_Click(object sender, EventArgs e)
            //{
            //    // cerca tramite l'id dell messaggio il suo stato
            //    string id = "2826358951";

            //    // string url = "https://api.smstools.it/rest/api/sms/search?id=" + id + "&transactionId=null&msisdn=null&fromDate=null&toDate=null&status=null&offset=0&limit=20";
            //     string url = "https://api.smstools.it/rest/api/sms/search?id=" + id ;

            //    string p = await GetHTTPRequestAsync(url);
            //    JObject j = JObject.Parse(p);
            //    JArray status = (JArray)j.SelectToken("smsList");
            //    string s = (string)status[0]["status"];
            //    MessageBox.Show(s, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}



        }

        // crea un metodo interno che richiama le credenziali da tabella automatismi

        private void GetCredenziali()
        {
            string query = "Select * from Automatismi";
            sql.ExecQuery(query);

            if (sql.HasException(true))
            {
                MessageBox.Show(sql.Exception, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _user = sql.DBDT.Rows[0]["UserSMSAPI"].ToString();
            _pass = sql.DBDT.Rows[0]["PwdSMSAPI"].ToString();
            _creditoAPI = sql.DBDT.Rows[0]["SMSCreditoUser"].ToString();
            _sendAPI = sql.DBDT.Rows[0]["SMSSend"].ToString();
            _estimateAPI = sql.DBDT.Rows[0]["SMSEstimate"].ToString();
            _searchAPI = sql.DBDT.Rows[0]["SMSUrl"].ToString();
            return;
        }

    }
}
