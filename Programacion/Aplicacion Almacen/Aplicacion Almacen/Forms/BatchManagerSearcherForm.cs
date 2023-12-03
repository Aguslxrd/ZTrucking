using Aplicacion_Almacen.ApiRequests;
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
    public partial class BatchManagerSearcherForm : Form
    {

        public event Action LanguageChanged;
        public int m, x, y;
        private ApiRequestBatch apiRequests;

        public BatchManagerSearcherForm()
        {
            InitializeComponent();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestBatch("http://localhost:64191");
        }

        private void UpdateLanguage()
        {
            buttonSearchBatchByID.Text = LanguageManager.GetString("Search");
        }

        private void panelSlide_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            x = e.X;
            y = e.Y;
        }

        private void panelSlide_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchBatchByID_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxID.Text, out int searchID))
                {
                    BatchInterface batch = apiRequests.GetBatchById(searchID);

                    if (batch != null)
                    {
                        DataTable table = new DataTable();
                        table.Columns.Add("ID", typeof(int));
                        table.Columns.Add("Email", typeof(string));
                        table.Columns.Add(LanguageManager.GetString("DateOfCreation"), typeof(DateTime));
                        table.Columns.Add(LanguageManager.GetString("IDDestination"), typeof(int));
                        table.Columns.Add(LanguageManager.GetString("DateOfShipment"), typeof(DateTime));
                        table.Columns.Add(LanguageManager.GetString("Position"), typeof(string));
                        table.Columns.Add(LanguageManager.GetString("Activated"), typeof(bool));

                        fillDataTable(table, batch);

                        dataGridViewSearcher.DataSource = table;

                        MessageBox.Show(Messages.LotFound);
                    }
                    else
                    {
                        MessageBox.Show(Messages.LotNotFound);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.InvalidID);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private static void fillDataTable(DataTable table, BatchInterface batch)
        {
            DataRow rows = table.NewRow();
            rows["ID"] = batch.IDBatches;
            rows["Email"] = batch.Email;
            rows[LanguageManager.GetString("DateOfCreation")] = batch.DateOfCreation;
            rows[LanguageManager.GetString("IDDestination")] = batch.IDShipp;
            rows[LanguageManager.GetString("DateOfShipment")] = batch.ShippingDate;
            rows[LanguageManager.GetString("Position")] = batch.Position;
            rows[LanguageManager.GetString("Activated")] = batch.ActivedBatch;
            table.Rows.Add(rows);
        }

    }
}
