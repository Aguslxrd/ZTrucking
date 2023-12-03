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
    public partial class AddProductForm : Form
    {

        public event Action LanguageChanged;
        private int x, y, m;

        public AddProductForm()
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

            comboBoxActivated.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActivated.Items.Add("true");
            comboBoxActivated.Items.Add("false");
            comboBoxActivated.SelectedItem = "true";
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
            labelActived.Text = LanguageManager.GetString("Activated");
            labelProductCorner.Text = LanguageManager.GetString("Corner");
            labelCustomer.Text = LanguageManager.GetString("Customer");
            labelDoorNumber.Text = LanguageManager.GetString("Number");
            labelProductStreet.Text = LanguageManager.GetString("Street");
            labelProductVolume.Text = LanguageManager.GetString("Volume");
            labelProductWeight.Text = LanguageManager.GetString("Weight");
            buttonSave.Text = LanguageManager.GetString("Save");
            buttonCancel.Text = LanguageManager.GetString("Cancel");
        }

        public void ClearTxtBoxes()
        {
            txtBoxCustomer.Clear();
            txtBoxWeight.Clear();
            txtBoxCorner.Clear();
            txtBoxStreet.Clear();
            txtBoxVolume.Clear();
        }

        private bool ValidateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxCustomer.Text) ||
                string.IsNullOrWhiteSpace(txtBoxWeight.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCustomer.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCorner.Text) ||
                string.IsNullOrWhiteSpace(txtBoxStreet.Text) ||
                string.IsNullOrWhiteSpace(txtBoxVolume.Text))
            {
                return false;
            }

            return true;
        }

        private void addProduct()
        {
            try
            {
                string selectedStatus = comboBoxActivated.SelectedItem as string;
                int statusValue = selectedStatus == "true" ? 1 : 0;
                ProductController.Crear(Int32.Parse(txtBoxWeight.Text), Int32.Parse(txtBoxVolume.Text), txtBoxStreet.Text, Int32.Parse(txtBoxDoorNumber.Text), txtBoxCorner.Text, txtBoxCustomer.Text, Convert.ToBoolean(statusValue));
                MessageBox.Show(Languages.Messages.Successful);
                ClearTxtBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsUser())
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                return;
            }
            addProduct();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panelSlide_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            x = e.X;
            y = e.Y;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
