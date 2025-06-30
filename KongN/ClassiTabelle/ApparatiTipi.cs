using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("ApparatiTipi")]
    public class ApparatiTipi
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Descrizione { get; set; }
    }
}
