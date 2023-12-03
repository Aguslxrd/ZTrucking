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
    public partial class TravelManagerForm : Form
    {

        public event Action LanguageChanged;

        public TravelManagerForm()
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");
        }

        public void RefreshTable()
        {
            DataTable dataTableTravel = TravelController.GetAllTravels();
            dataGridViewTravels.DataSource = dataTableTravel;
        }


        private void TravelManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTravelForm addtravelcomponent = new AddTravelForm();
            addtravelcomponent.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTravels.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewTravels.SelectedRows[0].Index;
                int id = (int)dataGridViewTravels.Rows[selectedIndex].Cells["ID Almacen"].Value;
                DataTable dataTableCarries = (DataTable)dataGridViewTravels.DataSource;
                dataTableCarries.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El recorrido fue eliminado!");
                TravelController.DeleteTravel(id);
                dataGridViewTravels.DataSource = dataTableCarries;
                RefreshTable();

            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
