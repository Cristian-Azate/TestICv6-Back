using NoticiasBusinessEntities.Common;
using NoticiasInterfaces.BusinessComponents.Noticia;
using NoticiasInterfaces.DataAccess.Noticia;
using NoticiasMethodParameters.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasBusinessComponents.Noticia
{
    public class NoticiaComponent : INoticiaComponent
    {
        private readonly INoticiaData noticiaData;

        public NoticiaComponent(INoticiaData noticiaData)
        {
            this.noticiaData = noticiaData;
        }
        public InsertNoticiaOut InsertNoticia(InsertNoticiaIn input)
        {
            InsertNoticiaOut result = new InsertNoticiaOut();

            if (!string.IsNullOrEmpty(input.NoticiaEntitie.titulo) && !string.IsNullOrEmpty(input.NoticiaEntitie.cuerpo))
            {
                result = noticiaData.InsertNoticia(input);
            }    
         
            return result;
        }

        public GetAllNoticiasOut GetAllNoticias(GetAllNoticiasIn input)
        {
            GetAllNoticiasOut result = new GetAllNoticiasOut();

            result = noticiaData.GetAllNoticias(input);
          
            return result;
        }
    }
}
