using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiAlmacen.Controllers.Handlers
{
    public class ErrorHandlerPackageNotFound : Exception
    {
        public ErrorHandlerPackageNotFound(int packageId) : base($"El producto con el ID {packageId} no existe.")
        {
        }
    }
}