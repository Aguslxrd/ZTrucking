using Aplicacion_Almacen.APIRequests;
using Aplicacion_Almacen.Languages;
using Aplicacion_Almacen.StoreHouseRequests;
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

namespace Aplicacion_Almacen.Forms.crudForms
{
    public partial class AddProductForm : Form
    {
        private ApiRequestProduct apiRequests;
        private string jsonBody;
        public event Action LanguageChanged;
        private int x, y, m;

        public AddProductForm()
        {
            InitializeComponent();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(Languages.Resource_language_english));
            apiRequests = new ApiRequestProduct("http://localhost:64191");
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
            labelActivated.Text = LanguageManager.GetString("Activated");
            labelCorner.Text = LanguageManager.GetString("Corner");
            labelCustomer.Text = LanguageManager.GetString("Customer");
            labelNumber.Text = LanguageManager.GetString("Number");
            labelStreet.Text = LanguageManager.GetString("Street");
            labelVolume.Text = LanguageManager.GetString("Volume");
            labelWeight.Text = LanguageManager.GetString("Weight");
            buttonSave.Text = LanguageManager.GetString("Save");
            buttonCancel.Text = LanguageManager.GetString("Cancel");
        }

        private bool validateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxWeight.Text) ||
                string.IsNullOrWhiteSpace(txtBoxVolume.Text) ||
                string.IsNullOrWhiteSpace(txtBoxStreet.Text) ||
                string.IsNullOrWhiteSpace(txtBoxNumber.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCorner.Text) ||
                string.IsNullOrWhiteSpace(txtBoxClient.Text))
            {
                return false;
            }

            return true;
        }

        private void clearTxtBoxs()
        {
            txtBoxWeight.Clear();
            txtBoxVolume.Clear();
            txtBoxStreet.Clear();
            txtBoxNumber.Clear();
            txtBoxCorner.Clear();
            txtBoxClient.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            jsonBody = "";

            string selectedStatus = comboBoxActivated.SelectedItem as string;
            int statusValue = selectedStatus == "true" ? 1 : 0;

            if (!validateInputsUser() && !string.IsNullOrWhiteSpace(selectedStatus))
            {
                MessageBox.Show(Messages.CompleteAllBoxAndStatus);
                return;
            }

            try
            {
                ProductInterface product = new ProductInterface
                {
                    ProductWeight = Convert.ToInt32(txtBoxWeight.Text),
                    Volume = Convert.ToInt32(txtBoxVolume.Text),
                    Street = txtBoxStreet.Text,
                    DoorNumber = Convert.ToInt32(txtBoxNumber.Text),
                    Corner = txtBoxCorner.Text,
                    Customer = txtBoxClient.Text,
                    ActivatedProduct = Convert.ToBoolean(statusValue)
                };

                if (apiRequests.AddProduct(product))
                {
                    MessageBox.Show(Messages.Successful);
                    clearTxtBoxs();
                }
                else
                {
                    MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(Messages.Error);
            }

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
