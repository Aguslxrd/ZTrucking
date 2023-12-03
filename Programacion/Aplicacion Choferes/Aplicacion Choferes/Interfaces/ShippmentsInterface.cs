using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Choferes.APIRequests
{
    public class ShippmentsInterface
    {
        public int IDStoreHouse { get; set; }
        public int IDDestination { get; set; }
        public string TypeTravel { get; set; }
        public DateTime ShippmentDate { get; set; }
    }
}
