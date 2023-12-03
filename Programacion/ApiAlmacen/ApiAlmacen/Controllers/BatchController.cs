using ApiAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiAlmacen.Controllers
{
    public class BatchController : ApiController
    {
        [Route("api/v1/lotes")]
        public IHttpActionResult Post([FromBody] BatchModels batch) //batch=lote
        {
            if (!ModelState.IsValid || batch == null)
            {
                return BadRequest("Error en el ingreso de datos");
            }
            batch.DateOfCreation = DateTime.Now;
            batch.Save();
            return Ok($"Lote {batch.IDBatch} fue guardado con exito");
        }

        [Route("api/v1/lotes")]
        public IHttpActionResult Get()
        {
            BatchModels batches = new BatchModels();
            var batchList = batches.GetAllLots();
            var batchView = batchList.Select(everyBatch => new GetLotsView
            {
                IDBatches = everyBatch.IDBatch,
                DateOfCreation = everyBatch.DateOfCreation,
                ProductsAmountOnBatches = everyBatch.ProductAmountOnBatch
            });
            return Ok(batchView);
        }


        [Route("api/v1/lotes/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            BatchModels batches = new BatchModels();
            var batchList = batches.GetAllLots();
            var batch = batchList.FirstOrDefault(everyBatch => everyBatch.IDBatch == id);
            if (batch == null)
            {
                return NotFound();
            }
            else
            {
                var batchView = new GetLotsView
                {
                    IDBatches = batch.IDBatch,
                    DateOfCreation = batch.DateOfCreation,
                    ProductsAmountOnBatches = batch.ProductAmountOnBatch
                };
                return Ok(batchView);
            }
        }
        [Route("api/v1/lotes/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            BatchModels batches = new BatchModels();
            var batchList = batches.GetAllLots();
            var batch = batchList.FirstOrDefault(everyBatch => everyBatch.IDBatch == id);
            if (batch == null)
            {
                return NotFound();
            }
            else
            {
                batch.DeleteLots();
                return Ok($"El lote con el id {batch.IDBatch} fue eliminado con exito");
            }
        }

        [Route("api/v1/lotes/{id:int}")]
        public IHttpActionResult Put(int id, [FromBody] BatchModels batch)
        {
            if (!ModelState.IsValid || batch == null)
            {
                return BadRequest("Error en el ingreso de datos");
            }

            batch.IDBatch = id;
            batch.Edit();

            return Ok($"Producto {batch.IDBatch} editado con éxito");
        }

    }
}