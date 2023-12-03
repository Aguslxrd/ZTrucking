using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAlmacen.Controllers
{
    public class GetTruckersCarriesBatchView
    {
        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public DateTime ShippDate { get; set; }
    }
}