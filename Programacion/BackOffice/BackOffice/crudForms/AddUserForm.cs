using BackOffice.Languages;
using capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice.crudForms
{
    public partial class AddUserForm : Form
    {

        private int x, y, m;

        public AddUserForm()
        {
            InitializeComponent();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_english));
            roundedCircleForm();
        }

        private void roundedCircleForm()
        {
            int radiusBorder = 25;

            Rectangle rectangleBorder = new Rectangle(0, 0, this.Width, this.Height);

            GraphicsPath graphicBorder = new GraphicsPath();
            graphicBorder.AddArc(rectangleBorder.X, rectangleBorder.Y, radiusBorder, radiusBorder, 180, 90);
            graphicBorder.AddArc(rectangleBorder.Right - radiusBorder, rectangleBorder.Y, radiusBorder, radiusBorder, 270, 90);
            graphicBorder.AddArc(rectangleBorder.Right - radiusBorder, rectangleBorder.Bottom - radiusBorder, radiusBorder, radiusBorder, 0, 90);
            graphicBorder.AddArc(rectangleBorder.X, rectangleBorder.Bottom - radiusBorder, radiusBorder, radiusBorder, 90, 90);
            graphicBorder.CloseAllFigures();

            this.Region = new Region(graphicBorder);
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

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        public void clearTxtBoxes()
        {
            txtBoxFirstName.Clear();
            txtBoxFirstLastName.Clear();
            txtBoxPhoneNumber.Clear();
            txtBoxPassword.Clear();
            txtBoxUsername.Clear();
        }
        private bool validateInputsUser()
        {

            if (
                string.IsNullOrWhiteSpace(txtBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxFirstLastName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword.Text)
                )
            {
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!validateInputsUser())
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                return;
            }
            if (txtBoxUsername.Text.Length > 16)
            {
                MessageBox.Show(Messages.UsernameTooLong);
                return;
            }
            createUser();
        }

        private void createUser()
        {
            try
            {
                UserController.Crear(
                txtBoxFirstName.Text,
                txtBoxFirstLastName.Text,
                txtBoxPhoneNumber.Text,
                txtBoxUsername.Text,
                txtBoxPassword.Text
            );
            MessageBox.Show(Languages.Messages.Successful);
            clearTxtBoxes();
            }catch(Exception ex)
            {
                MessageBox.Show(Messages.Error + " " + ex.Message);
            }

        }

        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {

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
