using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongN.Classi
{
    static class Global
    {
        private static string _username;
        private static string _password;
        private static string _iD;
        private static string _nome;
        private static string _email;
        private static bool _isSuperuser;
        private static bool _isAdmin;
        private static string _esercizio;
        private static string _ultimoCambioPassword;
        private static bool _passwordSenzaScadenza;
        private static bool _isActive;
        private static string _livelloPassword;


        private static string _connKongN;
        private static string _connAna;
        private static string _connComune;

        public static string connKongN
        {
            get { return _connKongN; }
            set { _connKongN = value; }
        }

        public static string connAna
        {
            get { return _connAna; }
            set { _connAna = value; }
        }

        public static string connComune
        {
            get { return _connComune; }
            set { _connComune = value; }
        }

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public static string ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public static string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public static string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public static bool IsSuperuser
        {
            get { return _isSuperuser; }
            set { _isSuperuser = value; }
        }

        public static bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }

        public static string Esercizio
        {
            get { return _esercizio; }
            set { _esercizio = value; }
        }

        public static string UltimoCambioPassword
        {
            get { return _ultimoCambioPassword; }
            set { _ultimoCambioPassword = value; }
        }

        public static bool PasswordSenzaScadenza
        {
            get { return _passwordSenzaScadenza; }
            set { _passwordSenzaScadenza = value; }
        }

        public static bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public static string LivelloPassword
        {
            get { return _livelloPassword; }
            set { _livelloPassword = value; }
        }

        // variabile per la tabella Automatismi

        private static string _IndirizzoServerSMTP;
        private static string _NomeUtenteSMTP;
        private static string _PasswordSMTP;
        private static string _EmailSMTP;
        private static bool _TLSSMTP;
        private static int _Porta;

        public static string IndirizzoServerSMTP
        {
            get { return _IndirizzoServerSMTP; }
            set { _IndirizzoServerSMTP = value; }
        }

        public static string PasswordSMTP
        {
            get { return _PasswordSMTP; }
            set { _PasswordSMTP = value; }
        }

        public static string NomeUtenteSMTP
        {
            get { return _NomeUtenteSMTP; }
            set { _NomeUtenteSMTP = value; }
        }

        public static string EmailSMTP
        {
            get { return _EmailSMTP; }
            set { _EmailSMTP = value; }
        }

        public static bool TLSSMTP
        {
            get { return _TLSSMTP; }
            set { _TLSSMTP = value; }
        }

        public static int Porta
        {
            get { return _Porta; }
            set { _Porta = value; }
        }

        // variabili per l'aggiornamento del programma
        private static string _FileUltimaVersione;
        private static string _FileSetup;
        private static string _NomeSetup;

        public static string FileUltimaVersione
        {
            get { return _FileUltimaVersione; }
            set { _FileUltimaVersione = value; }
        }

        public static string FileSetup
        {
            get { return _FileSetup; }
            set { _FileSetup = value; }
        }

        public static string NomeSetup
        {
            get { return _NomeSetup; }
            set { _NomeSetup = value; }
        }
    }
}
