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
    public partial class TruckManagerForm : Form
    {

        public event Action LanguageChanged;

        public TruckManagerForm()
        {
            InitializeComponent();
            RefreshTableTruck();
            RefreshTableTrucker();
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
            buttonAddAssignedTruck.Text = LanguageManager.GetString("Add");
            buttonAddTruck.Text = LanguageManager.GetString("Add");
            buttonDeleteAssignedTruck.Text = LanguageManager.GetString("Delete");
            buttonDeleteTruck.Text = LanguageManager.GetString("Delete");
            buttonRefreshAssignTrucker.Text = LanguageManager.GetString("Refresh");
            buttonRefreshTruck.Text = LanguageManager.GetString("Refresh");
            buttonEdit.Text = LanguageManager.GetString("Edit");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelAssignTruck.Text = LanguageManager.GetString("AssignTruck");
            labelAddTruck.Text = LanguageManager.GetString("AddTruck");

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TruckManagerForm_Load(object sender, EventArgs e)
        {

        }

        public void RefreshTableTruck()
        {
            DataTable dataTableTruck = TruckController.GetAllTrucks();
            dataGridViewAddTruck.DataSource = dataTableTruck;
        }

        private void buttonRefreshTruck_Click(object sender, EventArgs e)
        {
            RefreshTableTruck();
        }

        private void buttonAddTruck_Click(object sender, EventArgs e)
        {
            AddTruckForm addtruckcomponent = new AddTruckForm();
            addtruckcomponent.Show();
        }

        private void buttonDeleteTruck_Click(object sender, EventArgs e)
        {
            if (dataGridViewAddTruck.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAddTruck.SelectedRows[0].Index;
                int id = (int)dataGridViewAddTruck.Rows[selectedIndex].Cells["Camion ID"].Value;

                if (id > 0)
                {
                    DataTable dataTableTruckSelected = (DataTable)dataGridViewAddTruck.DataSource;
                    dataTableTruckSelected.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show(Languages.Messages.Successful);
                    TruckController.DeleteTruck(id);
                    dataGridViewAddTruck.DataSource = dataTableTruckSelected;
                    RefreshTableTruck();
                }
                else
                {
                    MessageBox.Show(Languages.Messages.SelectAnIndex);
                }
            }
            else
            {
                MessageBox.Show(Languages.Messages.SelectAnIndex);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditTruckForm edittruckcomponent = new EditTruckForm();
            edittruckcomponent.Show();
        }

        #region trucker
        public void RefreshTableTrucker()
        {
            DataTable dataTableTrucker = TruckerController.GetAllTruckers();
            dataGridViewAssignTruck.DataSource = dataTableTrucker;
        }

        private void buttonRefreshAssignTrucker_Click(object sender, EventArgs e)
        {
            RefreshTableTrucker();
        }

        private void buttonAddAssignedTruck_Click(object sender, EventArgs e)
        {
            AssignTruckToTruckerForm assigntrucktotruckcomponent = new AssignTruckToTruckerForm();
            assigntrucktotruckcomponent.Show();
        }


        private void buttonDeleteAssignedTruck_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssignTruck.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAssignTruck.SelectedRows[0].Index;
                int id = (int)dataGridViewAssignTruck.Rows[selectedIndex].Cells["Conductor ID"].Value;

                if (id > 0)
                {
                    DataTable dataTableTruckerSelected = (DataTable)dataGridViewAssignTruck.DataSource;
                    dataTableTruckerSelected.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show(Languages.Messages.Successful);
                    TruckerController.DeleteTrucker(id);
                    dataGridViewAssignTruck.DataSource = dataTableTruckerSelected;
                    RefreshTableTrucker();
                }
                else
                {
                    MessageBox.Show(Languages.Messages.SelectAnIndex);
                }
            }
            else
            {
                MessageBox.Show(Languages.Messages.SelectAnIndex);
            }
        }

        #endregion trucker
    }
}
