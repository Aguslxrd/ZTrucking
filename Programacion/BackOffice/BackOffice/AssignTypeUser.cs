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
    public partial class AssignTypeUser : Form
    {

        public event Action LanguageChanged;

        public AssignTypeUser()
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
            buttonAddOperator.Text = LanguageManager.GetString("Add");
            buttonAddTrucker.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonDeleteOperator.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");

            labelOperator.Text = LanguageManager.GetString("Operator");
            labelTrucker.Text = LanguageManager.GetString("Trucker");
        }

        private void AssignTypeUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshTable()
        {
            DataTable dataTableUsersAssign = AssignTypeOfUserTruckerController.Obtener();
            dataGridViewUsers.DataSource = dataTableUsersAssign;

            DataTable dataTableUsersAssignOperator = AssignTypeOfUserOperatorController.Obtener();
            dataGridViewOperators.DataSource = dataTableUsersAssignOperator;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }


        private void buttonAddTrucker_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen<AddTruckerForm>())
            {
                AddTruckerForm addtruckercomponent = new AddTruckerForm();
                addtruckercomponent.Show();
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

        private void deleteUserTrucker()
        {
            try
            {
                if (dataGridViewUsers.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridViewUsers.SelectedRows[0].Index;
                    int id = (int)dataGridViewUsers.Rows[selectedIndex].Cells["ID"].Value;
                    DataTable dataTableUsers = (DataTable)dataGridViewUsers.DataSource;
                    dataTableUsers.Rows.RemoveAt(selectedIndex);
                    AssignTypeOfUserTruckerController.DeleteUser(id);
                    MessageBox.Show(Languages.Messages.Successful);
                    dataGridViewUsers.DataSource = dataTableUsers;
                    RefreshTable();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("(?) " + Messages.TruckerHasTruckAssigned);
            }

        }

        private void deleteUserOperator()
        {
            try
            {
                if (dataGridViewOperators.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridViewOperators.SelectedRows[0].Index;
                    int id = (int)dataGridViewOperators.Rows[selectedIndex].Cells["ID"].Value;
                    DataTable dataTableOperators = (DataTable)dataGridViewOperators.DataSource;
                    dataTableOperators.Rows.RemoveAt(selectedIndex);
                    AssignTypeOfUserOperatorController.DeleteUser(id);
                    MessageBox.Show(Languages.Messages.Successful);
                    dataGridViewOperators.DataSource = dataTableOperators;
                    RefreshTable();

                }
            }catch(Exception)
            {
                MessageBox.Show("(?) " + Messages.OperatorIsAssignedToAnStoreHouse);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteUserTrucker();
        }

        private void buttonAddOperator_Click(object sender, EventArgs e)
        {

            if (!IsFormOpen<AddOperatorForm>())
            {
                AddOperatorForm addoperatoromponent = new AddOperatorForm();
                addoperatoromponent.Show();
            }
            else
            {
                MessageBox.Show(Messages.Error);
            }
        }

        private void buttonDeleteOperator_Click(object sender, EventArgs e)
        {
            deleteUserOperator();
        }
    }
}
