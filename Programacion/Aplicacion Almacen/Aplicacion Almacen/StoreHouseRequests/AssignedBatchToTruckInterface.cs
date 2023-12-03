using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Almacen.StoreHouseRequests
{
    public class AssignedBatchToTruckInterface
    {
        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public DateTime ShippDate { get; set; }
    }
}
