using AuthenticationAPI.Models;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace AuthenticationAPI.Controllers
{

    [RoutePrefix("api/v1")]
    public class LoginRequestController : ApiController
    {
        [HttpPost]
        [Route("login")]
        public IHttpActionResult Auth([FromBody] LoginRequestModel loginrequest)
        {
            Dictionary<string, string> authentication = loginrequest.LoginRequest();

            if (!ModelState.IsValid)
            {
                return Unauthorized();
            }
            if (authentication["resultado"] == "OK")
            {
                return Content(HttpStatusCode.OK, authentication);
            }
            return Unauthorized();
        }

    }
}