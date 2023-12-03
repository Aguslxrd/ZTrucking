using APICamionero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APICamionero.Controllers
{
    public class TrackBatchWithProductIDController : ApiController
    {
        [HttpGet]
        [Route("api/v1/seguimiento/consulta/producto/{idProduct:int}")]
        public IHttpActionResult GetByStoreHouse([FromUri] int idProduct)
        {
            TrackBatchWithProductIDModel order = new TrackBatchWithProductIDModel();
            order.GetBatchByProductId(idProduct);

            if (order.ProductId == 0)
            {
                return NotFound();  
            }
            else if (order.BatchStatus == "0")  
            {
                return BadRequest();  
            }
            else
            {
                var orderView = new GetTrackBatchWithProductIDView
                {
                    ProductId = order.ProductId,
                    BatchId = order.BatchId,
                    StreetDestination = order.StreetDestination,
                    DoorNumber = order.DoorNumber,
                    Position = order.Position,
                    ShippingDate = order.ShippingDate
                };

                return Ok(orderView);  
            }
        }


    }
}