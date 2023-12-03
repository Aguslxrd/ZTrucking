using Aplicacion_Almacen.StoreHouseRequests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Aplicacion_Almacen.APIRequests
{
    public class ProductsRequests
    {
        private readonly string baseUrl;

        public ProductsRequests(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public List<ProductInterface> GetProducts()
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest("/api/v1/productos", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<List<ProductInterface>>(response.Content);
                }
                else
                {
                    // Manejar el error de la API según tus necesidades
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                return null;
            }
        }

        public bool AddProduct(ProductInterface product)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest("/api/v1/productos", Method.Post);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", JsonConvert.SerializeObject(product), ParameterType.RequestBody);

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    // Manejar el error de la API según tus necesidades
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                return false;
            }
        }

        // Agregar métodos similares para actualizar y eliminar productos
    }
}
