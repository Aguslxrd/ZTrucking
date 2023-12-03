using capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice.crudForms
{
    public partial class EditUserForm : Form
    {

        private int x, y, m;

        public EditUserForm()
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

        private void updateLanguage()
        {
            labelFirstName.Text = LanguageManager.GetString("FirstName");
            labelFirstLastName.Text = LanguageManager.GetString("FirstLastName");
            labelPhoneNumber.Text = LanguageManager.GetString("PhoneNumber");
            labelUsername.Text = LanguageManager.GetString("Username");
            labelPassword.Text = LanguageManager.GetString("Password");
            buttonSave.Text = LanguageManager.GetString("Save");
            buttonCancel.Text = LanguageManager.GetString("Cancel");

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearTxtBoxes()
        {
            txtBoxFirstName.Clear();
            txtBoxFirstLastName.Clear();
            txtBoxPhoneNumber.Clear();
            txtBoxPassword.Clear();
            txtBoxUsername.Clear();
            txtBoxUserID.Clear();
        }
        private bool validateInputsUser()
        {

            if (
                string.IsNullOrWhiteSpace(txtBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxFirstLastName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtBoxUsername.Text) ||
                 string.IsNullOrWhiteSpace(txtBoxUserID.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword.Text)
                )
            {
                return false;
            }

            return true;
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateInputsUser())
                {
                    UserController.Edit(Int32.Parse(txtBoxUserID.Text), txtBoxFirstName.Text, txtBoxFirstLastName.Text, txtBoxPhoneNumber.Text, txtBoxUsername.Text, txtBoxPassword.Text);
                    MessageBox.Show(Languages.Messages.Successful);
                    clearTxtBoxes();
                }
                else
                {
                    MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panelSlide_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            x = e.X;
            y = e.Y;
        }

        private void panelSlide_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }


    }
}
