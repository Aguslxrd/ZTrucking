using Aplicacion_Almacen.ApiRequests;
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
    public partial class AssignBatchToTruckComponentForm : Form
    {

        private ApiRequestAssignBatchToTruck apiRequests;
        private string jsonBody;
        public event Action LanguageChanged;
        private int x, y, m;

        public AssignBatchToTruckComponentForm()
        {
            InitializeComponent();
            roundedCircleForm();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestAssignBatchToTruck("http://localhost:64191");
        }

        private void UpdateLanguage()
        {

            labelTruckID.Text = LanguageManager.GetString("IDTruck");
            labelEstimatedDate.Text = LanguageManager.GetString("EstimatedDate");
            labelIDBatch.Text = LanguageManager.GetString("LotID");

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

        private void AssignBatchToTruckComponentForm_Load(object sender, EventArgs e)
        {


        }

        private void clearTxtsBoxes()
        {
            txtBoxIDBatch.Clear();
            txtBoxIDTruck.Clear();
        }

        private bool validateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxIDBatch.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDTruck.Text))
            {
                return false;
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            jsonBody = "";

            if (!validateInputsUser())
            {
                MessageBox.Show(Messages.CompleteAllBoxAndStatus);
                return;
            }

            if (!int.TryParse(txtBoxIDBatch.Text, out int idBatch) || !int.TryParse(txtBoxIDTruck.Text, out int idTruck))
            {
                MessageBox.Show(Messages.InvalidID);
                return;
            }

            DateTime separateddate = dateTimePickerBatchShippingDate.Value.Date;
            DateTime separatedtime = dateTimePickerAssignBatchToTruckManagementTime.Value;
            DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);

            AssignedBatchToTruckInterface batchAssigned = new AssignedBatchToTruckInterface
            {
                IDBatch = idBatch,
                IDTruck = idTruck,
                ShippDate = dateandtime
            };

            if (apiRequests.AddAssignedBatchToTruck(batchAssigned))
            {
                MessageBox.Show(Messages.Successful);
                clearTxtsBoxes();
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
