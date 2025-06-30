using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("Sms")]
    internal class Sms
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Numero { get; set; }
        public string Messaggio { get; set; }
        public bool Elaborato { get; set; }
        public string Id_Sms { get; set; }
        public string Stato { get; set; }
        public string StatusDetail { get; set; }
        public DateTime? Data { get; set; }
        public string TipoMessaggio { get; set; }
        public string Codice { get; set; }
        public string Denom { get; set; }
        public int iDUtente { get; set; }
        public DateTime? DataModifica { get; set; }

    }
}
