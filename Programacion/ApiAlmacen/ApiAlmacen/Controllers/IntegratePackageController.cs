using ApiAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiAlmacen.Controllers
{
    public class IntegratePackageController:ApiController
    {

        private Dictionary<string, string> showResult(string message)
        {
            Dictionary<string, string> resultJson = new Dictionary<string, string>();
            resultJson.Add("Accion realizada con exito: ", message);
            return resultJson;
        }

        [Route("api/v1/integrarpaquetes")]
        public IHttpActionResult Post([FromBody] IntegratePackageModels IntegratePackage)
        {
            if (!ModelState.IsValid || IntegratePackage == null)
            {
                var errorResponse = $"Error en el ingreso de datos con el id {IntegratePackage.IDBatch} y " +
                    $"{IntegratePackage.IDProduct}";
                return BadRequest(errorResponse.ToString());
            }

            try
            {
                IntegratePackage.Save();
                return Ok(showResult($"Producto {IntegratePackage.IDProduct} fue asignado correctamente al lote {IntegratePackage.IDBatch}"));
            }
            catch (Exception ex)
            {
                return BadRequest("Error : " + ex.Message);
            }
        }


        [Route("api/v1/integrarpaquetes")]
        public IHttpActionResult Get()
        {
            try
            {
                IntegratePackageModels products = new IntegratePackageModels();
                var assignedProductsList = products.getAllAsignedProducts();
                if (assignedProductsList == null || !assignedProductsList.Any())
                {
                    return NotFound();
                }

                var AssignedProductsView = assignedProductsList.Select(everyPackage => new GetIntegratePackagesView
                {
                    IDProduct = everyPackage.IDProduct,
                    IDBatch = everyPackage.IDBatch,
                }).ToList();

                return Ok(AssignedProductsView);
            }
            catch(Exception ex)
            {
                var errorExceptionResponse = $"Error: {ex.Message}";
                return BadRequest(errorExceptionResponse.ToString());
            }

        }

        [Route("api/v1/integrarpaquetes/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            IntegratePackageModels package = new IntegratePackageModels();
            var integratedPackageList = package.getAllAsignedProducts();
            var IntegratedPackageSearch = integratedPackageList.FirstOrDefault(p => p.IDProduct == id);

            if (IntegratedPackageSearch == null)
            {
                return NotFound();
            }
            else
            {
                var IntegratedPackagesView = new GetIntegratePackagesView
                {
                    IDProduct = IntegratedPackageSearch.IDProduct,
                    IDBatch = IntegratedPackageSearch.IDBatch,
                };

                return Ok(IntegratedPackagesView);
            }
        }
        [Route("api/v1/integrarpaquetes/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            IntegratePackageModels package = new IntegratePackageModels();
            var packageList = package.getAllAsignedProducts();
            var packageAssigned = packageList.FirstOrDefault(everyPackage => everyPackage.IDProduct == id);
            if (packageAssigned == null)
            {
                return NotFound();
            }
            else
            {
                packageAssigned.Delete();
                return Ok(showResult($"Producto con ID {id} eliminado con éxito"));
            }
        }

    }

}