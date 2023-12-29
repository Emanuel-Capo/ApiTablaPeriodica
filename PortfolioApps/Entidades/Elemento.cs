namespace PortfolioApps.Entidades
{
    public class Elemento
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int NroAtomico { get; set; }
        public string Simbolo { get; set; }
        public List<int> ValenciaM { get; set; } = new List<int>();
        public List<int> ValenciaNM { get; set; } = new List<int>();
        public bool Especial { get; set; }
        public int Posicion { get; set; }
        public string Wiki { get; set; }
        public string? Prefijo { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
        public List<Reaccion> Reacciones { get; set; }= new List<Reaccion>();

    }
}
