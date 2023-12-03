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
    public class ApiRequestDestinationList
    {
        private readonly string baseUrl;

        public ApiRequestDestinationList(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public List<DestinationInterface> GetDestinations()
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest("/api/v1/almacen/destinos", Method.Get);
                request.AddHeader("Accept", "application/json");
                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<DestinationInterface> destinations = JsonConvert.DeserializeObject<List<DestinationInterface>>(response.Content);
                    return destinations;
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
