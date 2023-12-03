using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Almacen.StoreHouseRequests
{
    public class ProductInterface
    {
        public int IDProduct { get; set; }
        public int ProductWeight { get; set; }
        public bool ActivatedProduct { get; set; }
        public int Volume { get; set; }
        public string Street { get; set; }
        public int DoorNumber { get; set; }
        public string Corner { get; set; }
        public string Customer { get; set; }
    }
}
