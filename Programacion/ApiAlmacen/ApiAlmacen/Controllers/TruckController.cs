using ApiAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiAlmacen.Controllers
{
    public class TruckController : ApiController
    {
        private Dictionary<string, string> showResult(string message)
        {
            Dictionary<string, string> resultJson = new Dictionary<string, string>();
            resultJson.Add("Accion realizada con exito: ", message);
            return resultJson;
        }

        [HttpGet]
        [Route("api/v1/almacen/camiones")]
        public IHttpActionResult GetTrucks([FromBody] TruckModel truck)
        {
            try
            {

                TruckModel trucks = new TruckModel();
                var trucksList = trucks.GetAllTrucks();
                var truckView = trucksList.Select(everyTruck => new GetTruckView
                {
                    TruckID = everyTruck.TruckID,
                    TruckVolume = everyTruck.TruckVolume,
                    TruckWeight = everyTruck.TruckWeight
                });
                return Ok(truckView);
            }
            catch (Exception ex)
            {
                var errorExceptionResponse = $"Error: {ex.Message}";
                return BadRequest(errorExceptionResponse.ToString());
            }
        
        }

    }
}