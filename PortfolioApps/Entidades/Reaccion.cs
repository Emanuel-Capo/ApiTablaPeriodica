namespace PortfolioApps.Entidades
{
    public class Reaccion
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public List<Elemento> Elemento { get; set;} = new List<Elemento>();
    }
}
