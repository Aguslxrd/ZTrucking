using ApiAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiAlmacen.Controllers
{
    public class TruckerCarriesBatchController : ApiController
    {

        private Dictionary<string, string> showResult(string message)
        {
            Dictionary<string, string> resultJson = new Dictionary<string, string>();
            resultJson.Add("Accion realizada con exito: ", message);
            return resultJson;
        }

        [Route("api/v1/camionllevalotes")]
        public IHttpActionResult Post([FromBody] TruckerCarriesBatchModel truckercarriesbatch)
        {
            try
            {
                if (!ModelState.IsValid || truckercarriesbatch == null)
                {
                    return BadRequest("Error en el ingreso de datos");
                }
                truckercarriesbatch.Save();
                return Ok(showResult($"El camion {truckercarriesbatch.IDTruck} llevara el lote {truckercarriesbatch.IDBatch}"));
            }
            catch(Exception ex)
            {
                var errorExceptionResponse = $"Error: {ex.Message}";
                return BadRequest(errorExceptionResponse.ToString());
            }

        }

        [Route("api/v1/camionllevalotes")]
        public IHttpActionResult Get()
        {
            TruckerCarriesBatchModel truckercarriesbatch = new TruckerCarriesBatchModel();
            var listcarries = truckercarriesbatch.GetAllCarries();
            var carriesView = listcarries.Select(everyCarrie => new GetTruckersCarriesBatchView
            {
                IDTruck = everyCarrie.IDTruck,
                IDBatch = everyCarrie.IDBatch,
                ShippDate = everyCarrie.ShippDate
            }
            ).ToList();

            return Ok(carriesView);
        }

        [Route("api/v1/camionllevalotes/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            TruckerCarriesBatchModel carries = new TruckerCarriesBatchModel();
            var carriesList = carries.GetAllCarries();
            var selectedCarrie = carriesList.FirstOrDefault(everyCarrie => everyCarrie.IDTruck == id);

            if (selectedCarrie == null)
            {
                return NotFound();
            }
            else
            {
                var carrieView = new GetTruckersCarriesBatchView
                {
                    IDTruck = selectedCarrie.IDTruck,
                    IDBatch = selectedCarrie.IDBatch,
                    ShippDate = selectedCarrie.ShippDate
                };

                return Ok(carrieView);
            }
        }
        [Route("api/v1/camionllevalotes/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            TruckerCarriesBatchModel carries = new TruckerCarriesBatchModel();
            var carriesList = carries.GetAllCarries();
            var selectedCarrie = carriesList.FirstOrDefault(everyCarrie => everyCarrie.IDBatch == id);
            if (selectedCarrie == null)
            {
                return NotFound();
            }
            else
            {
                selectedCarrie.DeleteCarries();
                return Ok();
            }
        }
    }
}