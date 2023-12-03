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

namespace BackOffice
{
    public partial class QuickCarry : Form
    {
        public event Action LanguageChanged;

        public QuickCarry()
        {
            InitializeComponent();
            customMenus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUI()
        {
            buttonProducts.Text = LanguageManager.GetString("ProductAndLotDistribution");
            buttonAssignProducts.Text = LanguageManager.GetString("AssignProducts");
            buttonProductsManager.Text = LanguageManager.GetString("ManageProducts");
            buttonLotesManager.Text = LanguageManager.GetString("ManageLots");
            buttonManagement.Text = LanguageManager.GetString("Gerency");
            buttonDestinationManager.Text = LanguageManager.GetString("DestinationManager");
            buttonShippingManager.Text = LanguageManager.GetString("ManageShipments");
            ButtonStoreHouseManagement.Text = LanguageManager.GetString("ManageStoreHouse");
            buttonTrucksManager.Text = LanguageManager.GetString("ManageTrucks");
            buttonUsersManager.Text = LanguageManager.GetString("ManageUsers");
            buttonUsersAssign.Text = LanguageManager.GetString("AssignUser");
            buttonTravelManager.Text = LanguageManager.GetString("ManageTravels");
        }

        #region generalMenu
        private void customMenus()
        {
            managementPanel.Visible = false;
            productsAndLotsPanel.Visible = false;
        }

        private void hideMenus()
        {
            if (productsAndLotsPanel.Visible == true)
            {
                productsAndLotsPanel.Visible = false;
            }
            if (managementPanel.Visible == true)
            {
                managementPanel.Visible = false;
            }
        }

        private void showMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion
        #region leftButtonsAndPanel
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            showMenus(productsAndLotsPanel);
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            showMenus(managementPanel);
        }

        #endregion

        private void buttonProductsManager_Click(object sender, EventArgs e)
        {
            showProductsForm();

        }
        #region loadFormsOnPanel
        private void showProductsForm()
        {
            ProductsForm formProductCtl = new ProductsForm();
            formProductCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formProductCtl);
            formProductCtl.FormBorderStyle = FormBorderStyle.None;
            formProductCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formProductCtl;
            formProductCtl.BringToFront();
            formProductCtl.Show();
        }

