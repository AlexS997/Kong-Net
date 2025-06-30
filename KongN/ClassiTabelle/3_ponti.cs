using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("3_ponti")]
    public class _3_ponti
    {
        [ExplicitKey]
        public int iDPonti { get; set; }
        public string Ponte { get; set; }
        public string Note { get; set; }
        public int idGateway { get; set; }
        public int idPontePadre { get; set; }
        public string Dipendenza { get; set; }
        public double Latitudine { get; set; }
        public double Longitudine { get; set; }

    }
}
