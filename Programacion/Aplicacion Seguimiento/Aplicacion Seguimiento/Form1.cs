using Aplicacion_Seguimiento.Forms;
using Aplicacion_Seguimiento.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Seguimiento
{
    public partial class Form1 : Form
    {

        public event Action LanguageChanged;

        public Form1()
        {
            LanguageManager.Initialize(typeof(Languages.Resource_language_english));
            LanguageManager.Initialize(typeof(Languages.Resource_language_spanish));
            InitializeComponent();
            customMenus();
            updateUI();
        }


        private void customMenus()
        {
            panelMyOrders.Visible = false;
        }

        private void hideMenus()
        {
            if (panelMyOrders.Visible == true)
            {
                panelMyOrders.Visible = false;
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

        private Form currentForm = null;

        private void showForm(Form newForm)
        {
            if (currentForm != null)
            {
                panelFormsLoader.Controls.Remove(currentForm);
                currentForm.Dispose();
            }

            currentForm = newForm;
            newForm.TopLevel = false;
            panelFormsLoader.Controls.Add(newForm);
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void showLocateBatchForm()
        {
            LocateBatchForm formLocateBatchCtl = new LocateBatchForm();
            showForm(formLocateBatchCtl);
        }

        private void showLocateProductForm()
        {
            LocateBatchWithProductIDForm formLocateBatchWithProductIDCtl = new LocateBatchWithProductIDForm();
            showForm(formLocateBatchWithProductIDCtl);
        }

        private void buttonTrackBatch_Click(object sender, EventArgs e)
        {
            showLocateBatchForm();
        }

        private void buttonMyOrders_Click(object sender, EventArgs e)
        {
            showMenus(panelMyOrders);
        }

        private void updateUI()
        {
            buttonTrackBatch.Text = Messages.LocateBatch;
            buttonMyOrders.Text = Messages.MyOrders;
            buttonLocateProduct.Text = Messages.LocateProduct;
        }

        private void buttonEnglishLanguage_Click(object sender, EventArgs e)
        {
            LanguageManager.Initialize(typeof(Languages.Resource_language_english));
            updateUI();
            LanguageChanged?.Invoke();
        }

        private void buttonLanguageSpanish_Click(object sender, EventArgs e)
        {
            LanguageManager.Initialize(typeof(Languages.Resource_language_spanish));
            updateUI();
            LanguageChanged?.Invoke();
        }

        private void buttonLocateProduct_Click(object sender, EventArgs e)
        {
            showLocateProductForm();
        }
    }
}
