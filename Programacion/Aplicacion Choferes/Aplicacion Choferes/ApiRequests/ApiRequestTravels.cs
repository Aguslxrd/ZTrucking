using Aplicacion_Almacen.Languages;
using Aplicacion_Choferes.APIRequests;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace Aplicacion_Choferes.ApiRequests
{
    public class ApiRequestTravels
    {
        private readonly string baseUrl;

        public ApiRequestTravels(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public TravelsInterface GetTravelByTruckID(int truckID)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest($"/api/v1/transporta/{truckID}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<TravelsInterface>(response.Content);
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

        public bool EditTravel(string status, int truckID)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest($"/api/v1/transporta/{truckID}", Method.Patch);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");

                var requestBody = new
                {
                    NewShippingStatus = status
                };

                var jsonBody = JsonConvert.SerializeObject(requestBody);
                request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        
    }
}
