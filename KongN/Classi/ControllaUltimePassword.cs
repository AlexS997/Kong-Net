using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.Classi
{
    internal class ControllaUltimePassword
    {
        SQLControl connKong = new SQLControl(Global.connKongN);

        public int _id { get; set; }
        public string _password { get; set; }

        public bool PasswordTrovata()
        {

            // recupera le ultime 10 password
            // se trova la password immessa nelle ultime 10 restiruisce true
            DataTable dt = new DataTable();
            bool result = false;

            string query = "SELECT iDUtente, Password, DataPassword, iD FROM UtentiPassword " +
                "WHERE (iDUtente = @iDUtente And Password = @Password) " +
                "order by datapassword desc";

            connKong.AddParam("@idUtente", _id);
            connKong.AddParam("password", EncryptDecrypt.Encrypt(_password));
            connKong.ExecQuery(query);

            if (connKong.HasException(true))
            {
                return result;
            }

            dt = connKong.DBDT;
            if (dt.Rows.Count == 0)
            {
                // l'utente non ha mai cambiato la password 

                return result;
            }

            int righe = dt.Rows.Count;
            if (righe > 10)
            {
                righe = 10;
            }

            // decrypta le password
            for (int i = 0; i < righe; i++)
            {
                dt.Rows[i]["Password"] = EncryptDecrypt.Decrypt(dt.Rows[i]["Password"].ToString());
            }


            for (int i = 0; i < righe; i++)
            {
                if ((dt.Rows[i]["Password"].ToString()) == _password)
                {
                    result = true;
                    return result;
                }
            }

            return result;
        }
    }
}
