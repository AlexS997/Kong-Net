using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("VoiPPrefissiStandard")]
    internal class VoiPPrefissiStandard
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string DESTINAZIONESTD { get; set; }
        public string CODICE { get; set; }
        public string RATE { get; set; }


    }
}
