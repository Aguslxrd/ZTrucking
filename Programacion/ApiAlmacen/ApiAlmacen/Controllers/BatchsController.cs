using ApiAlmacen.Controllers.Handlers;
using ApiAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiAlmacen.Controllers
{
    public class BatchsController:ApiController
    {
        private Dictionary<string, string> showResult(string message)
        {
            Dictionary<string, string> resultJson = new Dictionary<string, string>();
            resultJson.Add("Accion realizada con exito: ", message);
            return resultJson;
        }

        [Route("api/v1/lotes")]
        public IHttpActionResult Post([FromBody] BatchModels batch) 
        {
            try
            {
            if (!ModelState.IsValid || batch == null)
            {
                var errorResponse = $"Error, revisa los datos ingresados.";
                return BadRequest(errorResponse.ToString());
            }
            batch.DateOfCreation = DateTime.Now;
            batch.Save();
            return Ok(showResult($"Lote {batch.IDBatch.ToString()} guardado"));
            }
            catch (Exception ex)
            {
                var errorExceptionResponse = $"Error: {ex.Message}";
                return BadRequest(errorExceptionResponse.ToString());
            }
        }

        [Route("api/v1/lotes")]
        public IHttpActionResult Get()
        {
            try
            {

            BatchModels batches = new BatchModels();
            var batchList = batches.GetAllLots();
            var batchView = batchList.Select(everyBatch => new GetBatchsView
            {
                IDBatches = everyBatch.IDBatch,
                Email = everyBatch.Email,
                DateOfCreation = everyBatch.DateOfCreation,
                ShippingDate = everyBatch.ShippingDate,
                IDShipp = everyBatch.IDShipp,
                Position = everyBatch.Position,
                ActivedBatch = everyBatch.ActivedBatch
            });
            return Ok(batchView);
            }
            catch(Exception ex)
            {
                var errorExceptionResponse = $"Error: {ex.Message}";
                return BadRequest(errorExceptionResponse.ToString());
            }
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
                var batchView = new GetBatchsView
                {
                    IDBatches = batch.IDBatch,
                    Email = batch.Email,
                    DateOfCreation = batch.DateOfCreation,
                    ShippingDate = batch.ShippingDate,
                    IDShipp = batch.IDShipp,
                    Position = batch.Position,
                    ActivedBatch = batch.ActivedBatch
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
                return Ok(showResult($"El lote con el id {batch.IDBatch} fue eliminado con exito"));
            }
        }


    }
}