using BackOffice.crudForms;
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
    public partial class ShippingManagementForm : Form
    {
        public event Action LanguageChanged;

        public ShippingManagementForm()
        {
            InitializeComponent();
            RefreshTableShippManagement();
            RefreshTableCarrieManagement();

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
            buttonAddCarry.Text = LanguageManager.GetString("Add");
            buttonAddShipp.Text = LanguageManager.GetString("Add");
            buttonDeleteCarry.Text = LanguageManager.GetString("Delete");
            buttonDeleteShipp.Text = LanguageManager.GetString("Delete");
            buttonRefreshCarry.Text = LanguageManager.GetString("Refresh");
            buttonRefreshShipps.Text = LanguageManager.GetString("Refresh");
            buttonEditCarry.Text = LanguageManager.GetString("Edit");
            buttonBack.Text = LanguageManager.GetString("Back");
        }

        private void ShippingManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region shippmanagement
        public void RefreshTableShippManagement()
        {
            DataTable dataTableShippManagement = ShippingManagementController.GetAllShippings();
            dataGridViewShippingManagement.DataSource = dataTableShippManagement;
        }

        private void deleteShippment()
        {
            if (dataGridViewShippingManagement.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewShippingManagement.SelectedRows[0].Index;
                int id = (int)dataGridViewShippingManagement.Rows[selectedIndex].Cells["ID Lote"].Value;
                DataTable dataTableShippings = (DataTable)dataGridViewShippingManagement.DataSource;
                dataTableShippings.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);
                ShippingManagementController.DeleteShipp(id);
                dataGridViewShippingManagement.DataSource = dataTableShippings;
                RefreshTableShippManagement();

            }
        }

        private void buttonAddShipp_Click(object sender, EventArgs e)
        {
            AssignBatchToTruckForm assignbatchtotruckcomponent = new AssignBatchToTruckForm();
            assignbatchtotruckcomponent.Show();
        }

        private void buttonDeleteShipp_Click(object sender, EventArgs e)
        {
            deleteShippment();
        }

        private void buttonRefreshShipps_Click(object sender, EventArgs e)
        {
            RefreshTableShippManagement();
        }

        #endregion shippmanagement

        #region Carries
        public void RefreshTableCarrieManagement()
        {
            DataTable dataTableCarrieManagement = CarryShippmentController.GetAllCarrys();
            dataGridViewCarry.DataSource = dataTableCarrieManagement;
        }

        private void deleteCarrie()
        {
            if (dataGridViewCarry.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewCarry.SelectedRows[0].Index;
                int id = (int)dataGridViewCarry.Rows[selectedIndex].Cells["ID Camion"].Value;
                DataTable dataTableCarries = (DataTable)dataGridViewCarry.DataSource;
                dataTableCarries.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);
                CarryShippmentController.DeleteCarry(id);
                dataGridViewCarry.DataSource = dataTableCarries;
                RefreshTableCarrieManagement();

            }
        }

        private void buttonAddCarry_Click(object sender, EventArgs e)
        {
            AddCarrieForm addcarriecomponent = new AddCarrieForm();
            addcarriecomponent.Show();
        }

        private void buttonDeleteCarry_Click(object sender, EventArgs e)
        {
            deleteCarrie();
        }

        private void buttonRefreshCarry_Click(object sender, EventArgs e)
        {
            RefreshTableCarrieManagement();
        }

        #endregion Carries

        private void buttonEditCarry_Click(object sender, EventArgs e)
        {
            EditCarrieForm editcarriecomponent = new EditCarrieForm();
            editcarriecomponent.Show();
        }
    }
}
