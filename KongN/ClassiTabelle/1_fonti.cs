using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("1_fonti")]
    public class _1_fonti
    {
        [ExplicitKey]
        public int iDFonte { get; set; }
        public string FONTE { get; set; }
        public string Note { get; set; }
    }
}
