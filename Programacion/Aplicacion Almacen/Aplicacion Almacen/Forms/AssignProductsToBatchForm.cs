using Aplicacion_Almacen.ApiRequests;
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
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen.Forms
{
    public partial class AssignProductsToBatchForm : Form
    {
        public event Action LanguageChanged;
        private string jsonBody;
        private ApiRequestAssignProductToBatch apiRequests;

        public AssignProductsToBatchForm()
        {
            InitializeComponent();
            refreshTable();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestAssignProductToBatch("http://localhost:64191");
            roundedCircleForm();
        }

        private void UpdateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
        }

        private void roundedCircleForm()
        {
            int radiusBorder = 25;

            Rectangle rectangleBorder = new Rectangle(0, 0, this.Width, this.Height);

            GraphicsPath graphicBorder = new GraphicsPath();
            graphicBorder.AddArc(rectangleBorder.X, rectangleBorder.Y, radiusBorder, radiusBorder, 180, 90);
            graphicBorder.AddArc(rectangleBorder.Right - radiusBorder, rectangleBorder.Y, radiusBorder, radiusBorder, 270, 90);
            graphicBorder.AddArc(rectangleBorder.Right - radiusBorder, rectangleBorder.Bottom - radiusBorder, radiusBorder, radiusBorder, 0, 90);
            graphicBorder.AddArc(rectangleBorder.X, rectangleBorder.Bottom - radiusBorder, radiusBorder, radiusBorder, 90, 90);
            graphicBorder.CloseAllFigures();

            this.Region = new Region(graphicBorder);
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region getBatchsFromAPI
        private List<AssignProductsToBatchInterface> deserializeAssignedProductToBatch(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<AssignProductsToBatchInterface>>(content);
        }

        private static void fillDataTable(DataTable table, AssignProductsToBatchInterface assignedproduct)
        {
            DataRow rows = table.NewRow();
            rows[LanguageManager.GetString("LotID")] = assignedproduct.IDBatch;
            rows["ID Product"] = assignedproduct.IDProduct;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            ApiRequestAssignProductToBatch apiRequest = new ApiRequestAssignProductToBatch("http://localhost:64191");
            List<AssignProductsToBatchInterface> batchAssigned = apiRequest.GetAssignedProductsToBatch();

            DataTable table = new DataTable();
            table.Columns.Add(LanguageManager.GetString("LotID"), typeof(int));
            table.Columns.Add("ID Product", typeof(int));

            foreach (AssignProductsToBatchInterface batch in batchAssigned)
            {
                DataRow row = table.NewRow();
                row[LanguageManager.GetString("LotID")] = batch.IDBatch;
                row["ID Product"] = batch.IDProduct;
                table.Rows.Add(row);
            }
            return table;
        }

        private void refreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewAssignedProducts.DataSource = table;
        }
        #endregion getBatchsFromAPI

        #region postAssignedProductToAPI

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen<IntegrateProductToBatchForm>())
            {
                IntegrateProductToBatchForm integrateproudcttobatchform = new IntegrateProductToBatchForm();
                integrateproudcttobatchform.Show();
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

        #endregion postAssignedProductToAPI

        #region deleteAssignedProductToAPI

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssignedProducts.SelectedRows.Count > 0)
            {
                int assignedProductIdToDelete = Convert.ToInt32(dataGridViewAssignedProducts.SelectedRows[0].Cells["ID Product"].Value);

                if (apiRequests.DeleteAssignedProductToBatch(assignedProductIdToDelete))
                {
                    refreshTable();
                    MessageBox.Show(Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Messages.Error + " " + Messages.VerifyData);
                }
            }
            else
            {
                MessageBox.Show(Messages.SelectAnIndex);
            }
        }


        #endregion deleteAssignedProductToAPI

        #region validationsAndUtils

        

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void dataGridViewAssignedProducts_SelectionChanged(object sender, EventArgs e)
        {

        }

        #endregion validationsAndUtils


    }
}
