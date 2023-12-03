using APICamionero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APICamionero.Controllers
{
    public class TruckerDriveTruckController : ApiController
    {
        [Route("api/v1/camionero/conduce/{truckerId:int}")]
        public IHttpActionResult GetTrucksDrivenByTrucker(int truckerId)
        {
            TruckerDriveTruckModel truckerDriveTruckModel = new TruckerDriveTruckModel();
            var trucksDriven = truckerDriveTruckModel.GetTrucksDrivenByTrucker(truckerId);

            if (trucksDriven == null || trucksDriven.Count == 0)
            {
                return NotFound();
            }
            else
            {
                var firstTrucksDriven = trucksDriven.FirstOrDefault();

                var truckerDriveView = new GetTruckerDriveTruckView
                {
                    IDTruck = firstTrucksDriven.IDTruck,
                    IDTrucker = firstTrucksDriven.IDTrucker
                };

                return Ok(truckerDriveView);
            }
        }

        [Route("api/v1/camionero/conduce/{truckerId:int}/{truckId:int}")]
        public IHttpActionResult GetTruckDrivenByTrucker(int truckerId, int truckId)
        {
            TruckerDriveTruckModel truckerDriveTruckModel = new TruckerDriveTruckModel();
            var truckDriven = truckerDriveTruckModel.GetTruckDrivenByTrucker(truckerId, truckId);

            if (truckDriven == null)
            {
                return NotFound();
            }
            else
            {
                var truckerDriveView = new GetTruckerDriveTruckView
                {
                    IDTruck = truckDriven.IDTruck,
                    IDTrucker = truckDriven.IDTrucker
                };

                return Ok(truckerDriveView);
            }
        }

    }
}
