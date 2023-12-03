using APICamionero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APICamionero.Controllers
{
    public class TruckerCarryController : ApiController
    {
        [Route("api/v1/llevan/{idTrucker:int}")]
        public IHttpActionResult GetByStoreHouse([FromUri] int idTrucker)
        {
            TruckerCarryModel truckercarry = new TruckerCarryModel();
            var selectedTrucker = truckercarry.GetCarriesByTruck(idTrucker);

            if (selectedTrucker == null || selectedTrucker.Count == 0)
            {
                return NotFound();
            }
            else
            {
                var firstTruckerCarry = selectedTrucker.FirstOrDefault();

                var truckerView = new GetTruckerCarryView
                {
                    IDTruck = firstTruckerCarry.IDTruck,
                    IDBatch = firstTruckerCarry.IDBatch,
                    Position = firstTruckerCarry.Position,
                    ShippmentDate = firstTruckerCarry.ShippmentDate
                };

                return Ok(truckerView);
            }
        }

    }
}