using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    [Table("MessaggiDefinizione")]
    internal class MessaggiDefinizione
    {
        [ExplicitKey]
        public int Id { get; set; }
        public string Descrizione { get; set; }
        public string Messaggio { get; set; }
        public string Parametro1 { get; set; }
        public string Parametro2 { get; set; }
        public string Parametro3 { get; set; }

    }
}
