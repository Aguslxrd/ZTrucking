using Aplicacion_Almacen.StoreHouseRequests;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Almacen.ApiRequests
{
    public class ApiRequestEmailNotifier
    {
        private readonly string baseUrl;

        public ApiRequestEmailNotifier(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public bool SendEmailNotification(GmailNotifierInterface email)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest("/api/v1/email", Method.Post);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(email);

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
