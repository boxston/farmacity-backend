using Farmacity_Backend.Entity;
using Microsoft.EntityFrameworkCore;

namespace Farmacity_Backend
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().Property(e => e.Precio).HasPrecision(18,2);
            modelBuilder.Entity<Producto>().Property(e => e.Nombre).HasMaxLength(50);
            modelBuilder.Entity<CodigoBarra>().Property(e => e.Codigo).HasMaxLength(13);
        }

        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<CodigoBarra> CodigoBarras => Set<CodigoBarra>();
    }
}
