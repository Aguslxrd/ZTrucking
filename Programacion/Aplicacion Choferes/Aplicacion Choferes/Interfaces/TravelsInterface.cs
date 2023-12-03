using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Choferes.APIRequests
{
    public class TravelsInterface
    {
        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public int IDDestination { get; set; }
        public string ShippingStatus { get; set; }
        public string Position { get; set; }
    }
}
