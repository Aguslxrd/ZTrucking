using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace ApiAlmacen.Notifier
{
    public class EmailNotifier
    {
        protected string email = "quickcarry.correo@gmail.com";
        protected string passwordemail = "hwsnwtkluboprshu";
        public string emailDestination { get; set; }
        public string msgcontent { get; set; }

        private string subject = "Notificacion desde ZTracking";

        public void SendEmailNotification(string emailDestination, string msgcontent)
        {
            try
            {
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                mm.From = new MailAddress(this.email);
                mm.To.Add(emailDestination);  
                mm.Subject = subject;
                mm.Body = msgcontent;
                sc.Port = 587;
                sc.EnableSsl = true;
                sc.Credentials = new System.Net.NetworkCredential(this.email, this.passwordemail);
                sc.Send(mm);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }


    }

}