using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj
{
    public class LibroAutor
    {
        //Columnas de la DB 
        public int AutorId { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
        //Fk (Relación 1 a 1 )
        public Autor Autor { get; set; }
        //Fk (Relación 1 a 1 )
    }
}
