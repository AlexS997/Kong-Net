using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("5_Clientirete")]
    internal class _5_Clientirete
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Username { get; set; }
        public string CodCli { get; set; }
        public string Denom { get; set; }
        public int iDpannelli { get; set; }
        public string Location { get; set; }
        public string ActualProfile { get; set; }
        public double Latitudine { get; set; }
        public double Longitudine { get; set; }
        public string Note { get; set; }

    }
}
