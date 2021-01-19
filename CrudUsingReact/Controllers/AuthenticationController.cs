using CrudUsingReact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CrudUsingReact.Controllers
{
    [RoutePrefix("auth")]
    public class AuthenticationController : ApiController
    {
        private string UName;
        private string Pass;

        Response setResponse;
        EcomEntities _ecom = new EcomEntities();

        [Route("admin/{UserName}/{Password}")]
        [HttpPost]
        public async Task<HttpResponseMessage> AuthenticateAdminUser(string UserName, string Password)
        {
            this.UName = UserName;
            this.Pass = Password;
            try
            {
                var UserCount = _ecom.UserLogins.Where(x => x.UserName == this.UName && x.Password == this.Pass).Count();
                if (UserCount > 0)
                {
                    setResponse = new Response
                    {
                        Status = "OK",
                        Message = "Authorized"
                    };

                    return Request.CreateResponse(System.Net.HttpStatusCode.OK, setResponse);
                }
                else
                {
                    setResponse = new Response
                    {
                        Status = "UnAuthorized",
                        Message = "UnAuthorized User"
                    };

                    return Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, setResponse);
                }
            }
            catch (Exception ex)
            {
                setResponse = new Response
                {
                    Status = "BadRequest",
                    Message = ex.Message
                };

                return Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, setResponse);
            }
           
        }
    }
}
