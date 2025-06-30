using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("VoIPNumerovoip")]
    internal class VoIPNumerovoip
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string iDContratto { get; set; }
        public string CodCli { get; set; }
        public string Denom { get; set; }
        public string Password { get; set; }
        public string Numerovoip { get; set; }
        public string Numeroportato { get; set; }
        public string Migrazione { get; set; }
        public string Migrazioneoperatore { get; set; }
        public DateTime? Datainizio { get; set; }
        public DateTime? Dataport { get; set; }
        public DateTime? Datafine { get; set; }
        public bool? Stato { get; set; }
        public int iDOfferta { get; set; }
        public string Tipo { get; set; }
        public string Seriale { get; set; }
        public DateTime? DataUltimaFatturazione { get; set; }
        public string Note { get; set; }
        public bool? Cancellato { get; set; }

    }
}
