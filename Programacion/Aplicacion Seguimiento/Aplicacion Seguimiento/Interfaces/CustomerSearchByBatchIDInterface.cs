using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Seguimiento.Interfaces
{
    public class CustomerSearchByBatchIDInterface
    {
        public int BatchId { get; set; }
        public string StreetDestination { get; set; }
        public string DoorNumber { get; set; }
        public DateTime ShippmentDate { get; set; }
        public string BatchStatus { get; set; }
        public string Position { get; set; }
    }
}
