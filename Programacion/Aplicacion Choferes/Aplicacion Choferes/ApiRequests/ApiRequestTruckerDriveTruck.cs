using Aplicacion_Choferes.APIRequests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Choferes.ApiRequests
{
    public class ApiRequestTruckerDriveTruck
    {
        private readonly string baseUrl;

        public ApiRequestTruckerDriveTruck(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public TruckerDriveTruckInterface GetTruckerDriveTruckByID(int truckerID)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest($"/api/v1/camionero/conduce/{truckerID}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<TruckerDriveTruckInterface>(response.Content);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }

}
