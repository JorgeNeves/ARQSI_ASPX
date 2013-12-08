using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace EnviarMAILS
{
    public static class Email
    {
        public static void enviarEmail(string destinatario, string assunto, string mensagem)
        {
            try
            {

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.EnableSsl = true;

                MailAddress remetente = new MailAddress("idbiblioisep@gmail.com", "IDBiblio Sistema");
                MailAddress dest = new MailAddress(destinatario, "Dest");
                MailMessage msg = new MailMessage(remetente, dest);
                msg.Body = mensagem;
                msg.Subject = assunto;
                
                NetworkCredential credenciais = new NetworkCredential("idbiblioisep@gmail.com", "Iseplivros");
                cliente.Credentials = credenciais;
                cliente.Send(msg);
            }
            catch (Exception)
            {
                
            }
           
        }

    }
}