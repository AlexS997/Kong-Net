using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("2_gateways")]
    public class _2_gateways
    {
        [ExplicitKey]
        public int iDGateway { get; set; }
        public string GATEWAY { get; set; }
        public string Descrizione { get; set; }
        public string Note { get; set; }
        public int idFonte { get; set; }
        public double Latitudine { get; set; }
        public double Longitudine { get; set; }

    }
}
