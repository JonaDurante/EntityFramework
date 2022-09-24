using System.Collections.Generic;

namespace EntityFrameworkProj
{
    public class Libro
    {
        //Columnas de la tabla Libro
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaPublicacion { get; set; }
        public Precio PrecioPromocion { get; set; }
        //Fk Tabla Libro con Tabla Precio (Relación 1 a 1 )
        public ICollection<Comentario> ComentarioLista { get; set; }
        //Fk Comentario (Relación 1 a muchos )
        public ICollection<LibroAutor> AutorLink{get;set; }
        //Fk LibroAutor (Relación 1 a muchos )
    }
}
