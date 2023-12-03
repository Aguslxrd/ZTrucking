using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class GmailsForm : Form
    {

        public event Action LanguageChanged;

        protected string email = "quickcarry.correo@gmail.com";
        protected string passwordemail = "hwsnwtkluboprshu";
        public GmailsForm()
        {
            InitializeComponent();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_english));
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateLanguage()
        {
            buttonSendEmail.Text = LanguageManager.GetString("Add");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelDestination.Text = LanguageManager.GetString("Destination");
            labelSubject.Text = LanguageManager.GetString("Subject");
        }

        private bool checkInputs()
        {
            if (string.IsNullOrEmpty(textBoxDestination.Text) || string.IsNullOrEmpty(textBoxSubject.Text))
            {
                return false;
            }
            return true;
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInputs())
                {
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                mm.From = new MailAddress(email);
                mm.To.Add(textBoxDestination.Text);
                mm.Subject = textBoxSubject.Text;
                mm.Body = richTextBoxContent.Text;
                sc.Port = 587;
                sc.EnableSsl = true;
                sc.Credentials = new System.Net.NetworkCredential(email, passwordemail);
                sc.EnableSsl = true;
                sc.Send(mm);
                MessageBox.Show("Email has been sent.");
                }
                else
                {
                    MessageBox.Show("Campo/s vacio/s");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
