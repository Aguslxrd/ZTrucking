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
    public partial class EditCarrieForm : Form
    {
        public event Action LanguageChanged;
        private int x, y, m;

        public EditCarrieForm()
        {
            InitializeComponent();
            comboBoxStatus.Items.Add("Entregado");
            comboBoxStatus.Items.Add("EnCamino");
            comboBoxStatus.Items.Add("Retrasado");
            comboBoxStatus.Items.Add("NoEnviado");
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxStatus.SelectedIndex = 3;
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
            labelIDTruck2.Text = LanguageManager.GetString("IDTruck");
            labelIDLot2.Text = LanguageManager.GetString("LotID");
            labelIDestination.Text = LanguageManager.GetString("IDDestination");
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

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void clearTxtBox()
        {
            txtBoxIDBatchCarrie.Clear();
            txtBoxIDDestinationCarrie.Clear();
            txtBoxIDTruckCarrie.Clear();
        }

        private bool ValidateCarrieManagementInputsUser()
        {
            if (string.IsNullOrWhiteSpace(txtBoxIDBatchCarrie.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDTruckCarrie.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDDestinationCarrie.Text))
            {
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string selectedStatus = comboBoxStatus.SelectedItem as string;
            if (ValidateCarrieManagementInputsUser() && !string.IsNullOrWhiteSpace(selectedStatus))
            {
                int idTruck = int.Parse(txtBoxIDTruckCarrie.Text);
                int idBatch = int.Parse(txtBoxIDBatchCarrie.Text);
                int idDestination = int.Parse(txtBoxIDDestinationCarrie.Text);
                CarryShippmentController.EditCarry(idTruck, idBatch, idDestination, selectedStatus);
                MessageBox.Show(Messages.Successful);
                clearTxtBox();
            }
            else if (string.IsNullOrWhiteSpace(selectedStatus))
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
            }
            else
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
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


    }
}
