using NoticiasBusinessComponents.Noticia;
using NoticiasDataAccess;
using NoticiasInterfaces.BusinessComponents.Noticia;
using NoticiasInterfaces.DataAccess.Noticia;
using NoticiasService.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Unity;


namespace BackOfficeWebUI
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Configura el contenedor de inyección de dependencias Unity
            var container = new UnityContainer();
            container.RegisterType<INoticiaServices, NoticiaServices>();
            container.RegisterType<INoticiaComponent, NoticiaComponent>();
            container.RegisterType<INoticiaData, NoticiaDataAccess>();

            // Registra el contenedor en el contexto de la aplicación
            Application["Container"] = container;      
        }
    }
}