using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackOffice.crudForms;
using BackOffice.Languages;
using capa_logica;

namespace BackOffice
{
    public partial class AssignProductsForm : Form
    {

        public event Action LanguageChanged;

        public AssignProductsForm()
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
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");

        }

        private void AssignProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public void RefreshTable()
        {
            DataTable dataTableAssignedProducts = AssignProductsController.Obtener();
            dataGridViewAssignedProducts.DataSource = dataTableAssignedProducts;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen<AssignProductToBatchForm>())
            {
                AssignProductToBatchForm assignproducttobatchcomponent = new AssignProductToBatchForm();
                assignproducttobatchcomponent.Show();
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
            if (dataGridViewAssignedProducts.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAssignedProducts.SelectedRows[0].Index;
                int id = (int)dataGridViewAssignedProducts.Rows[selectedIndex].Cells["Lote ID"].Value;
                DataTable dataTableAssignedProduct = (DataTable)dataGridViewAssignedProducts.DataSource;
                dataTableAssignedProduct.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);
                AssignProductsController.DeleteAssignedProduct(id);
                dataGridViewAssignedProducts.DataSource = dataTableAssignedProduct;
                RefreshTable();

            }
        }

    }
}
