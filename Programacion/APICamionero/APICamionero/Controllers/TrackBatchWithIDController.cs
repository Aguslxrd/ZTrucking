using APICamionero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APICamionero.Controllers
{
    public class TrackBatchWithIDController : ApiController
    {
        [HttpGet]
        [Route("api/v1/seguimiento/consulta/lote/{idBatch:int}")]
        public IHttpActionResult GetByStoreHouse([FromUri] int idBatch)
        {
            TrackBatchWithIDModel order = new TrackBatchWithIDModel();
            order.GetDestinationAndStatusByLoteId(idBatch);

            if (order.BatchId == 0)
            {
                return NotFound();
            }
            else if (order.BatchStatus == "0")
            {
                return BadRequest();
            }
            else
            {
                var orderView = new GetTrackBatchWithIDView
                {
                    BatchId = order.BatchId,
                    StreetDestination = order.StreetDestination,
                    DoorNumber = order.DoorNumber,
                    ShippmentDate = order.ShippmentDate,
                    Position = order.Position,
                    BatchStatus = order.BatchStatus
                };

                return Ok(orderView);
            }
        }

    }
}