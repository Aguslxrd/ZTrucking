using ApiAlmacen.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ApiAlmacen.Controllers
{
    public class GeneralInfoController : ApiController
    {
        [HttpGet]
        [Route("api/v1/almacen/generalinfo/count")]
        public IHttpActionResult GetGeneralInfo()
        {
            ProductModel productModel = new ProductModel();
            int productCount = productModel.GetTotalProductOnStoreHouse();

            BatchModels batchModel = new BatchModels();
            int batchCount = batchModel.GetTotalBatchOnStoreHouse();

            Dictionary<string, int> counts = new Dictionary<string, int>
            {
                { "ProductCount", productCount },
                { "BatchCount", batchCount }
            };

            return Ok(counts);
        }
    }
}
