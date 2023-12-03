using Aplicacion_Almacen.StoreHouseRequests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Almacen.ApiRequests
{
    public class ApiRequestTruckList
    {
        private readonly string baseUrl;

        public ApiRequestTruckList(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public List<TruckInterface> GetTrucks()
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest("/api/v1/almacen/camiones", Method.Get);
                request.AddHeader("Accept", "application/json");
                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<List<TruckInterface>>(response.Content);
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
