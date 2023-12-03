using Aplicacion_Almacen.ApiRequests;
using Aplicacion_Almacen.Forms.crudForms;
using Aplicacion_Almacen.Languages;
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
    public partial class BatchManagerForm : Form
    {
        public event Action LanguageChanged;
        private string jsonBody;
        private ApiRequestBatch apiRequests;

        public BatchManagerForm()
        {
            InitializeComponent();
            refreshTable();

            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestBatch("http://localhost:64191");
        }

        private void UpdateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDestinationList.Text = LanguageManager.GetString("ViewDestinations");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
            buttonSearcher.Text = LanguageManager.GetString("Searcher");
            buttonViewMap.Text = LanguageManager.GetString("ViewMap");
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region getBatchsFromAPI
        private List<BatchInterface> deserializeBatch(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<BatchInterface>>(content);
        }


        private DataTable getDataTable()
        {
            ApiRequestBatch apiRequest = new ApiRequestBatch("http://localhost:64191");
            List<BatchInterface> batchCreated = apiRequest.GetBatchs();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add(LanguageManager.GetString("DateOfCreation"), typeof(DateTime));
            table.Columns.Add(LanguageManager.GetString("IDDestination"), typeof(int));
            table.Columns.Add(LanguageManager.GetString("DateOfShipment"), typeof(DateTime));
            table.Columns.Add(LanguageManager.GetString("Position"), typeof(string));
            table.Columns.Add(LanguageManager.GetString("Activated"), typeof(bool));

            foreach (BatchInterface batch in batchCreated)
            {
                DataRow row = table.NewRow();
                row["ID"] = batch.IDBatches;
                row["Email"] = batch.Email;
                row[LanguageManager.GetString("DateOfCreation")] = batch.DateOfCreation;
                row[LanguageManager.GetString("IDDestination")] = batch.IDShipp;
                row[LanguageManager.GetString("DateOfShipment")] = batch.ShippingDate;
                row[LanguageManager.GetString("Position")] = batch.Position;
                row[LanguageManager.GetString("Activated")] = batch.ActivedBatch;
                table.Rows.Add(row);
            }
            return table;
        }

        private static void fillDataTable(DataTable table, BatchInterface batch)
        {
            DataRow rows = table.NewRow();
            rows["ID"] = batch.IDBatches;
            rows["Email"] = batch.Email;
            rows[LanguageManager.GetString("DateOfCreation")] = batch.DateOfCreation;
            rows[LanguageManager.GetString("IDDestination")] = batch.IDShipp;
            rows[LanguageManager.GetString("DateOfShipment")] = batch.ShippingDate;
            rows[LanguageManager.GetString("Position")] = batch.ShippingDate;
            rows[LanguageManager.GetString("Activated")] = batch.ActivedBatch;
            table.Rows.Add(rows);
        }

        private void refreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewBatch.DataSource = table;
        }
        #endregion getBatchsFromAPI

        #region postBatchsToAPI

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen<AddBatchForm>())
            {
                AddBatchForm addbatchcomponent = new AddBatchForm();
                addbatchcomponent.Show();
            }
            else
            {
                MessageBox.Show(Messages.Error);
            }
        }

        private bool IsFormOpen<T>() where T : Form
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    return true;
                }
            }
            return false;
        }

        #endregion postBatchsToAPI

        #region deleteBatchFromAPI

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBatch.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.SelectAnIndex);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewBatch.SelectedRows[0];

            if (selectedRow.Cells["ID"].Value == null || !int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out int batchIdToDelete))
            {
                MessageBox.Show(Messages.InvalidID);
                return;
            }

            if (apiRequests.DeleteBatch(batchIdToDelete))
            {
                refreshTable();
                MessageBox.Show(Messages.Successful);
            }
            else
            {
                MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
            }
        }

        #endregion deleteBatchFromAPI

        #region validationsAndUtils

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void dataGridViewBatch_SelectionChanged(object sender, EventArgs e)
        {
        }

        #endregion validationsAndUtils

        private void buttonSearcher_Click(object sender, EventArgs e)
        {
            BatchManagerSearcherForm searcherForm = new BatchManagerSearcherForm();
            searcherForm.Show();
        }

        private void BatchManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDestinationList_Click(object sender, EventArgs e)
        {
            DestinationListForm getAllDestinationsForm = new DestinationListForm();
            getAllDestinationsForm.Show();
        }

        private void buttonViewMap_Click(object sender, EventArgs e)
        {
            MapForm viewMap = new MapForm();
            viewMap.Show();
        }
    }
}
