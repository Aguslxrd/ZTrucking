using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Almacen.StoreHouseRequests
{
    public class BatchInterface
    {
        public int IDBatches { get; set; }
        public string Email { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime ShippingDate { get; set; }
        public int IDShipp { get; set; }
        public string Position { get; set; }
        public bool ActivedBatch { get; set; }
    }
}
