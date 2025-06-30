using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("VoIPofferte")]
    internal class VoIPofferte
    {
        [ExplicitKey]
        public int idofferta { get; set; }
        public string Descrizione { get; set; }
        public int Minfisso { get; set; }
        public int Minmobile { get; set; }
        public bool Scatto { get; set; }
        public bool AllInclusive { get; set; }
        public double? CostoMensile { get; set; }
        public double? CostoScatto { get; set; }
        public string Note { get; set; }
    }
}
