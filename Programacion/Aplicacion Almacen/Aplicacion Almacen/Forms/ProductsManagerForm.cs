using Aplicacion_Almacen.APIRequests;
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
    public partial class ProductsManagerForm : Form
    {
        private ApiRequestProduct apiRequests;

        public event Action LanguageChanged;
        private string jsonBody;

        public ProductsManagerForm()
        {
            InitializeComponent();
            refreshTable();

            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }

            apiRequests = new ApiRequestProduct("http://localhost:64191");

        }
        private void updateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonEdit.Text = LanguageManager.GetString("Edit");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
            buttonSearchByID.Text = LanguageManager.GetString("Searcher");
            buttonViewMap.Text = LanguageManager.GetString("ViewMap");

        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsManagerForm_Load(object sender, EventArgs e)
        {

        }

        #region getProductsFromAPI
        private List<ProductInterface> deserializeProduct(string content)
        {
            if (content == null)
            {
                return null;
            }
            return JsonConvert.DeserializeObject<List<ProductInterface>>(content);
        }

        private static RestResponse getProductsFromApi()
        {
            RestClient client = new RestClient("http://localhost:64191");
            RestRequest request = new RestRequest("/api/v1/productos", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);
            return response;
        }

        private static void fillDataTable(DataTable table, ProductInterface product)
        {
            DataRow row = table.NewRow();
            row["ID"] = product.IDProduct;
            row[LanguageManager.GetString("Weight")] = product.ProductWeight;
            row[LanguageManager.GetString("Volume")] = product.Volume;
            row[LanguageManager.GetString("Street")] = product.Street;
            row[LanguageManager.GetString("Number")] = product.DoorNumber;
            row[LanguageManager.GetString("Corner")] = product.Corner;
            row[LanguageManager.GetString("Customer")] = product.Customer;
            row[LanguageManager.GetString("Activated")] = product.ActivatedProduct;
            table.Rows.Add(row);
        }


        private DataTable getDataTable()
        {
            RestResponse response = getProductsFromApi();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add(LanguageManager.GetString("Weight"), typeof(string));
            table.Columns.Add(LanguageManager.GetString("Volume"), typeof(int));
            table.Columns.Add(LanguageManager.GetString("Street"), typeof(string));
            table.Columns.Add(LanguageManager.GetString("Number"), typeof(int));
            table.Columns.Add(LanguageManager.GetString("Corner"), typeof(string));
            table.Columns.Add(LanguageManager.GetString("Customer"), typeof(string));
            table.Columns.Add(LanguageManager.GetString("Activated"), typeof(bool));

            foreach (ProductInterface product in deserializeProduct(response.Content))
            {
                fillDataTable(table, product);
            }

            return table;
        }


        private void refreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewProducts.DataSource = table;
        }

        #endregion getProductsFromAPI

        #region postProductsToAPI

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen<AddProductForm>())
            {
                AddProductForm addproductcomponent = new AddProductForm();
                addproductcomponent.Show();
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
        #endregion postProductsToAPI

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditProductForm editproductcomponent = new EditProductForm();
            editproductcomponent.Show();
        }

        #region deleteProductsFromAPI

        private bool deleteProductFromApi(int productId)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest($"/api/v1/productos/{productId}", Method.Delete);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(Messages.Error + " : " + response.StatusCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Messages.Error + " : " + ex.Message);
                return false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];

                int productIdToDelete = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                if (deleteProductFromApi(productIdToDelete))
                {
                    refreshTable();
                    MessageBox.Show(Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
                }
            }
            else
            {
                MessageBox.Show(Messages.SelectAnIndex);
            }
        }

        #endregion deleteProductsFromAPI

        #region validationsAndUtils
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
        }
        #endregion validationsAndUtils

        #region searcher
        private void buttonSearchByID_Click(object sender, EventArgs e)
        {
            ProductManagerSearcherForm searcherForm = new ProductManagerSearcherForm();
            searcherForm.Show();
        }
        #endregion searcher

        private void buttonViewMap_Click(object sender, EventArgs e)
        {
            MapForm viewMap = new MapForm();
            viewMap.Show();
        }
    }

}
