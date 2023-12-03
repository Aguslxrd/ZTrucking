using APICamionero.Models;
using System.Web.Http;
using System.Linq;

namespace APICamionero.Controllers
{
    public class TravelController : ApiController
    {
        [Route("api/v1/destino/recorrido/{idDestination:int}")]
        public IHttpActionResult GetByDestination([FromUri] int idDestination)
        {
            TravelModel travel = new TravelModel();
            var selectedTravel = travel.GetTravelsByDestination(idDestination);

            if (selectedTravel == null || selectedTravel.Count == 0)
            {
                return NotFound();
            }
            else
            {
                var firstTravel = selectedTravel.FirstOrDefault();

                var travelView = new GetTravelView
                {
                    IDDestination = firstTravel.IDDestination,
                    IDStoreHouse = firstTravel.IDStoreHouse,
                    TypeTravel = firstTravel.TypeTravel,
                    ShippmentDate = firstTravel.ShippmentDate
                };

                return Ok(travelView);
            }
        }

        [Route("api/v1/almacen/recorrido/{idStoreHouse:int}")]
        public IHttpActionResult GetByStoreHouse([FromUri] int idStoreHouse)
        {
            TravelModel travel = new TravelModel();
            var selectedTravel = travel.GetTravelsByStoreHouse(idStoreHouse);

            if (selectedTravel == null || selectedTravel.Count == 0)
            {
                return NotFound();
            }
            else
            {
                var firstTravel = selectedTravel.FirstOrDefault();

                var travelView = new GetTravelView
                {
                    IDDestination = firstTravel.IDDestination,
                    IDStoreHouse = firstTravel.IDStoreHouse,
                    TypeTravel = firstTravel.TypeTravel,
                    ShippmentDate = firstTravel.ShippmentDate
                };

                return Ok(travelView);
            }
        }
    }
}
