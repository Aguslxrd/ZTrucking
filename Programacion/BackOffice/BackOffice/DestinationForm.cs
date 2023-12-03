using BackOffice.crudForms;
using BackOffice.Languages;
using capa_logica;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class DestinationForm : Form
    {

        public event Action LanguageChanged;

        public DestinationForm()
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
            buttonAddDestination.Text = LanguageManager.GetString("Add");
            buttonDeleteDestination.Text = LanguageManager.GetString("Delete");
            buttonRefreshDestination.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");
            buttonShowMap.Text = LanguageManager.GetString("Map");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DestinationForm_Load(object sender, EventArgs e)
        {

        }

        #region Destination

        public void RefreshTable()
        {
            DataTable dataTableDestination = DestinationController.GetAllDestinations();
            dataGridViewDestinations.DataSource = dataTableDestination;
        }

        private void deleteDestination()
        {
            if (dataGridViewDestinations.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewDestinations.SelectedRows[0].Index;
                int id = (int)dataGridViewDestinations.Rows[selectedIndex].Cells["ID"].Value;
                DataTable dataTableDestinations = (DataTable)dataGridViewDestinations.DataSource;
                dataTableDestinations.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);
                DestinationController.DeleteDestination(id);
                dataGridViewDestinations.DataSource = dataTableDestinations;
                RefreshTable();

            }
        }

        private void buttonAddDestination_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen<AddDestinationForm>())
            {
                AddDestinationForm adddestinationcomponent = new AddDestinationForm();
                adddestinationcomponent.Show();
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

        private void buttonRefreshDestination_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }


        private void buttonDeleteDestination_Click(object sender, EventArgs e)
        {
            deleteDestination();
        }
        

        #endregion Destination

        private void buttonEditDestination_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen<EditDestinationForm>())
            {
                EditDestinationForm editestinationcomponent = new EditDestinationForm();
                editestinationcomponent.Show();
            }
            else
            {
                MessageBox.Show(Messages.Error);
            }
        }

        private void dataGridViewDestinations_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDestinations_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowMap_Click(object sender, EventArgs e)
        {
            MapForm viewMap = new MapForm();
            viewMap.Show();
        }
    }
}
