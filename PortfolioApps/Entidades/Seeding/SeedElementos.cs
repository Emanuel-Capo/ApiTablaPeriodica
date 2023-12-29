using Microsoft.EntityFrameworkCore;

namespace PortfolioApps.Entidades.Seeding
{
    public class SeedElementos
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var H = new Elemento
            {
                Id = 1,
                Nombre = "Hidrógeno",
                NroAtomico = 1,
                Simbolo = "H",
                ValenciaM = [],
                ValenciaNM = [],
                Especial = false,
                Posicion = 1,
                Wiki = "Hidrógeno",
                Prefijo = null,
                GrupoId = 5,
            };
            var He = new Elemento
            {
                Id = 2,
                Nombre = "Helio",
                NroAtomico = 2,
                Simbolo = "He",
                ValenciaM = [],
                ValenciaNM = [],
                Especial = false,
                Posicion = 18,
                Wiki = "Helio",
                Prefijo = null,
                GrupoId = 8,
            };
            var Li = new Elemento
            {
                Id = 3,
                Nombre = "Litio",
                NroAtomico = 3,
                Simbolo = "Li",
                ValenciaM = [1],
                ValenciaNM = [],
                Especial = false,
                Posicion = 19,
                Wiki = "Litio",
                Prefijo = null,
                GrupoId = 1,
            };
            var Be = new Elemento
            {
                Id = 4,
                Nombre = "Berilio",
                NroAtomico = 4,
                Simbolo = "Be",
                ValenciaM = [2],
                ValenciaNM = [],
                Especial = false,
                Posicion = 20,
                Wiki = "Berilio",
                Prefijo = null,
                GrupoId = 2,
            };
            var B = new Elemento
            {
                Id = 5,
                Nombre = "Boro",
                NroAtomico = 5,
                Simbolo = "B",
                ValenciaM = [],
                ValenciaNM = [3],
                Especial = false,
                Posicion = 31,
                Wiki = "Boro",
                Prefijo = "bor",
                GrupoId = 6,
            };
            var C = new Elemento
            {
                Id = 6,
                Nombre = "Carbono",
                NroAtomico = 6,
                Simbolo = "C",
                ValenciaM = [],
                ValenciaNM = [2,4],
                Especial = false,
                Posicion = 32,
                Wiki = "Carbono",
                Prefijo = "carbon",
                GrupoId = 5,
            };
            var N = new Elemento
            {
                Id = 7,
                Nombre = "Nitrógeno",
                NroAtomico = 7,
                Simbolo = "N",
                ValenciaM = [],
                ValenciaNM = [3, 5],
                Especial = false,
                Posicion = 33,
                Wiki = "Nitrógeno",
                Prefijo = "nitr",
                GrupoId = 5,
            };
            var O = new Elemento
            {
                Id = 8,
                Nombre = "Oxígeno",
                NroAtomico = 8,
                Simbolo = "O",
                ValenciaM = [],
                ValenciaNM = [],
                Especial = false,
                Posicion = 34,
                Wiki = "Oxígeno",
                Prefijo = null,
                GrupoId = 5,
            };
            var F = new Elemento
            {
                Id = 9,
                Nombre = "Flúor",
                NroAtomico = 9,
                Simbolo = "F",
                ValenciaM = [],
                ValenciaNM = [1],
                Especial = false,
                Posicion = 35,
                Wiki = "Flúor",
                Prefijo = "fluor",
                GrupoId = 5,
            };
            var Ne = new Elemento
            {
                Id = 10,
                Nombre = "Neón",
                NroAtomico = 10,
                Simbolo = "Ne",
                ValenciaM = [],
                ValenciaNM = [],
                Especial = false,
                Posicion = 36,
                Wiki = "Neón",
                Prefijo = null,
                GrupoId = 8,
            };


            modelBuilder.Entity<Elemento>().HasData(H, He, Li, Be, B, C, N, O, F, Ne);
        }
    }
}
