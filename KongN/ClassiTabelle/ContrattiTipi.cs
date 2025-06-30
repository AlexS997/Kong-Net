using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("ContrattiTipi")]
    public class ContrattiTipi
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public bool? Connessione { get; set; }
        public bool? FlagConsumi { get; set; }
        public int iDUtente { get; set; }
        public DateTime? DataModifica { get; set; }
    }
}
