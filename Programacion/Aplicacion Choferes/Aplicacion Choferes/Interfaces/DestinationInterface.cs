using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Choferes.APIRequests
{
    public class DestinationInterface
    {
        public int IDDestination { get; set; }
        public string StreetDestination { get; set; }
        public string DoorNumber { get; set; }
        public string CornerDestination { get; set; }
        public DateTime EstimatedDate { get; set; }
        public bool ActivedDestination { get; set; }
    }
}
