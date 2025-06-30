using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("Apparati")]
    public class Apparati
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Descrizione { get; set; }
        public string Note { get; set; }
        public string Apparato { get; set; }
        public string LuogoApparato { get; set; }
        public string IndirizzoIP { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Tipo { get; set; }
        public int iDUtente { get; set; }
        public DateTime? DataInstallazione { get; set; }
        public DateTime? DataModifica { get; set; }
    }
}
