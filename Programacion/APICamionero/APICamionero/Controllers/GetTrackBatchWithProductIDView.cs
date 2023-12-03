using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICamionero.Controllers
{
    public class GetTrackBatchWithProductIDView
    {
        public int ProductId { get;  set; }
        public int BatchId { get; set; }
        public string StreetDestination { get;  set; }
        public string DoorNumber { get; set; }
        public string Position { get; set; }
        public DateTime ShippingDate { get; set; }
    }
}