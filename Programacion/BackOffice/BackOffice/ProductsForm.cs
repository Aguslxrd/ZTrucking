using BackOffice.crudForms;
using BackOffice.Languages;
using capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class ProductsForm : Form
    {

        public event Action LanguageChanged;

        public ProductsForm()
        {
            InitializeComponent();
            RefreshTable();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_english));
        }

        private void updateLanguage()
        {
            buttonAddProduct.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }
        public void RefreshTable()
        {
            DataTable dataTableProducts = ProductController.Obtener();
            dataGridViewProducts.DataSource = dataTableProducts;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }


        private void buttonAddProduct_Click(object sender, EventArgs e)
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


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteProduct();
        }

        private void deleteProduct()
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewProducts.SelectedRows[0].Index;
                int id = (int)dataGridViewProducts.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableProducts = (DataTable)dataGridViewProducts.DataSource;
                dataTableProducts.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);

                ProductController.EliminarProducto(id);
                dataGridViewProducts.DataSource = dataTableProducts;
                RefreshTable();

            }
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
