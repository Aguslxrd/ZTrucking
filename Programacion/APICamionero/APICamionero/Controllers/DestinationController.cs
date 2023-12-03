using System;
using System.Collections.Generic;
using System.Web.Http;
using APICamionero.Models;
using System.Linq;

namespace APICamionero.Controllers
{
    
    public class DestinationController : ApiController
    {

        [Route("api/v1/camion/destinos/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            DestinationModel destination = new DestinationModel();
            var selectedDestination = destination.GetDestinationById(id);

            if (selectedDestination == null)
            {
                return NotFound();
            }
            else
            {
                var destinationView = new GetDestinationView
                {
                    IDDestination = selectedDestination.IDDestination,
                    StreetDestination = selectedDestination.StreetDestination,
                    DoorNumber = selectedDestination.DoorNumber,
                    CornerDestination = selectedDestination.CornerDestination,
                    EstimatedDate = selectedDestination.EstimatedDate,
                    ActivedDestination = selectedDestination.ActivedDestination
                };

                return Ok(destinationView); 
            }
        }

        [Route("api/v1/destinos")]
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
