using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("AntivirusMarche")]
    public class AntivirusMarche
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Antivirus { get; set; }
        public float P1 { get; set; }
        public float P2 { get; set; }
        public float P3 { get; set; }
        public float P4 { get; set; }
        public float P5 { get; set; }
        public float P6 { get; set; }
        public float P7 { get; set; }
        public float P8 { get; set; }
        public float P9 { get; set; }
        public float P10 { get; set; }
        public int iDUtente { get; set; }
        public DateTime DataModifica { get; set; }
    }
}
