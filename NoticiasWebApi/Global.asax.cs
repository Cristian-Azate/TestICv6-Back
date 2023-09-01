using NoticiasService.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity.WebApi;
using Unity;
using NoticiasInterfaces.BusinessComponents.Noticia;
using NoticiasBusinessComponents.Noticia;
using NoticiasInterfaces.DataAccess.Noticia;
using NoticiasDataAccess;
using System.Security.Cryptography;

namespace NoticiasWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Configura el contenedor de inyección de dependencias Unity
            var container = new UnityContainer();
            container.RegisterType<INoticiaServices, NoticiaServices>();
            container.RegisterType<INoticiaComponent, NoticiaComponent>();
            container.RegisterType<INoticiaData, NoticiaDataAccess>();

            // Configura la dependencia del controlador de Web API
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            // Resto de la configuración de inicio de la aplicación
        }
        //el servidor no permite estas solicitudes debido a las políticas de seguridad del mismo origen(CORS, Cross-Origin Resource Sharing).
        //Habilito CORS para las solicitudes Http de la API
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type");
        }
    }
}
