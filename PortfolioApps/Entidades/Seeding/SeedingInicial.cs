using Microsoft.EntityFrameworkCore;

namespace PortfolioApps.Entidades.Seeding
{
    public class SeedingInicial
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var MetalAlcalino = new Grupo
            {
                Id = 1,
                Nombre = "Metal alcalino",
            };
            var MetalAlcalinoterreos = new Grupo
            {
                Id = 2,
                Nombre = "Metal alcalinotérreo",
            };
            var MetalTransicional = new Grupo
            {
                Id = 3,
                Nombre = "Metal transicional",
            };
            var MetalPostransicional = new Grupo
            {
                Id = 4,
                Nombre = "Metal postransicional",
            };
            var NoMetalReactivo = new Grupo
            {
                Id = 5,
                Nombre = "No metal reactivo",
            };
            var Metaloides = new Grupo
            {
                Id = 6,
                Nombre = "Metaloides",
            };
            var Halogeno = new Grupo
            {
                Id = 7,
                Nombre = "Halógeno",
            };
            var GasNoble = new Grupo
            {
                Id = 8,
                Nombre = "Gas noble",
            };
            var Lantanido = new Grupo
            {
                Id = 9,
                Nombre = "Lantánido",
            };
            var Actinido = new Grupo
            {
                Id = 10,
                Nombre = "Actínido",
            };
            var Desconocido = new Grupo
            {
                Id = 11,
                Nombre = "Desconocido",
            };

            modelBuilder.Entity<Grupo>().HasData(
                MetalAlcalino,
                MetalAlcalinoterreos,
                MetalTransicional,
                MetalPostransicional,
                NoMetalReactivo,
                Metaloides,
                Halogeno,
                GasNoble,
                Lantanido,
                Actinido, 
                Desconocido);

            var OxidoMetalico = new Reaccion
            {
                Id = 1,
                Nombre = "Óxido metálico"
            };
            var OxidoNoMetalico = new Reaccion
            {
                Id = 2,
                Nombre = "Óxido no metálico"
            };
            var Hidroxido = new Reaccion
            {
                Id = 3,
                Nombre = "Hidróxido"
            };
            var Acido = new Reaccion
            {
                Id = 4,
                Nombre = "Ácido"
            };
            var Hidracido = new Reaccion
            {
                Id = 5,
                Nombre = "Hidrácido"
            };
            var HidruroMetalico = new Reaccion
            {
                Id = 6,
                Nombre = "Hidruro metálico"
            };
            var Sal = new Reaccion
            {
                Id = 7,
                Nombre = "Sal"
            };
            var SalHidrácido = new Reaccion
            {
                Id = 8,
                Nombre = "Sal de hidrácido"
            };

            modelBuilder.Entity<Reaccion>().HasData(
                OxidoMetalico,
                OxidoNoMetalico,
                Hidroxido,
                Acido,
                Hidracido,
                HidruroMetalico,
                Sal,
                SalHidrácido);
        }
    }
}
