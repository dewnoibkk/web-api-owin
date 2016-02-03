using System.Web.Http;

namespace web_api_owin
{
    public partial class Startup
    {
        private void RegisterRoutes(HttpConfiguration config)
        {
            //  Enable attribute based routing
            //  http://www.asp.net/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "{controller}/{action}"
            );
        }
    }
}