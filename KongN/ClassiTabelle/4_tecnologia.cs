using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("4_tecnologia")]
    public class _4_tecnologia
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Tecnologia { get; set; }
    }
}
