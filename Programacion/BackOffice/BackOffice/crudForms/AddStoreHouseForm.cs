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
    public partial class AddStoreHouseForm : Form
    {
        public event Action LanguageChanged;
        private int x, y, m;

        public AddStoreHouseForm()
        {
            InitializeComponent();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_english));
            comboBoxActivated.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActivated.Items.Add("true");
            comboBoxActivated.Items.Add("false");
            comboBoxActivated.SelectedItem = "true";
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
            labelStreet.Text = LanguageManager.GetString("Street");
            labelCorner.Text = LanguageManager.GetString("Corner");
            labelNumber.Text = LanguageManager.GetString("Number");
            labelActived.Text = LanguageManager.GetString("Activated");
            buttonSave.Text = LanguageManager.GetString("Save");
            buttonCancel.Text = LanguageManager.GetString("Cancel");
        }

        private bool ValidateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxStoreHouseCorner.Text) ||
                string.IsNullOrWhiteSpace(txtBoxStoreHouseDoorNumber.Text) ||
                string.IsNullOrWhiteSpace(txtBoxStoreHouseStreet.Text))
            {
                return false;
            }

            return true;
        }

        public void ClearTxtBoxesAddStoreHouse()
        {
            txtBoxStoreHouseStreet.Clear();
            txtBoxStoreHouseDoorNumber.Clear();
            txtBoxStoreHouseCorner.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string selectedStatus = comboBoxActivated.SelectedItem as string;
            if (ValidateInputsUser() && !string.IsNullOrWhiteSpace(selectedStatus))
            {
                StoreHouseController.Create(txtBoxStoreHouseStreet.Text, txtBoxStoreHouseDoorNumber.Text, txtBoxStoreHouseCorner.Text, Convert.ToBoolean(selectedStatus));
                MessageBox.Show(Languages.Messages.Successful);
                ClearTxtBoxesAddStoreHouse();
            }
            else
            {
                MessageBox.Show(LanguageManager.GetString("CompleteAllBoxAndStatus"));
            }
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
