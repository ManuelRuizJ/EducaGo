using EducaGo.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace EducaGo.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasIndex(u => u.Correo).IsUnique();
        }
    }
}
