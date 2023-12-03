using Aplicacion_Choferes.Forms;
using Aplicacion_Choferes.LoginReqRes;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Choferes
{
    public partial class Login : Form
    {

        private int userId;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private ApiResponse deserialize(string jsoncontent)
        {
            return JsonConvert.DeserializeObject<ApiResponse>(jsoncontent);
        }



        private RestResponse Authenticate()
        {
            ApiRequest requestBody = new ApiRequest()
            {
                Username = textBox1.Text,
                Password = textBox2.Text
            };

            string requestBodyJson = JsonConvert.SerializeObject(requestBody);

            RestClient client = new RestClient("http://localhost:52231");

            RestRequest request = new RestRequest("/api/v1/login", Method.Post);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(requestBodyJson);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            RestResponse response = client.Execute(request);
            return response;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                RestResponse response = Authenticate();
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Login Invalido");
                }
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    ApiResponse apiResponse = this.deserialize(response.Content);
                    string result = apiResponse.resultado;
                    string role = apiResponse.tipo;
                    ApiRequest apiRequest = new ApiRequest();

                    if (apiResponse != null && result == "OK" && role == "camionero")
                    {
                        apiRequest.Username = textBox1.Text;

                        userId = apiResponse.id;

                        MainForm mainForm = new MainForm(apiResponse, apiRequest);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error de autenticacion");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
