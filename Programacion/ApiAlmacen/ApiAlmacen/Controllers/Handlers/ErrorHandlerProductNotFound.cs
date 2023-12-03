using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAlmacen.Controllers.Handlers
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(int productId) : base($"El producto con el ID {productId} no existe.")
        {
        }
    }
}