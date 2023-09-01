using NoticiasBusinessEntities.Common;
using NoticiasBusinessEntities.NoticiaEntitie;
using NoticiasInterfaces.BusinessComponents.Noticia;
using NoticiasInterfaces.DataAccess.Noticia;
using NoticiasMethodParameters.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoticiasService.Noticia
{
    public class NoticiaServices : INoticiaServices
    {
        private readonly INoticiaComponent noticiaComponent;

        public NoticiaServices(INoticiaComponent noticiaComponent)
        {
            this.noticiaComponent = noticiaComponent;
        }

        public virtual InsertNoticiaMessageOut InsertNoticia(InsertNoticiaMessageIn request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            InsertNoticiaMessageOut result = new InsertNoticiaMessageOut();
            InsertNoticiaIn input = new InsertNoticiaIn();

            input.NoticiaEntitie = request.NoticiaEntitie;

            InsertNoticiaOut output = new InsertNoticiaOut();

            output = noticiaComponent.InsertNoticia(input);

            if (output.OperationResult == OperationResult.Success)
                result.OperationResult = output.OperationResult;

            return result;
        }

        public virtual GetAllNoticiasMessageOut GetAllNoticias(GetAllNoticiasMessageIn request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            GetAllNoticiasMessageOut result = new GetAllNoticiasMessageOut();
            GetAllNoticiasIn input = new GetAllNoticiasIn();

            GetAllNoticiasOut output = new GetAllNoticiasOut();

            output = noticiaComponent.GetAllNoticias(input);

            result.Noticias = output.Noticias;

            return result;
        }

    }
}