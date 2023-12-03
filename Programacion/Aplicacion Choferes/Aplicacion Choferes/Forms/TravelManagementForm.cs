using Aplicacion_Almacen.Languages;
using Aplicacion_Choferes.ApiRequests;
using Aplicacion_Choferes.APIRequests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicacion_Choferes.Forms
{
    public partial class TravelManagementForm : Form
    {
        public event Action LanguageChanged;
        private ApiRequestTravels travelsApiRequest = new ApiRequestTravels("http://localhost:50294");

        public TravelManagementForm()
        {
            InitializeComponent();
            comboBoxStatusShipp.Items.Add("Entregado");
            comboBoxStatusShipp.Items.Add("En Camino");
            comboBoxStatusShipp.Items.Add("Retrasado");
            comboBoxStatusShipp.Items.Add("No Enviado");

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
            buttonChangeStatus.Text = LanguageManager.GetString("ChangeStatus");
            buttonSearch.Text = LanguageManager.GetString("Search");

            labelIDTruck.Text = LanguageManager.GetString("IDTruck");
            labelIDLotToAssign.Text = LanguageManager.GetString("LotIDToAssign");
            labelIDDestination.Text = LanguageManager.GetString("IDDestination");
            labelIDTrucker.Text = LanguageManager.GetString("IDTrucker");
            labelStatus.Text = LanguageManager.GetString("Status");
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<TravelsInterface> deserializeTravels(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<TravelsInterface>>(content);
        }

        private static void fillDataTable(DataTable table, TravelsInterface travels)
        {
            DataRow row = table.NewRow();
            row["ID Camión"] = travels.IDTruck;
            row["ID Lote"] = travels.IDBatch;
            row["ID Destino"] = travels.IDDestination;
            row["Posicion"] = travels.Position;
            row["Estado"] = travels.ShippingStatus;
            table.Rows.Add(row);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDTruck.Text, out int searchID))
            {
                TravelsInterface travel = travelsApiRequest.GetTravelByTruckID(searchID);

                if (travel != null)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Camión", typeof(int));
                    table.Columns.Add("ID Lote", typeof(string));
                    table.Columns.Add("ID Destino", typeof(int));
                    table.Columns.Add("Posicion", typeof(string));
                    table.Columns.Add("Estado", typeof(string));

                    fillDataTable(table, travel);

                    dataGridViewTravels.DataSource = table;

                    MessageBox.Show(Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Messages.NotFound);
                }
            }
            else
            {
                MessageBox.Show(Messages.Error + " " + Messages.InvalidID);
            }
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            if (!validateInputsUser())
            {
                MessageBox.Show(Messages.CompleteAllBoxAndStatus);
                return;
            }

            if (int.TryParse(txtBoxIDTruck.Text, out int truckID) &&
                int.TryParse(txtBoxIDBatch.Text, out int batchID) &&
                int.TryParse(txtBoxDestination.Text, out int destinationID) &&
                int.TryParse(txtBoxTruckerID.Text, out int truckerID))
            {
                string selectedStatus = comboBoxStatusShipp.SelectedItem as string;

                if (travelsApiRequest.EditTravel(selectedStatus, truckID))
                {
                    MessageBox.Show(Messages.Successful + ". ->" + selectedStatus);
                    clearTxtBoxs();
                }
                else
                {
                    MessageBox.Show("Http Error");
                }
            }
            else
            {
                MessageBox.Show(Messages.InvalidID + "'s");
            }
        }


        private bool validateInputsUser()
        {
            if (string.IsNullOrWhiteSpace(txtBoxIDBatch.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDTruck.Text) ||
                string.IsNullOrWhiteSpace(txtBoxDestination.Text) ||
                string.IsNullOrWhiteSpace(txtBoxTruckerID.Text))
            {
                return false;
            }

            return true;
        }

        private void clearTxtBoxs()
        {
            txtBoxIDBatch.Clear();
            txtBoxIDTruck.Clear();
            txtBoxDestination.Clear();
            txtBoxTruckerID.Clear();
        }


    }
}
