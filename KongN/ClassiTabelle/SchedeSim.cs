using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("SchedeSim")]
    internal class SchedeSim
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Puk { get; set; }
        public string Utente { get; set; }
        public string IMEI { get; set; }
        public string Telefono { get; set; }
        public string APN { get; set; }
        public string Fornitore { get; set; }
        public string TipoAbbonamento { get; set; }
        public string RiferimentoOperatore { get; set; }
        public bool? InMagazzino { get; set; }
        public bool? Dismessa { get; set; }
        public bool? Attiva { get; set; }
        public DateTime? DataAttivazione { get; set; }
    }
}
