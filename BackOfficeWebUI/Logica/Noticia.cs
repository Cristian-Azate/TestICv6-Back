using NoticiasService.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using Unity;
using NoticiasBusinessEntities.NoticiaEntitie;
using NoticiasBusinessEntities.Common;

namespace BackOfficeWebUI.Logica
{
    public class Noticia
    {
        private readonly INoticiaServices noticiaServices;
        public Noticia(INoticiaServices noticiaServices)
        {
            this.noticiaServices = noticiaServices;
        }
    
        public bool InsertarNoticia(string titulo,string cuerpo,DateTime fecha_creacion,Image Imagen)
        {
           NoticiaEntitie noticiaEntitie = new NoticiaEntitie();
           noticiaEntitie.titulo = titulo;
           noticiaEntitie.cuerpo = cuerpo;
           noticiaEntitie.fechaCreacion = fecha_creacion;

           if (Imagen.ImageUrl != null && Imagen.ImageUrl.StartsWith("data:image"))
           {
               // Obtener la parte base64 de la URL
               string base64Data = Imagen.ImageUrl.Split(',')[1];
               byte[] bytes = Convert.FromBase64String(base64Data);

               noticiaEntitie.Imagen = bytes;
           }


           InsertNoticiaMessageIn input = new InsertNoticiaMessageIn();
           input.NoticiaEntitie=noticiaEntitie;

           var result = noticiaServices.InsertNoticia(input);

            if (result.OperationResult == OperationResult.Success)
                return true;
            else
                return false;
            
        }
    }
}