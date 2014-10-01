using System.Web.Http;
using System.Web.Routing;

namespace dreamcometotruenetService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register();
        }
    }
}