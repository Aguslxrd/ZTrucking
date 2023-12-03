using Aplicacion_Seguimiento.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Seguimiento.ApiRequests
{
    public class ApiRequestGetBatchByProductID
    {
        private readonly string baseUrl;

        public ApiRequestGetBatchByProductID(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public CustomerSearchByProductIDInterface GetBatchByProductId(int productId)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest($"/api/v1/seguimiento/consulta/producto/{productId}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    CustomerSearchByProductIDInterface batch = JsonConvert.DeserializeObject<CustomerSearchByProductIDInterface>(response.Content);
                    return batch;
                }
                else
                {
                    throw new Exception("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}
