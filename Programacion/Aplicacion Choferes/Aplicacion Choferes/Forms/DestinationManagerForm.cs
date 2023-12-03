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
    public partial class DestinationManagerForm : Form
    {
        public event Action LanguageChanged;
        private ApiRequestDestinations destinationApiRequest = new ApiRequestDestinations("http://localhost:50294");


        public DestinationManagerForm()
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

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateLanguage()
        {
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
            buttonSearchByDestinationID.Text = LanguageManager.GetString("Search");
            buttonGetAllDestinations.Text = LanguageManager.GetString("ViewDestinations");

            labelIDDestination.Text = LanguageManager.GetString("IDDestination");

        }

        private List<DestinationInterface> deserialize(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<DestinationInterface>>(content);
        }

        private static void fillDataTable(DataTable table, DestinationInterface destination)
        {
            DataRow row = table.NewRow();
            row["ID"] = destination.IDDestination;
            row[LanguageManager.GetString("Street")] = destination.StreetDestination;
            row[LanguageManager.GetString("Number")] = destination.DoorNumber;
            row[LanguageManager.GetString("Corner")] = destination.CornerDestination;
            row[LanguageManager.GetString("EstimatedDate")] = destination.EstimatedDate;
            row[LanguageManager.GetString("Activated")] = destination.ActivedDestination;
            table.Rows.Add(row);
        }

        private void buttonSearchByDestinationID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDDestination.Text, out int searchID))
            {
                DestinationInterface destination = destinationApiRequest.GetDestinationByID(searchID);

                if (destination != null)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add(LanguageManager.GetString("Street"), typeof(string));
                    table.Columns.Add(LanguageManager.GetString("Number"), typeof(string));
                    table.Columns.Add(LanguageManager.GetString("Corner"), typeof(string));
                    table.Columns.Add(LanguageManager.GetString("EstimatedDate"), typeof(DateTime));
                    table.Columns.Add(LanguageManager.GetString("Activated"), typeof(bool));

                    fillDataTable(table, destination);

                    dataGridViewDestination.DataSource = table;

                    MessageBox.Show(Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Messages.Error + ", " + Messages.NotFound);
                }
            }
            else
            {
                MessageBox.Show(Messages.InvalidID);
            }
        }


        #region getAllDestinations

        private void fillDataTableWithDestinations(DataTable table, List<DestinationInterface> destinations)
        {
            foreach (var destination in destinations)
            {
                DataRow row = table.NewRow();
                row["ID"] = destination.IDDestination;
                row[LanguageManager.GetString("Street")] = destination.StreetDestination;
                row[LanguageManager.GetString("Number")] = destination.DoorNumber;
                row[LanguageManager.GetString("Corner")] = destination.CornerDestination;
                row[LanguageManager.GetString("EstimatedDate")] = destination.EstimatedDate;
                row[LanguageManager.GetString("Activated")] = destination.ActivedDestination;
                table.Rows.Add(row);
            }
        }

        private void buttonGetAllDestinations_Click(object sender, EventArgs e)
        {
            List<DestinationInterface> destinations = destinationApiRequest.GetAllDestinations();

            if (destinations != null)
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add(LanguageManager.GetString("Street"), typeof(string));
                table.Columns.Add(LanguageManager.GetString("Number"), typeof(string));
                table.Columns.Add(LanguageManager.GetString("Corner"), typeof(string));
                table.Columns.Add(LanguageManager.GetString("EstimatedDate"), typeof(DateTime));
                table.Columns.Add(LanguageManager.GetString("Activated"), typeof(bool));

                fillDataTableWithDestinations(table, destinations);

                dataGridViewDestination.DataSource = table;
            }
            else
            {
                MessageBox.Show(Messages.NotFound);
            }
        }

        #endregion getAlldestination
    }
}
