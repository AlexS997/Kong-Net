using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("SchedeSimFatture")]
    internal class SchedeSimFatture
    {
        [ExplicitKey]
        public int iD { get; set; }
        public int iDScheda { get; set; }
        public string NumeroFattura { get; set; }
        public DateTime? DataFattura { get; set; }
        public double Importo { get; set; }
        public string Periodo { get; set; }
        

    }
}
