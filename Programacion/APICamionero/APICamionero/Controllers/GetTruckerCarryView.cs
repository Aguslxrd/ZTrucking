using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICamionero.Controllers
{
    public class GetTruckerCarryView
    {

        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public string Position { get; set; }
        public DateTime ShippmentDate { get; set; }
    }
}