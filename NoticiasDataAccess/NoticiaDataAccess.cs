using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoticiasDataAccess.Noticia.Models;
using NoticiasBusinessEntities.NoticiaEntitie;
using NoticiasMethodParameters.Noticia;
using System.Runtime.InteropServices;
using System.Xml;
using NoticiasInterfaces.DataAccess.Noticia;
using NoticiasBusinessEntities.Common;

namespace NoticiasDataAccess
{
   public class NoticiaDataAccess : INoticiaData
    {
       public virtual GetAllNoticiasOut GetAllNoticias(GetAllNoticiasIn input)
        {
            GetAllNoticiasOut result = new GetAllNoticiasOut();
            List<NoticiaEntitie> resultMethod = new List<NoticiaEntitie>();

            using (var dataContext = new NoticiaDataContext())
            {
                var linqResult = dataContext.Noticias_Consultar_Todas();

                NoticiaEntitie eNoticia;
                foreach (var linqItem in linqResult)
                {
                    eNoticia = new NoticiaEntitie();
                    eNoticia.noticiaId = linqItem.NoticiaId;
                    eNoticia.titulo = linqItem.Titulo;
                    eNoticia.cuerpo = linqItem.Cuerpo;
                    eNoticia.fechaCreacion = Convert.ToDateTime(linqItem.FechaCreacion);

                    if (linqItem.Imagen != null)
                    eNoticia.Imagen = linqItem.Imagen.ToArray();

                    resultMethod.Add(eNoticia);
                }
            }

            result.OperationResult = OperationResult.Success;
            result.Noticias = resultMethod;
            return result;
        }

        public virtual InsertNoticiaOut InsertNoticia(InsertNoticiaIn input)
        {
            InsertNoticiaOut output = new InsertNoticiaOut();

            int result = 0;

            using (var dataContext = new NoticiaDataContext())
            {
                result = dataContext.Noticias_Insertar(input.NoticiaEntitie.titulo, input.NoticiaEntitie.cuerpo, input.NoticiaEntitie.fechaCreacion, input.NoticiaEntitie.Imagen);

               if (result == 0)
                {
                    output.OperationResult = OperationResult.Success;
                }
              
            }

            return output;
        }
    }
}
