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
    public class ApiRequestGetBatchByID
    {
        private readonly string baseUrl;

        public ApiRequestGetBatchByID(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public CustomerSearchByBatchIDInterface GetBatchById(int batchId)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest($"/api/v1/seguimiento/consulta/lote/{batchId}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    CustomerSearchByBatchIDInterface batch = JsonConvert.DeserializeObject<CustomerSearchByBatchIDInterface>(response.Content);
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
