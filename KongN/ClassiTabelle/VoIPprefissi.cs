using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("VoIPprefissi")]

    internal class VoIPprefissi
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string stato { get; set; }
        public int tipo { get; set; }
        public double costo { get; set; }
        public string prefisso { get; set; }
        public double scatto { get; set; }
        public int iDNazione { get; set; }

    }
}
