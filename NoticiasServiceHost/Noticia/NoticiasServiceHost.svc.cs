using NoticiasBusinessEntities.Common;
using NoticiasBusinessEntities.NoticiaEntitie;
using NoticiasService.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NoticiaServiceHost.Noticia
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "NoticiasServiceHost" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione NoticiasServiceHost.svc o NoticiasServiceHost.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class NoticiaServiceHost : INoticiaServices
    {
        private readonly INoticiaServices noticiaServices;

        public NoticiaServiceHost(INoticiaServices noticiaServices)
        {
            this.noticiaServices = noticiaServices;
        }

        public InsertNoticiaMessageOut InsertNoticia(InsertNoticiaMessageIn request)
        {
            return noticiaServices.InsertNoticia(request);
        }

        public GetAllNoticiasMessageOut GetAllNoticias(GetAllNoticiasMessageIn request)
        {
            return noticiaServices.GetAllNoticias(request);
        }
    }   

   

}
