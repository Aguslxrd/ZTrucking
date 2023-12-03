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
    public partial class LocateBatchWithProductIDForm : Form
    {
        public event Action LanguageChanged;
        private ApiRequestGetBatchByProductID apiRequests;

        public LocateBatchWithProductIDForm()
        {
            InitializeComponent();
            Form1 mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestGetBatchByProductID("http://localhost:50294");
        }

        private void UpdateLanguage()
        {
            buttonSearchByProductID.Text = LanguageManager.GetString("Search");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");

            labelSearchByBatchID.Text = LanguageManager.GetString("ProductID");

        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<CustomerSearchByProductIDInterface> deserealizeOrder(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<CustomerSearchByProductIDInterface>>(content);
        }

        private static void fillDataTable(DataTable table, CustomerSearchByProductIDInterface batchorder)
        {
            DataRow rows = table.NewRow();
            rows["ID Producto"] = batchorder.ProductId;
            rows["ID Lote"] = batchorder.BatchId;
            rows["Calle"] = batchorder.StreetDestination;
            rows["Numero Puerta"] = batchorder.DoorNumber;
            rows["Estado"] = batchorder.BatchStatus;
            rows["Posicion"] = batchorder.Position;
            rows["Fecha Envio"] = batchorder.ShippmentDate;
            table.Rows.Add(rows);
        }

        private void buttonSearchByProductID_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxBatchID.Text, out int searchID))
                {
                    CustomerSearchByProductIDInterface batchByProductId = apiRequests.GetBatchByProductId(searchID);

                    if (batchByProductId != null)
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("ID Producto", typeof(int));
                        table.Columns.Add("ID Lote", typeof(int));
                        table.Columns.Add("Calle", typeof(string));
                        table.Columns.Add("Numero Puerta", typeof(string));
                        table.Columns.Add("Estado", typeof(string));
                        table.Columns.Add("Posicion", typeof(string));
                        table.Columns.Add("Fecha Envio", typeof(DateTime));

                        fillDataTable(table, batchByProductId);

                        dataGridViewSearchBatchByProductID.DataSource = table;

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
