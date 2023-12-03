using Aplicacion_Almacen.Languages;
using Aplicacion_Choferes.ApiRequests;
using Aplicacion_Choferes.APIRequests;
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

namespace Aplicacion_Choferes.Forms
{
    public partial class ShippmentsManagerForm : Form
    {

        public event Action LanguageChanged;
        private ApiRequestShipmentManager shipmentsApiRequest = new ApiRequestShipmentManager("http://localhost:50294");


        public ShippmentsManagerForm()
        {
            InitializeComponent();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            LanguageManager.Initialize(typeof(Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(Languages.Resource_language_english));
        }

        private void UpdateLanguage()
        {
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
            buttonSearchByDestinationID.Text = LanguageManager.GetString("SearchByDestinationID");
            buttonSearchByStoreHouseID.Text = LanguageManager.GetString("SearchByStoreHouseID");

            labelIDDestination.Text = LanguageManager.GetString("IDDestination");
            labelStoreHouse.Text = LanguageManager.GetString("StoreHouseID");

        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<ShippmentsInterface> deserializeShipps(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<ShippmentsInterface>>(content);
        }

        private static void fillDataTable(DataTable table, ShippmentsInterface shipp)
        {
            DataRow row = table.NewRow();
            row["ID Destino"] = shipp.IDDestination;
            row["ID Almacen"] = shipp.IDStoreHouse;
            row[LanguageManager.GetString("TypeTravel")] = shipp.TypeTravel;
            row[LanguageManager.GetString("ShipmentDate")] = shipp.ShippmentDate;
            table.Rows.Add(row);
        }

        private void buttonSearchByDestinationID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDDestination.Text, out int searchID))
            {
                ShippmentsInterface shipp = shipmentsApiRequest.GetShippmentsByDestinationID(searchID);

                if (shipp != null)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Destino", typeof(int));
                    table.Columns.Add("ID Almacen", typeof(int));
                    table.Columns.Add(LanguageManager.GetString("TypeTravel"), typeof(string));
                    table.Columns.Add(LanguageManager.GetString("ShipmentDate"), typeof(DateTime));

                    fillDataTable(table, shipp);

                    dataGridViewShippments.DataSource = table;

                    MessageBox.Show(Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Messages.NotFound);
                }
            }
            else
            {
                MessageBox.Show(Messages.InvalidID);
            }
        }

        #region findbyStoreHouse

        private List<ShippmentsInterface> deserializeShippsStoreHouseID(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<ShippmentsInterface>>(content);
        }

        private static void fillDataTableStoreHouseData(DataTable table, ShippmentsInterface shipp)
        {
            DataRow row = table.NewRow();
            row["ID Destino"] = shipp.IDDestination;
            row["ID Almacen"] = shipp.IDStoreHouse;
            row[LanguageManager.GetString("TypeTravel")] = shipp.TypeTravel;
            row[LanguageManager.GetString("ShipmentDate")] = shipp.ShippmentDate;
            table.Rows.Add(row);
        }

        private void buttonSearchByStoreHouseID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxStoreHouseID.Text, out int searchID))
            {
                ShippmentsInterface shipp = shipmentsApiRequest.GetShippmentsByStoreHouseID(searchID);

                if (shipp != null)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Destino", typeof(int));
                    table.Columns.Add("ID Almacen", typeof(int));
                    table.Columns.Add(LanguageManager.GetString("TypeTravel"), typeof(string));
                    table.Columns.Add(LanguageManager.GetString("ShipmentDate"), typeof(DateTime));

                    fillDataTable(table, shipp);

                    dataGridViewShippments.DataSource = table;

                    MessageBox.Show(Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Messages.NotFound);
                }
            }
            else
            {
                MessageBox.Show(Messages.Error + ", " + Messages.InvalidID);
            }
        }
        #endregion findByStoreHouse

    }
}
