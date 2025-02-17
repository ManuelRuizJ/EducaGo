using EducaGo.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducaGo.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<RecursoEducativo> RecursosEducativos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasIndex(u => u.Correo).IsUnique();
            modelBuilder.Entity<Estudiante>().HasIndex(e => e.Correo).IsUnique();
            modelBuilder.Entity<Profesor>().HasIndex(p => p.Correo).IsUnique();
            modelBuilder.Entity<RecursoEducativo>().HasIndex(c => c.Nombre).IsUnique();



        }
    }
}
