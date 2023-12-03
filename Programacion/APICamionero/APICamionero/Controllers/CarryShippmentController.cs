using APICamionero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APICamionero.Controllers
{
    public class CarryShippmentController : ApiController
    {
        [Route("api/v1/transporta/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            CarryShippmentModel carryShippment = new CarryShippmentModel();
            var carriesList = carryShippment.GetAssignedToCamionero(id);
            var selectedCarrie = carriesList.FirstOrDefault(p => p.IDTruck == id);

            if (selectedCarrie == null)
            {
                return NotFound();
            }
            else
            {
                var carrieView = new GetCarryShippment
                {
                    IDTruck = selectedCarrie.IDTruck,
                    IDBatch = selectedCarrie.IDBatch,
                    IDDestination = selectedCarrie.IDDestination,
                    Position = selectedCarrie.Position,
                    ShippingStatus = selectedCarrie.ShippingStatus
                };

                return Ok(carrieView);

            }
        }

        [Route("api/v1/transporta/{id:int}")]
        [HttpPatch]
        public IHttpActionResult Patch(int id, [FromBody] StatusShippmentMapping status)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CarryShippmentModel carryShippment = new CarryShippmentModel();
            var existingCarry = carryShippment.GetOne(id);

            if (existingCarry == null)
            {
                return NotFound();
            }

            existingCarry.ShippingStatus = status.NewShippingStatus;

            try
            {
                bool success = existingCarry.Edit(id);

                if (success)
                {
                    return Ok(showResult("Estado de envío actualizado exitosamente."));
                }

                return InternalServerError();
            }
            catch (Exception ex)
            {
                var errorResponse = $"Error: {ex.Message}";
                return BadRequest(errorResponse);

            }
        }

        private Dictionary<string, string> showResult(string message)
        {
            Dictionary<string, string> resultJson = new Dictionary<string, string>();
            resultJson.Add("Accion realizada con exito: ", message);
            return resultJson;
        }

    }
}