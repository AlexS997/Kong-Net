using System;
using Dapper.Contrib.Extensions;

namespace KongN.ClassiTabelle
{
    [Table("Utenti")]
    public class TabellaUtenti
    {
        [ExplicitKey]
        public int iD { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool? isSuperuser { get; set; }
        public bool? isAdministrator { get; set; }
        public int? Esercizio { get; set; }
        public DateTime? UltimoCambioPassword { get; set; }
        public bool? PasswordSenzaScadenza { get; set; }
        public bool? isActive { get; set; }
        public int? LivelloPassword { get; set; }
    }
}
