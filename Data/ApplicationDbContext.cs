using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinanzasHogar.Models;

using Microsoft.AspNetCore.Identity;

namespace FinanzasHogar.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Activo> Activos { get; set; }
        public DbSet<Pasivo> Pasivos { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Activo>(entity =>
            {
                entity.Property(e => e.Valor).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Pasivo>(entity =>
            {
                entity.Property(e => e.Monto).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Ingreso>(entity =>
            {
                entity.Property(e => e.Monto).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.Property(e => e.Monto).HasColumnType("decimal(18,2)");
            });
        }
    }
}
