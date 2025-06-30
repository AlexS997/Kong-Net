using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;


namespace KongN.Classi
{
    internal class Email
    {

        // Metodo che accetta i parametri di connessione al server SMTP tramite un dizionario
        public static void MandamailConDizionario(string Mittente, string Destinatario, string Oggetto, string Corpo, Dictionary<string, string> parametriSMTP)
        {
            try
            {
                var email = new MimeMessage();

                email.From.Add(MailboxAddress.Parse(Mittente));
                email.To.Add(MailboxAddress.Parse(Destinatario));
                email.Subject = Oggetto;
                email.Body = new TextPart { Text = Corpo };

                var smtp = new SmtpClient();
                smtp.Connect(parametriSMTP["IndirizzoServerSMTP"], int.Parse(parametriSMTP["Porta"]), MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(parametriSMTP["NomeUtenteSMTP"], parametriSMTP["PasswordSMTP"]);


                smtp.Send(email);

                smtp.Disconnect(true);

            }
            catch (Exception ex)
            {
                var errorMessage = ex.GetBaseException().Message;
                throw;
            }
        }
    }
}
