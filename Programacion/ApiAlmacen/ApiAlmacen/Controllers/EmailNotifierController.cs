using ApiAlmacen.Notifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiAlmacen.Controllers
{
    public class EmailNotifierController: ApiController
    {
        private Dictionary<string, string> showResult(string message)
        {
            Dictionary<string, string> resultJson = new Dictionary<string, string>();
            resultJson.Add("Accion realizada con exito: ", message);
            return resultJson;
        }

        [Route("api/v1/email")]
        public IHttpActionResult Post([FromBody] EmailNotifier emailData)
        {
            try
            {
                if (!ModelState.IsValid || emailData == null || string.IsNullOrWhiteSpace(emailData.msgcontent))
                {
                    return BadRequest("Error, revisa los datos ingresados.");
                }

                EmailNotifier emailNotifier = new EmailNotifier();

                emailNotifier.SendEmailNotification(emailData.emailDestination, emailData.msgcontent);

                return Ok(showResult("Email enviado."));
            }
            catch (Exception ex)
            {
                var errorExceptionResponse = $"Error: {ex.Message}";
                return BadRequest(errorExceptionResponse);
            }
        }


    }
}