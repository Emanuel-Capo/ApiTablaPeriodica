using Microsoft.EntityFrameworkCore;

namespace PortfolioApps.Entidades.Seeding
{
    public class SeedElementoReaccion
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity("ElementoReaccion").HasData(
                new Dictionary<string, object> { ["ElementoId"] = 3, ["ReaccionesId"] = 1 },
                new Dictionary<string, object> { ["ElementoId"] = 3, ["ReaccionesId"] = 3 },
                new Dictionary<string, object> { ["ElementoId"] = 3, ["ReaccionesId"] = 6 },
                new Dictionary<string, object> { ["ElementoId"] = 3, ["ReaccionesId"] = 7 },
                new Dictionary<string, object> { ["ElementoId"] = 3, ["ReaccionesId"] = 8 } 
                );
        }
    }
}
