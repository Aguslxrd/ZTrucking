using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Choferes.APIRequests
{
    public class TruckerCarryInterface
    {
        public int IDTruck { get; set; }
        public int IDBatch { get; set; }
        public string Position { get; set; }
        public DateTime ShippmentDate { get; set; }
    }
}
