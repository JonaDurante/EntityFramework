using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj
{
    public class Precio
    {
        //COLUMNAS DE LA TABLA EXPRESADAS COMO PROPIEDADES
        public int PrecioId { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal Promocion { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
        //Fk Tabla Libro (Relación 1 a 1 )
    }
}
