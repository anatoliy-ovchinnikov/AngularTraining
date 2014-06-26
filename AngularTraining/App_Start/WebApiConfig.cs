namespace AngularStart
{
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using System.Web.Http.WebHost;
    using System.Web.Routing;
    using System.Web.SessionState;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Going camel case in Web API http://frankapi.wordpress.com/2012/09/09/going-camelcase-in-asp-net-mvc-web-api/
            //var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            //jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            RouteTable.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = RouteParameter.Optional }
           ).RouteHandler = new SessionHttpControllerRouteHandler();

            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(
                config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml"));
            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();
        }

        public class SessionHttpControllerHandler : HttpControllerHandler, IRequiresSessionState
        {
            public SessionHttpControllerHandler(RouteData routeData)
                : base(routeData)
            {
            }
        }
        public class SessionHttpControllerRouteHandler : HttpControllerRouteHandler
        {
            protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
            {
                return new SessionHttpControllerHandler(requestContext.RouteData);
            }
        }
    }
}