using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("ContrattiProfili")]
    internal class ContrattiProfili
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public string Profilo { get; set; }
        public double PrezzoAnnuale { get; set; }
        public double PrezzoAnnualeSO { get; set; }
        public double Attivazione { get; set; }
        public double AttivazioneSO { get; set; }
        public bool? Ricaricabile { get; set; }
        public bool? isNoleggio { get; set; }
        public string CodIva { get; set; }
        public string ContoRicavo { get; set; }
        public bool? Attivo { get; set; }
        public int idUtente { get; set; }
        public DateTime? DataModifica { get; set; }

    }
}
