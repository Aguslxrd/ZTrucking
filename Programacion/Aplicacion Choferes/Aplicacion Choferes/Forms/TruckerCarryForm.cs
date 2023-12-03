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
    public partial class TruckerCarryForm : Form
    {
        public event Action LanguageChanged;
        private ApiRequestTruckerCarry truckCarryApiRequest = new ApiRequestTruckerCarry("http://localhost:50294");


        public TruckerCarryForm()
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
            buttonSearchByTruckerID.Text = LanguageManager.GetString("Search");

            labelIDTrucker.Text = LanguageManager.GetString("IDTruck");

        }

        private List<TruckerCarryInterface> deserialize(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<TruckerCarryInterface>>(content);
        }

        private static void fillDataTable(DataTable table, TruckerCarryInterface carry)
        {
            DataRow row = table.NewRow();
            row["ID Camion"] = carry.IDTruck;
            row["Lote ID"] = carry.IDBatch;
            row["Posicion"] = carry.Position;
            row["Fecha Envio"] = carry.ShippmentDate;
            table.Rows.Add(row);
        }

        private void buttonSearchByTruckerID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxIDTrucker.Text, out int searchID))
            {
                TruckerCarryInterface carrie = truckCarryApiRequest.GetTruckCarryByID(searchID);

                if (carrie != null)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID Camion", typeof(int));
                    table.Columns.Add("Lote ID", typeof(int));
                    table.Columns.Add("Posicion", typeof(string));
                    table.Columns.Add("Fecha Envio", typeof(DateTime));

                    fillDataTable(table, carrie);

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

    }
}
