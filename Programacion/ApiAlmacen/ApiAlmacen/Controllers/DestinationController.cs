using ApiAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiAlmacen.Controllers
{
    public class DestinationController : ApiController
    {
        [Route("api/v1/almacen/destinos")]
        public IHttpActionResult Get()
        {
            DestinationModel destinationlist = new DestinationModel();
            var listDestination = destinationlist.GetDestinations();
            var destinationView = listDestination.Select(everyDestination => new GetDestinationView
            {
                IDDestination = everyDestination.IDDestination,
                StreetDestination = everyDestination.StreetDestination,
                DoorNumber = everyDestination.DoorNumber,
                CornerDestination = everyDestination.CornerDestination,
                EstimatedDate = everyDestination.EstimatedDate,
                ActivedDestination = everyDestination.ActivedDestination
            }
            ).ToList();

            return Ok(destinationView);
        }
    }
}