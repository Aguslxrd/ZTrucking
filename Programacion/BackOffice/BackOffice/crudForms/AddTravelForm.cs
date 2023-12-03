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
    public partial class AddTravelForm : Form
    {

        private int x, y, m;

        public AddTravelForm()
        {
            InitializeComponent();
            roundedCircleForm();

            comboBoxTypeTravel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeTravel.SelectedText = "Inicio";
            comboBoxTypeTravel.Items.Add("Inicio");
            comboBoxTypeTravel.Items.Add("Parada");
            comboBoxTypeTravel.Items.Add("Fin");
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
            labelIDDestination.Text = LanguageManager.GetString("DestinationID");
            labelIDStoreHouse.Text = LanguageManager.GetString("StoreHouseID");
            labelTypeTravel.Text = LanguageManager.GetString("IDOperator");
            labelDateTravel.Text = LanguageManager.GetString("EstimatedDate");

            buttonSave.Text = LanguageManager.GetString("Save");
            buttonCancel.Text = LanguageManager.GetString("Cancel");
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

        public void ClearTxtBoxes()
        {
            txtBoxIDDestination.Clear();
            txtBoxIDStoreHouse.Clear();
        }

        private bool ValidateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxIDStoreHouse.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDDestination.Text))
            {
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedStatus = comboBoxTypeTravel.SelectedItem as string;
                DateTime fechaSeleccionada = dateTimePickerShippmentDate.Value.Date;
                DateTime horaSeleccionada = dateTimePickerShippmentDateTime.Value;
                DateTime fechaHoraSeleccionada = fechaSeleccionada.Add(horaSeleccionada.TimeOfDay);
                if (ValidateInputsUser() && !string.IsNullOrEmpty(selectedStatus))
                {
                    TravelController.Create(Int32.Parse(txtBoxIDStoreHouse.Text), Int32.Parse(txtBoxIDDestination.Text), selectedStatus, fechaHoraSeleccionada);
                    MessageBox.Show(Messages.Successful);
                    Refresh();
                    ClearTxtBoxes();
                }
                else if (string.IsNullOrWhiteSpace(selectedStatus))
                {
                    MessageBox.Show(Messages.CompleteAllBoxAndStatus);
                }
                else
                {
                    MessageBox.Show(Messages.CompleteAllBoxAndStatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
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
