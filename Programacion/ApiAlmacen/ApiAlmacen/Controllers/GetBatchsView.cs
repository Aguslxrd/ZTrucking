using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAlmacen.Controllers
{
    public class GetBatchsView
    {
        public int IDBatches { get; set; }
        public string Email { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int IDShipp { get; set; }
        public string Position { get; set; }
        public bool ActivedBatch { get; set; }
    }
}