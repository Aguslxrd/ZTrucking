using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAlmacen.Controllers
{
    public class GetPackagesView
    {
        public int IDPackage { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Corner { get; set; }
        public string Customer { get; set; }
    }
}