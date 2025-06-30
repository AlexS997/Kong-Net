using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.ClassiTabelle
{
    public class Utenti
    {
        public int iD { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool? Administrator { get; set; }
        public byte? Esercizio { get; set; }
        public DateTime? UltimoCambioPassword { get; set; }
        public bool? PasswordSenzaScadenza { get; set; }
        public bool? isActive { get; set; }
        public int? LivelloPassword { get; set; }
    }

}
