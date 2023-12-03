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
    public partial class AddTruckForm : Form
    {

        private int x, y, m;

        public AddTruckForm()
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
            labelActivated.Text = LanguageManager.GetString("Activated");
            labelTruckWeight.Text = LanguageManager.GetString("Weight");
            labelTruckVolume.Text = LanguageManager.GetString("Volume");

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

        private void txtBoxWeightTruck_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTruckWeight_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxVolumeTruck_TextChanged(object sender, EventArgs e)
        {

        }

        public void ClearTxtBoxesTruck()
        {
            txtBoxVolumeTruck.Clear();
            txtBoxWeightTruck.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedStatus = comboBoxActivated.SelectedItem as string;
                int statusValue = selectedStatus == "true" ? 1 : 0;
                if (string.IsNullOrWhiteSpace(txtBoxWeightTruck.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxVolumeTruck.Text) ||
                    !int.TryParse(txtBoxWeightTruck.Text, out int weight) ||
                    !int.TryParse(txtBoxVolumeTruck.Text, out int volume))
                {
                    MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                    return;
                }

                TruckController.Create(weight, volume, Convert.ToBoolean(statusValue));
                MessageBox.Show(Languages.Messages.Successful);
                ClearTxtBoxesTruck();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
        
    }
}
