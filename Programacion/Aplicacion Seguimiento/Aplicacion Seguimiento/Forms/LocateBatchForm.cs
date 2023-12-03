using Aplicacion_Seguimiento.ApiRequests;
using Aplicacion_Seguimiento.Interfaces;
using Aplicacion_Seguimiento.Languages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Seguimiento.Forms
{
    public partial class LocateBatchForm : Form
    {

        public event Action LanguageChanged;
        private ApiRequestGetBatchByID apiRequests;

        public LocateBatchForm()
        {
            InitializeComponent();
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestGetBatchByID("http://localhost:50294");
        }

        private void UpdateLanguage()
        {
            buttonSearchByBatchID.Text = LanguageManager.GetString("Search");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");

            labelSearchByBatchID.Text = LanguageManager.GetString("LotID");

        }

        private List<CustomerSearchByBatchIDInterface> deserealizeOrder(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<CustomerSearchByBatchIDInterface>>(content);
        }

        private static void fillDataTable(DataTable table, CustomerSearchByBatchIDInterface batchorder)
        {
            DataRow rows = table.NewRow();
            rows["ID Lote"] = batchorder.BatchId;
            rows["Calle"] = batchorder.StreetDestination;
            rows["Numero Puerta"] = batchorder.DoorNumber;
            rows["Estado"] = batchorder.BatchStatus;
            rows["Posicion"] = batchorder.Position;
            rows["Fecha Envio"] = batchorder.ShippmentDate;
            table.Rows.Add(rows);
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchByBatchID_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxBatchID.Text, out int searchID))
                {
                    CustomerSearchByBatchIDInterface batch = apiRequests.GetBatchById(searchID);

                    if (batch != null)
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("ID Lote", typeof(int));
                        table.Columns.Add("Calle", typeof(string));
                        table.Columns.Add("Numero Puerta", typeof(string));
                        table.Columns.Add("Estado", typeof(string));
                        table.Columns.Add("Posicion", typeof(string));
                        table.Columns.Add("Fecha Envio", typeof(DateTime));

                        fillDataTable(table, batch);

                        dataGridViewSearchByBatchID.DataSource = table;

                        MessageBox.Show(Messages.Successful);
                    }
                    else
                    {
                        MessageBox.Show(Messages.LotNotFound);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.InvalidID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
