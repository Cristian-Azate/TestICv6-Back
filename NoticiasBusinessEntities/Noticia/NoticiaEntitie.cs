using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasBusinessEntities.NoticiaEntitie
{
    public class NoticiaEntitie
    {
        public int noticiaId { get; set; }
        public string titulo { get; set; }
        public string cuerpo { get; set; }
        public DateTime fechaCreacion { get; set; }
        public byte[] Imagen { get; set; }
    }
}
