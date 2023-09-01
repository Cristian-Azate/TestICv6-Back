using NoticiasBusinessEntities.NoticiaEntitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoticiasService.Noticia
{
    public class GetAllNoticiasMessageOut
    {
        public List<NoticiaEntitie> Noticias { get; set; }
    }
}