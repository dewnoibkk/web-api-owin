using System.Web.Http;
using Microsoft.Owin;
using Owin;
using web_api_owin;
using web_api_owin.Middlewares;

[assembly: OwinStartup(typeof(Startup))]
namespace web_api_owin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            this.RegisterRoutes(config);

            app.Use<Timestamp>();

            app.UseWebApi(config);
        }
    }
}