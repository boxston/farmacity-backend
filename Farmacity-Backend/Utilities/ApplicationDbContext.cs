using Farmacity_Backend.Entity;
using Microsoft.EntityFrameworkCore;

namespace Farmacity_Backend.Utilities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().Property(e => e.Precio).HasPrecision(18, 2);
            modelBuilder.Entity<Producto>().Property(e => e.Nombre).HasMaxLength(50);
            modelBuilder.Entity<Producto>().Property(e => e.FechaAlta).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<CodigoBarra>().Property(e => e.FechaAlta).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<CodigoBarra>().Property(e => e.Codigo).HasMaxLength(13).IsRequired(true);

            modelBuilder.Entity<Producto>().HasKey(p => p.Id);

            modelBuilder.Entity<CodigoBarra>().HasKey(cb => new { cb.ProductoId, cb.Codigo });

            modelBuilder.Entity<Producto>()
                .HasMany(p => p.CodigoBarras)
                .WithOne(cb => cb.Producto)
                .HasForeignKey(cb => cb.ProductoId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<CodigoBarra> CodigoBarras => Set<CodigoBarra>();
    }
}
