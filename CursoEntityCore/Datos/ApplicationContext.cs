using CursoEntityCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoEntityCore.Datos
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> opciones) : base(opciones) 
        {
        
        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
