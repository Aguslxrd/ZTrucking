using Aplicacion_Almacen.Login;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Almacen.ApiRequests
{
    public class ApiRequestLogin
    {
        private readonly string baseUrl;

        public ApiRequestLogin(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public ApiResponse Authenticate(string username, string password)
        {
            try
            {
                ApiRequest requestBody = new ApiRequest()
                {
                    Username = username,
                    Password = password
                };

                string requestBodyJson = JsonConvert.SerializeObject(requestBody);

                RestClient client = new RestClient(baseUrl);

                RestRequest request = new RestRequest("/api/v1/login", Method.Post);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(requestBodyJson);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<ApiResponse>(response.Content);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
