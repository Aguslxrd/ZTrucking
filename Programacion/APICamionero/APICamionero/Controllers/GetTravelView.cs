using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICamionero.Controllers
{
    public class GetTravelView
    {
        public int IDStoreHouse { get; set; }
        public int IDDestination { get; set; }
        public string TypeTravel { get; set; }
        public DateTime ShippmentDate { get; set; }

    }
}