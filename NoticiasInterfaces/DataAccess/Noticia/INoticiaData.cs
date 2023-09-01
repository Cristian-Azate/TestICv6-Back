using NoticiasMethodParameters.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasInterfaces.DataAccess.Noticia
{
    public interface INoticiaData
    {
        GetAllNoticiasOut GetAllNoticias(GetAllNoticiasIn input);
        InsertNoticiaOut InsertNoticia(InsertNoticiaIn input);
    }
}
