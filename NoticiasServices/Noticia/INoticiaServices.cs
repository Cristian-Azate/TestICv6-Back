using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace NoticiasService.Noticia
{
    [ServiceContract]
    public interface INoticiaServices
    {
        [OperationContract]
        InsertNoticiaMessageOut InsertNoticia(InsertNoticiaMessageIn request);
        [OperationContract]
        GetAllNoticiasMessageOut GetAllNoticias(GetAllNoticiasMessageIn request);
    }
}