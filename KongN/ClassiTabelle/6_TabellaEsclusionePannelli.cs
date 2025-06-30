using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("6_TabellaEsclusionePannelli")]
    public class _6_TabellaEsclusionePannelli
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string UserName { get; set; }
    }
}
