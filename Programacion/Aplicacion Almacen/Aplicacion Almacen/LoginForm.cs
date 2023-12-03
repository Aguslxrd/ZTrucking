using Aplicacion_Almacen.ApiRequests;
using Aplicacion_Almacen.Forms;
using Aplicacion_Almacen.Login;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen
{
    public partial class LoginForm : Form
    {
        private readonly ApiRequestLogin authService;

        public LoginForm()
        {
            InitializeComponent();
            authService = new ApiRequestLogin("http://localhost:52231");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private ApiResponse deserialize(string jsoncontent)
        {
            return JsonConvert.DeserializeObject<ApiResponse>(jsoncontent);
        }

        private void openPrincipalForm()
        {
            ApiResponse apiResponse = authService.Authenticate(textBox1.Text, textBox2.Text);
            ApiRequest apiRequest = new ApiRequest();

            if (apiResponse != null && apiResponse.resultado == "OK" && apiResponse.tipo == "operario")
            {
                apiRequest.Username = textBox1.Text;
                MainForm mainForm = new MainForm(apiResponse, apiRequest);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de autenticación");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ApiResponse apiResponse = authService.Authenticate(textBox1.Text, textBox2.Text);

                if (apiResponse == null)
                {
                    MessageBox.Show("Error de autenticación");
                }
                else if (apiResponse.resultado == "OK" && apiResponse.tipo == "operario")
                {
                    openPrincipalForm();
                }
                else
                {
                    MessageBox.Show("Error de autenticación");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
