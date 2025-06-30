using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("Agenda")]
    public class Agenda
    {
        [ExplicitKey]
        public int Id { get; set; }
        public string Titolo { get; set; }
        public bool? Interno { get; set; }
        public string Codice { get; set; }
        public string Denom { get; set; }
        public string GeneratoDa { get; set; }
        public string Descrizione { get; set; }
        public DateTime? DataInserimento { get; set; }
        public DateTime? DataInizio { get; set; }
        public DateTime? DataFine { get; set; }
        public bool? Concluso { get; set; }
        public int iDUtente { get; set; }
        public DateTime? DataModifica { get; set; }
    }
}
