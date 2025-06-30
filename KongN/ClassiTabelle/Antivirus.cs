using System;
using Dapper.Contrib.Extensions;

namespace KongN.ClassiTabelle
{
    [Table("Antivirus")]
    public class Antivirus
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Cliente { get; set; }
        public string CodiceKing { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public string Pr { get; set; }
        public string Telefono { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        public int? iDMarca { get; set; }
        public string CodiceAntivirus { get; set; }
        public int? Postazioni { get; set; }
        public DateTime? DataAcquisto { get; set; }
        public DateTime? DataRinnovo { get; set; }
        public DateTime? DataScadenza { get; set; }
        public double? Importo { get; set; }
        public string Note { get; set; }
        public int? iDUtente { get; set; }
        public DateTime? DataModifica { get; set; }
    }

}