        private void showAssignedProducts()
        {
            AssignProductsForm formAssignProductCtl = new AssignProductsForm();
            formAssignProductCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formAssignProductCtl);
            formAssignProductCtl.FormBorderStyle = FormBorderStyle.None;
            formAssignProductCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formAssignProductCtl;
            formAssignProductCtl.BringToFront();
            formAssignProductCtl.Show();
        }

        private void showUsers()
        {
            UsersForms formUsersCtl = new UsersForms();
            formUsersCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formUsersCtl);
            formUsersCtl.FormBorderStyle = FormBorderStyle.None;
            formUsersCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formUsersCtl;
            formUsersCtl.BringToFront();
            formUsersCtl.Show();
        }
        private void showTruckManager()
        {
            TruckManagerForm formTruckCtl = new TruckManagerForm();
            formTruckCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formTruckCtl);
            formTruckCtl.FormBorderStyle = FormBorderStyle.None;
            formTruckCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formTruckCtl;
            formTruckCtl.BringToFront();
            formTruckCtl.Show();

        }

        private void showUserTypeAssign()
        {
            AssignTypeUser formTruckCtl = new AssignTypeUser();
            formTruckCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formTruckCtl);
            formTruckCtl.FormBorderStyle = FormBorderStyle.None;
            formTruckCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formTruckCtl;
            formTruckCtl.BringToFront();
            formTruckCtl.Show();

        }

        private void buttonAssignProducts_Click(object sender, EventArgs e)
        {
            showAssignedProducts();
        }

        private void panelFormsLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUsersManager_Click(object sender, EventArgs e)
        {
            showUsers();
        }

        private void buttonTrucksManager_Click(object sender, EventArgs e)
        {
            showTruckManager();
        }

        private void buttonUsersAssign_Click(object sender, EventArgs e)
        {
            showUserTypeAssign();
        }

        private void ButtonStoreHouseManagement_Click(object sender, EventArgs e)
        {
            showStoreHouseManagementForm();
        }

        private void showStoreHouseManagementForm()
        {
            StoreHouse formStoreHouseCtl = new StoreHouse();
            formStoreHouseCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formStoreHouseCtl);
            formStoreHouseCtl.FormBorderStyle = FormBorderStyle.None;
            formStoreHouseCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formStoreHouseCtl;
            formStoreHouseCtl.BringToFront();
            formStoreHouseCtl.Show();
        }

        #endregion

        #region LotsButton
        private void buttonLotesManager_Click(object sender, EventArgs e)
        {
            showLotsForm();
        }

        private void showLotsForm()
        {
            LotsForm formLotsCtl = new LotsForm();
            formLotsCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formLotsCtl);
            formLotsCtl.FormBorderStyle = FormBorderStyle.None;
            formLotsCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formLotsCtl;
            formLotsCtl.BringToFront();
            formLotsCtl.Show();
        }

        #endregion

        private void showShippingManagerForm()
        {
            ShippingManagementForm formShippingManagerCtl = new ShippingManagementForm();
            formShippingManagerCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formShippingManagerCtl);
            formShippingManagerCtl.FormBorderStyle = FormBorderStyle.None;
            formShippingManagerCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formShippingManagerCtl;
            formShippingManagerCtl.BringToFront();
            formShippingManagerCtl.Show();
        }

        private void buttonShippingManager_Click(object sender, EventArgs e)
        {
            showShippingManagerForm();
        }

        private void showTravelManagerForm()
        {
            TravelManagerForm formTravelManagerCtl = new TravelManagerForm();
            formTravelManagerCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formTravelManagerCtl);
            formTravelManagerCtl.FormBorderStyle = FormBorderStyle.None;
            formTravelManagerCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formTravelManagerCtl;
            formTravelManagerCtl.BringToFront();
            formTravelManagerCtl.Show();
        }

        private void buttonTravelManager_Click(object sender, EventArgs e)
        {
            showTravelManagerForm();
        }

        private void showGmailForm()
        {
            GmailsForm formGmailFormCtl = new GmailsForm();
            formGmailFormCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formGmailFormCtl);
            formGmailFormCtl.FormBorderStyle = FormBorderStyle.None;
            formGmailFormCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formGmailFormCtl;
            formGmailFormCtl.BringToFront();
            formGmailFormCtl.Show();
        }

        private void buttonGmail_Click(object sender, EventArgs e)
        {
            showGmailForm();
        }

        private void panelSlider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLanguageSpanish_Click(object sender, EventArgs e)
        {
            LanguageManager.Initialize(typeof(Languages.Resource_language_spanish));
            UpdateUI();
            LanguageChanged?.Invoke();
        }

        private void buttonEnglishLanguage_Click(object sender, EventArgs e)
        {
            LanguageManager.Initialize(typeof(Languages.Resource_language_english));
            UpdateUI();
            LanguageChanged?.Invoke();
        }

        private void QuickCarry_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        #region destinationmanager

        private void showDestinationManagerForm()
        {
            DestinationForm forDestinationManagerCtl = new DestinationForm();
            forDestinationManagerCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(forDestinationManagerCtl);
            forDestinationManagerCtl.FormBorderStyle = FormBorderStyle.None;
            forDestinationManagerCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = forDestinationManagerCtl;
            forDestinationManagerCtl.BringToFront();
            forDestinationManagerCtl.Show();
        }

        private void buttonDestinationManager_Click(object sender, EventArgs e)
        {
            showDestinationManagerForm();
        }

        #endregion destinationmanagaer
    }
}
