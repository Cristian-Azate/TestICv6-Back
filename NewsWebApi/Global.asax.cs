using NoticiasService.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Unity;
using Unity.WebApi;

namespace NewsWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Configura el contenedor de inyección de dependencias Unity
            var container = new UnityContainer();
            container.RegisterType<INoticiaServices, NoticiaServices>();

            // Configura la dependencia del controlador de Web API
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            // Resto de la configuración de inicio de la aplicación

        }

       
    }
}
