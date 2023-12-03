using Aplicacion_Almacen.ApiRequests;
using Aplicacion_Almacen.Languages;
using Aplicacion_Almacen.StoreHouseRequests;
using Newtonsoft.Json;
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
    public partial class AddBatchForm : Form
    {
        public event Action LanguageChanged;
        private string jsonBody;
        private ApiRequestBatch apiRequests;
        private int x, y, m;

        public AddBatchForm()
        {
            InitializeComponent();
            comboBoxActivated.Items.Add("true");
            comboBoxActivated.Items.Add("false");
            comboBoxActivated.SelectedItem = "false";
            comboBoxActivated.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPosition.Items.Add("Adelante");
            comboBoxPosition.Items.Add("Intermedio");
            comboBoxPosition.Items.Add("Atras");
            comboBoxPosition.SelectedItem = "Atras";

            roundedCircleForm();

            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestBatch("http://localhost:64191");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void UpdateLanguage()
        {

            labelEstatus.Text = LanguageManager.GetString("Status");
            labelEstimatedDate.Text = LanguageManager.GetString("EstimatedDate");
            labelIDDestination.Text = LanguageManager.GetString("IDDestination");
            labelPosition.Text = LanguageManager.GetString("Position");

            buttonSave.Text = LanguageManager.GetString("Save");
            buttonCancel.Text = LanguageManager.GetString("Cancel");

        }

        private bool validateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDDestination.Text))
            {
                return false;
            }

            return true;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            jsonBody = "";

            string selectedStatus = comboBoxActivated.SelectedItem as string;
            int statusValue = selectedStatus == "true" ? 1 : 0;

            if (!validateInputsUser() || string.IsNullOrWhiteSpace(selectedStatus))
            {
                MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
                return;
            }

            if (!int.TryParse(txtBoxIDDestination.Text, out int idDestination))
            {
                MessageBox.Show(Messages.InvalidID);
                return;
            }

            DateTime separateddate = dateTimePickerBatchShippingDate.Value.Date;
            DateTime separatedtime = dateTimePickerBatchManagementTime.Value;
            DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);

            BatchInterface batch = new BatchInterface
            {
                IDShipp = idDestination,
                Email = txtBoxEmail.Text,
                ShippingDate = Convert.ToDateTime(dateandtime),
                Position = comboBoxPosition.SelectedItem?.ToString(),
                ActivedBatch = Convert.ToBoolean(statusValue)
            };

            jsonBody = JsonConvert.SerializeObject(batch);

            if (apiRequests.AddBatch(batch))
            {
                MessageBox.Show(Messages.Successful);
            }
            else
            {
                MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
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
        
    }
}
