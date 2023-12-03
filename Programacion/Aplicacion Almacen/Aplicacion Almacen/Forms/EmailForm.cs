using Aplicacion_Almacen.ApiRequests;
using Aplicacion_Almacen.Languages;
using Aplicacion_Almacen.StoreHouseRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen.Forms
{
    public partial class EmailForm : Form
    {
        private ApiRequestEmailNotifier apiRequests;
        public event Action LanguageChanged;
        private string jsonBody;

        public EmailForm()
        {
            InitializeComponent();
            apiRequests = new ApiRequestEmailNotifier("http://localhost:64191");
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            defaultMsgContent();
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateLanguage()
        {
            buttonSendEmail.Text = LanguageManager.GetString("SendEmail");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");

            labelDestination.Text = LanguageManager.GetString("Destination");
            labelMessage.Text = LanguageManager.GetString("Message");

        }

        private bool checkInputs()
        {
            if (string.IsNullOrEmpty(textBoxDestination.Text))
            {
                return false;
            }
            return true;
        }

        private void clearTxtBoxs()
        {
            textBoxDestination.Clear();
            richTextBoxContent.Clear();
        }

        private void defaultMsgContent()
        {
            richTextBoxContent.Text = "Estimado cliente,\n\nSu producto con ID: {ID} " +
            "se encuentra con el lote: {Lote} " +
            "en destino: {Destino}.\n\nLa posible fecha de llegada es {Fecha de llegada} " +
            "\nSi tiene alguna pregunta, no dude en ponerse en contacto con nuestro servicio de atención al cliente " +
            "(quickcarry.contacto@gmail.com).\n" +
            "\nGracias por su paciencia.\n\nAtentamente,\n\nQuickCarry - ZTracking System.";
    }

        private void sendEmailNotification()
        {
            jsonBody = "";

            if (!checkInputs())
            {
                MessageBox.Show(Messages.CompleteAllBoxAndStatus);
                return;
            }

            GmailNotifierInterface email = new GmailNotifierInterface
            {
                emaildestination = textBoxDestination.Text,
                msgcontent = richTextBoxContent.Text,
            };

            if (apiRequests.SendEmailNotification(email))
            {
                MessageBox.Show(Messages.Successful);
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
            }
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            sendEmailNotification();
        }

        private void buttonMsgTemplate_Click(object sender, EventArgs e)
        {
            defaultMsgContent();
        }
    }
}
