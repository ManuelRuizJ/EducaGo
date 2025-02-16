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
    }
}
