using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAlmacen.Controllers
{
    public class GetDestinationView
    {
        public int IDDestination { get; set; }
        public string StreetDestination { get; set; }
        public string DoorNumber { get; set; }
        public string CornerDestination { get; set; }
        public DateTime EstimatedDate { get; set; }
        public bool ActivedDestination { get; set; }
    }
}