using System.Web.Http;
using WebActivatorEx;
using WebApplicationNS;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApplicationNS
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
            GlobalConfiguration.Configuration
                .EnableSwagger(c => c.SingleApiVersion("v1", "WebApplicationNS"))
                .EnableSwaggerUi();
        }
    }
}
