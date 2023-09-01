using NoticiasMethodParameters.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasInterfaces.BusinessComponents.Noticia
{
    public interface INoticiaComponent
    {
        GetAllNoticiasOut GetAllNoticias(GetAllNoticiasIn input);
        InsertNoticiaOut InsertNoticia(InsertNoticiaIn input);
    }
}
