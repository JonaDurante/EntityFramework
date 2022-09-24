using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Linq;
namespace EntityFrameworkProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio AppVentasLibrosContext para poder usar sus entidades
            using (var db = new AppVentaLibrosContext())
            {
                ////-----------------------------------------------------------------------------------------------------------
                //// CONSULTA SIMPLE DE LA TABLA LIBRO
                //// AsNoTracking me permite traer la información necesaria desde la Db pero sin almacenarla en caché
                //// Devuelve un iterable, como una lista con laconsulta que realizamos
                //var Libros = db.Libro.AsNoTracking();
                //foreach (var Libro in Libros)
                //{
                //    Libro libro = new Libro();
                //    Console.WriteLine(Libro.LibroId);
                //    Console.WriteLine(Libro.Titulo);
                //    Console.WriteLine(Libro.Descripcion);
                //    Console.WriteLine(Libro.FechaPublicacion);
                //    Console.WriteLine("------------------------");
                //}
                //Console.ReadLine();

                ////-----------------------------------------------------------------------------------------------------------

                // CONSULTA CON TABLA LIBRO RELACIONADA CON PRECIO POR FK
                // USO INCLUDE PARA DECIRLE CUÁL ES LA FK
                //var libros = db.Libro.Include(x => x.PrecioPromocion).AsNoTracking();
                //foreach (var libro in libros)
                //{
                //// libro.PrecioPromocion.PrecioActual PARA ITERAR ENTRE LAS PROPERTYS DE LA ENTIDAD PRECIOPROMOCION RELACIONADA POR FK 
                //    Console.WriteLine(libro.Titulo + " -- $" + libro.PrecioPromocion.PrecioActual);
                //}
                //Console.ReadLine();

                ////-----------------------------------------------------------------------------------------------------------

                // CONSULTA CON TABLA LIBRO RELACIONADA CON COMENTARIOS POR FK
                // USO INCLUDE PARA DECIRLE CUÁL ES LA FK
                //var libros = db.Libro.Include(x => x.ComentarioLista).AsNoTracking();
                //foreach (var libro in libros)
                //{
                //    Console.WriteLine("Libro: " + libro.Titulo);
                //    // COMO ComentarioLista ES UN ITERABLE, DEBO RECORRERLO CON UN FOREACH
                //    foreach (var comentario in libro.ComentarioLista)
                //    {
                //        Console.WriteLine("Puntaje: " + comentario.Puntaje);
                //        Console.WriteLine("Comentarios: " + comentario.ComentarioTexto);
                //        Console.WriteLine("-----------------------------------------------");
                //    }
                //}
                //Console.ReadLine();

                ////-----------------------------------------------------------------------------------------------------------

                //// CONSULTA CON TABLA LIBRO RELACIONADA CON LIBROAUTOR POR FK RELACIONADA A SU VEZ CON AUTOR
                //// Uso ThenInclude para seguir la cadena de relaciones
                //var libros = db.Libro.Include(x => x.AutorLink).ThenInclude(xi => xi.Autor).AsNoTracking();
                //foreach (var libro in libros)
                //{
                //    Console.WriteLine(libro.Titulo);
                //    // Luego itero en lo que traje 
                //    foreach (var AutLink in libro.AutorLink)
                //    {
                //        Console.WriteLine("Nombre Autor: " + AutLink.Autor.Nombre);
                //        Console.WriteLine("-----------------");
                //    }
                //}
                //Console.ReadLine();

                ////-----------------------------------------------------------------------------------------------------------

                //// --------------------------- INSERT --------------------------- 
                //// INSTANCIO LA CLASE QUE DESEO INSERTAR
                //var nuevoAutor1 = new Autor
                //{
                //    Nombre = "Pedro",
                //    Apellido = "Paredes",
                //    Grado = "Crack",
                //};
                //// Cargo en el DbContext la clase que deseo insertar:
                //db.Add(nuevoAutor1);
                //
                //// INSTANCIO LA CLASE QUE DESEO INSERTAR
                //var nuevoAutor2 = new Autor
                //{
                //    Nombre = "Camila",
                //    Apellido = "Lozano",
                //    Grado = "Otra Crack",
                //};
                //// Cargo en el DbContext la clase que deseo insertar:
                //db.Add(nuevoAutor2);
                //
                //// Dispara el comando y devuelve el estado de transacción contando la cantidad de "linas" que se modificaron. 
                //// Lo almaceno en una variable
                //var estadoTransaccon = db.SaveChanges();
                //
                //Console.WriteLine("Estado de transacción: " + estadoTransaccon);

                ////-----------------------------------------------------------------------------------------------------------

                //// --------------------------- UPDATE --------------------------- 
                //// .Single viene a ser como un Where en SQL, en el comando que sigue le digo Where Autor. Nombre == "Pedro"
                //var autor = db.Autor.Single(x => x.Nombre == "Pedro");
                ////Verfico que haya encontrado el Autor que buscaba diciendo que autor sea distinto que null
                //if (autor != null)
                //{
                //    // Cargo los datos que deseo updatear
                //    autor.Apellido = "Mendez";
                //    autor.Grado = "Biologo";
                //    // Disparo la consulta
                //    var estadoTransaccon = db.SaveChanges();
                //    Console.WriteLine(estadoTransaccon);
                //}

                ////-----------------------------------------------------------------------------------------------------------

                //// --------------------------- DELETE --------------------------- 
                // .Single viene a ser como un Where en SQL, en el comando que sigue le digo Where Autor. Id == 7
                //var Autor = db.Autor.Single(x => x.AutorId == 7);
                //// Verfico que haya encontrado el Autor que buscaba diciendo que autor sea distinto que null
                //if (Autor != null)
                //{
                //    // Remove hace referencia al método Delete de SQL
                //    db.Remove(Autor);
                //    // Disparo la consulta
                //    var estado = db.SaveChanges();
                //    Console.WriteLine("El estado de la transacción es: " + estado);
                //}
            }
        }
    }
}