using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICamionero.Controllers
{
    public class GetCarryShippment
    {
        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public int IDDestination { get; set; }
        public string Position { get; set; }
        public string ShippingStatus { get; set; }
    }
}