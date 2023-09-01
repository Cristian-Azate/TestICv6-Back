using NoticiasBusinessEntities.Common;
using NoticiasBusinessEntities.NoticiaEntitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoticiasService.Noticia
{
    public class InsertNoticiaMessageOut
    {
        public NoticiaEntitie NoticiaEntidad { get; set; }
        public OperationResult OperationResult { get; set; }
    }
}