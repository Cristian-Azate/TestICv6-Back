using NoticiasBusinessEntities.Common;
using NoticiasBusinessEntities.NoticiaEntitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasMethodParameters.Noticia
{
    public class GetAllNoticiasOut
    {
        public List<NoticiaEntitie> Noticias { get; set; }
        public OperationResult OperationResult { get; set; }
    }
}
