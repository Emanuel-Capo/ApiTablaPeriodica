using Microsoft.EntityFrameworkCore;
using PortfolioApps.Entidades;
using PortfolioApps.Entidades.Seeding;
using System.Reflection;

namespace PortfolioApps
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingInicial.Seed(modelBuilder);
            SeedElementos.Seed(modelBuilder);
            SeedElementoReaccion.Seed(modelBuilder);
        }

        public DbSet<Elemento> Elementos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        //public DbSet<ElementoReaccion> ElementoReacciones { get; set; }
        public DbSet<Reaccion> Reacciones { get; set; }
    }
}
