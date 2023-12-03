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

namespace BackOffice.crudForms
{
    public partial class AssignProductToBatchForm : Form
    {

        private int x, y, m;

        public AssignProductToBatchForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearTxtBoxes()
        {
            txtBoxIDLote.Clear();
            txtBoxIDProduct.Clear();
        }

        private bool validateInputsUsers()
        {
            if (!string.IsNullOrEmpty(txtBoxIDProduct.Text) ||
                !string.IsNullOrEmpty(txtBoxIDLote.Text))
            {
                return true;
            }
            return false;
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateInputsUsers())
                {
                    AssignProductsController.Crear(Int32.Parse(txtBoxIDProduct.Text), Int32.Parse(txtBoxIDLote.Text));
                    MessageBox.Show(Languages.Messages.Successful);
                    ClearTxtBoxes();
                }
                else
                {
                    MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
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
    }
}
