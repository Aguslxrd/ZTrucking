using Aplicacion_Almacen.ApiRequests;
using Aplicacion_Almacen.StoreHouseRequests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen.Forms
{
    public partial class DestinationListForm : Form
    {
        public int m, x, y;
        private ApiRequestDestinationList apiRequests;

        public DestinationListForm()
        {
            InitializeComponent();
            refreshTable();
        }

        private void DestinationListForm_Load(object sender, EventArgs e)
        {
            apiRequests = new ApiRequestDestinationList("http://localhost:64191");
        }

        private List<DestinationInterface> deserialize(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<DestinationInterface>>(content);
        }

        private static RestResponse getDestinationsFromApi()
        {
            RestClient client = new RestClient("http://localhost:64191");
            RestRequest request = new RestRequest("/api/v1/almacen/destinos", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);
            return response;
        }

        private static void fillDataTable(DataTable table, DestinationInterface destination)
        {
            DataRow rows = table.NewRow();
            rows["ID"] = destination.IDDestination;
            rows["Calle"] = destination.StreetDestination;
            rows["Numero Destino"] = destination.DoorNumber;
            rows["Esquina Destino"] = destination.CornerDestination;
            rows["Fecha estimada"] = destination.EstimatedDate;
            rows["Activado"] = destination.ActivedDestination;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            RestResponse response = getDestinationsFromApi();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Calle", typeof(string));
            table.Columns.Add("Numero Destino", typeof(string));
            table.Columns.Add("Esquina Destino", typeof(string));
            table.Columns.Add("Fecha estimada", typeof(DateTime));
            table.Columns.Add("Activado", typeof(bool));

            foreach (DestinationInterface destination in deserialize(response.Content))
            {
                fillDataTable(table, destination);
            }

            return table;
        }

        private void refreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewDestinations.DataSource = table;
        }

        private void buttonClose_Click(object sender, EventArgs e)
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

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
