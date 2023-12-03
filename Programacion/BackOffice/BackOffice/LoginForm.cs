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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void openMainForm()
        {
            QuickCarry mainForm = new QuickCarry();
            mainForm.Show();
            this.Hide();
        }

        protected string username = "admin";
        protected string password = "admin";

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == username && textBoxPassword.Text == password)
            {
                openMainForm();
            }
            else
            {
                MessageBox.Show("Credenciales no validas!");
            }

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
