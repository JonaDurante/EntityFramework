using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EntityFrameworkProj
{

    public class AppVentaLibrosContext : DbContext
    {
        private const string connectionString = @"Data Source=NKO\SQLEXPRESS; Initial Catalog=LibrosWeb; Integrated Security=True";


        //Encargado de crear la instancia hacia el servidor sql server con el que nos queremos conectar
        //Se debe sobreescribir el método Void OnConfiguring el cual recibe como parametro de entrada un DbContextOptionsBuilder optionsBuilder
        //Al ser protected, me aseguro que las clases que lo hereden, tengan acceso a el.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Defino la conexion asignandole el connection string
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Le digo a EntityFrameworkCore que poseo una tabla con dos claves foraneas usando HasKey y diciendole el nombre de estas FK
        // Siempre que tenga una tabla con más de una FK debo utilizar este método.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibroAutor>().HasKey(xi => new { xi.AutorId, xi.LibroId });
        }

        // Creo entidades con DbSet partiendo de las clases .cs 
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<LibroAutor> LibroAutor { get; set; }
    }
}
