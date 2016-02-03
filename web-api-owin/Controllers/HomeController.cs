using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_api_owin.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage HelloWorld()
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, new { Message = "Hello World" });
        }

        [HttpGet]
        public HttpResponseMessage HelloName(string name)
        {
            return this.Request.CreateResponse(HttpStatusCode.OK, new { Message = $"Hello {name}" });
        }
    }
}
