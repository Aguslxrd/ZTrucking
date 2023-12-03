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
    public partial class StoreHouse : Form
    {
        private int selectedStoreHouseID;
        public event Action LanguageChanged;

        public StoreHouse()
        {
            InitializeComponent();
            RefreshTableAddStoreHouse();
            RefreshTableAssignOperatorToStoreHouse();
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
            buttonAddStoreHouse.Text = LanguageManager.GetString("Add");
            buttonAddOperatorToStoreHouse.Text = LanguageManager.GetString("Add");
            buttonDeleteStoreHouse.Text = LanguageManager.GetString("Delete");
            buttonDeleteOperatorFromStoreHouse.Text = LanguageManager.GetString("Delete");
            buttonRefreshStoreHouse.Text = LanguageManager.GetString("Refresh");
            buttonRefreshAddOperatorStoreHouses.Text = LanguageManager.GetString("Refresh");
            buttonEditStoreHouse.Text = LanguageManager.GetString("Edit");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelAssignOperatorToStoreHouse.Text = LanguageManager.GetString("AssignOperatorToStoreHouse");
            labelAddStoreHouse.Text = LanguageManager.GetString("AddStoreHouse");
        }

        private void StoreHouse_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region AddStoreHouse

        public void RefreshTableAddStoreHouse()
        {
            DataTable dataTableStoreHouse = StoreHouseController.Obtener();
            dataGridViewStoreHouses.DataSource = dataTableStoreHouse;
        }

        private void buttonAddStoreHouse_Click(object sender, EventArgs e)
        {
            AddStoreHouseForm addstorehousecomponent = new AddStoreHouseForm();
            addstorehousecomponent.Show();
        }

        private void buttonRefreshStoreHouse_Click(object sender, EventArgs e)
        {
            RefreshTableAddStoreHouse();
        }
        #endregion AddStoreHouse

        #region AssignOperatorToStoreHouse

        public void RefreshTableAssignOperatorToStoreHouse()
        {
            DataTable dataTableAddOperatorToStoreHouse = AssignOperatorToStoreHouseController.GetAllOperatorsAssignedToStoreHouses();
            dataGridViewAddOperatorStoreHouse.DataSource = dataTableAddOperatorToStoreHouse;
        }

        private void deleteAssignedOperatorToStoreHouse()
        {
            if (dataGridViewAddOperatorStoreHouse.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAddOperatorStoreHouse.SelectedRows[0].Index;
                int id = (int)dataGridViewAddOperatorStoreHouse.Rows[selectedIndex].Cells["ID Operario"].Value;
                DataTable dataTableAssignedOperators = (DataTable)dataGridViewAddOperatorStoreHouse.DataSource;
                dataTableAssignedOperators.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);
                AssignOperatorToStoreHouseController.DeleteAssignedOperator(id);
                dataGridViewAddOperatorStoreHouse.DataSource = dataTableAssignedOperators;
                RefreshTableAddStoreHouse();

            }
        }

        private void buttonAddOperatorToStoreHouse_Click(object sender, EventArgs e)
        {
            AssignOperatorToStoreHouseForm assignoperatortostorehousecomponent = new AssignOperatorToStoreHouseForm();
            assignoperatortostorehousecomponent.Show();
        }

        private void buttonDeleteOperatorFromStoreHouse_Click(object sender, EventArgs e)
        {
            deleteAssignedOperatorToStoreHouse();
        }

        private void buttonRefreshAddOperatorStoreHouses_Click(object sender, EventArgs e)
        {
            RefreshTableAssignOperatorToStoreHouse();
        }

        #endregion AssignOperatorToStoreHouse


        private void buttonEditStoreHouse_Click(object sender, EventArgs e)
        {
            EditStoreHouseForm editstorehousecomponent = new EditStoreHouseForm();
            editstorehousecomponent.Show();
        }
        
        private void dataGridViewStoreHouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                selectedStoreHouseID = (int)dataGridViewStoreHouses.Rows[e.RowIndex].Cells["id"].Value;
            }
        }

        private void buttonDeleteStoreHouse_Click(object sender, EventArgs e)
        {
            if (dataGridViewStoreHouses.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewStoreHouses.SelectedRows[0].Index;
                int id = (int)dataGridViewStoreHouses.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableStoreHouses = (DataTable)dataGridViewStoreHouses.DataSource;
                dataTableStoreHouses.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);

                StoreHouseController.DeleteStoreHouse(id);
                dataGridViewStoreHouses.DataSource = dataTableStoreHouses;
                Refresh();

            }
        }

    }
}
