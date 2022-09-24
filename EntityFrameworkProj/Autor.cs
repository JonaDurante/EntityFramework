using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj
{
    public class Autor
    {
        //Columnas de la DB 
        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Grado { get; set; }
        public byte[]? FotoPerfil { get; set; }
        public ICollection<LibroAutor> LibroLink { get; set; }
        //Fk LibroAutor (Relación 1 a muchos )
    }
}
