using Aplicacion_Almacen.ApiRequests;
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
    public partial class ViewTrucksForm : Form
    {
        public event Action LanguageChanged;
        private string jsonBody;
        private ApiRequestTruckList apiRequests;
        private int x, y, m;

        public ViewTrucksForm()
        {
            InitializeComponent();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestTruckList("http://localhost:64191");
            refreshTable();
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

        private void UpdateLanguage()
        {
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
        }

        private void ViewTrucksForm_Load(object sender, EventArgs e)
        {

        }

        private List<TruckInterface> deserializeTruck(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<TruckInterface>>(content);
        }

        private static void fillDataTable(DataTable table, TruckInterface truck)
        {
            DataRow rows = table.NewRow();
            rows["ID Camion"] = truck.TruckID;
            rows["Volumen Camion"] = truck.TruckVolume;
            rows["Peso Camion"] = truck.TruckWeight;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            ApiRequestTruckList apiRequest = new ApiRequestTruckList("http://localhost:64191");

            List<TruckInterface> trucks = apiRequest.GetTrucks();
            DataTable table = new DataTable();
            table.Columns.Add("ID Camion", typeof(int));
            table.Columns.Add("Volumen Camion", typeof(int));
            table.Columns.Add("Peso Camion", typeof(int));
            foreach (TruckInterface truck in trucks)
            {
                DataRow row = table.NewRow();
                row["ID Camion"] = truck.TruckID;
                row["Volumen Camion"] = truck.TruckVolume;
                row["Peso Camion"] = truck.TruckWeight;
                table.Rows.Add(row);
            }
            return table;
        }

        private void refreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewTruckList.DataSource = table;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
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
