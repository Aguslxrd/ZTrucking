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
    public partial class AssignBatchToTruckForm : Form
    {
        public event Action LanguageChanged;
        private int x, m, y;

        public AssignBatchToTruckForm()
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

            labelIDLot.Text = LanguageManager.GetString("LotID");
            labelShipDate.Text = LanguageManager.GetString("EstimatedDate");
            buttonSave.Text = LanguageManager.GetString("Save");
            buttonCancel.Text = LanguageManager.GetString("Cancel");
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        public void ClearTxtBoxesShippingManagement()
        {
            txtBoxIDBatchShippManagement.Clear();
            txtBoxIDTruckShippManagement.Clear();
        }

        private bool ValidateShippingManagerInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxIDBatchShippManagement.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDTruckShippManagement.Text))
            {
                return false;
            }

            return true;
        }

        private void addShippment()
        {
            try
            {
                DateTime separateddate = dateTimePickerShippManagement.Value.Date;
                DateTime separatedtime = dateTimePickerShippManagementTime.Value;
                DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);
                ShippingManagementController.Create(Int32.Parse(txtBoxIDTruckShippManagement.Text), Int32.Parse(txtBoxIDBatchShippManagement.Text), dateandtime);
                MessageBox.Show(Languages.Messages.Successful);
                ClearTxtBoxesShippingManagement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateShippingManagerInputsUser())
            {
                addShippment();
            }
            else
            {
                MessageBox.Show(Languages.Messages.Error);
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
