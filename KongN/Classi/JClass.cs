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
    internal class JClass
    {
        private string uri;
        // private JObject j;

        public JClass(string uri)
        {
            this.uri = uri;

        }

        public JArray ReturnRequest(JObject j)
        {
            if (j.SelectToken("server").ToString() == "200")
            {

                return (JArray)j.SelectToken("response");


            }
            else
            {
                MessageBox.Show("Errore nel Server :" + j.SelectToken("response"));
                return null;
            }


        }

        public String ReturnRequest(JObject j, String S)
        {
            if (j.SelectToken("server").ToString() == "200")
            {
                return (String)j.SelectToken("response");


            }
            else
            {
                MessageBox.Show("Errore nel Server :" + j.SelectToken("response"));
                return null;
            }


        }


        public async Task<JObject> SendRequest()

        {
            try
            {

                Uri uri = new Uri(this.uri);



                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(uri))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string result = await content.ReadAsStringAsync();


                            JObject jsonObject = JObject.Parse(result);


                            //string json = result.ToString();



                            //jsonarray = (JArray)jsonObject.SelectToken("response");
                            return jsonObject;
                        }

                    }
                }


            }
            catch (HttpRequestException e)
            {

                JObject o = new JObject();
                o.Add("server", "500");
                o.Add("response", e.Message.ToString());
                return o;


            }



        }
    }
}
