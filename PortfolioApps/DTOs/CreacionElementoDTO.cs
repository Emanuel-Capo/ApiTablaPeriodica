namespace PortfolioApps.DTOs
{
    public class CreacionElementoDTO
    {
        public string Nombre { get; set; } = null!;
        public int NroAtomico { get; set; }
        public string Simbolo { get; set; }
        public List<int> ValenciaM { get; set; } = new List<int>();
        public List<int> ValenciaNM { get; set; } = new List<int>();
        public bool Especial { get; set; }
        public int Posicion { get; set; }
        public string Wiki { get; set; }
        public string Prefijo { get; set; }
        public int GrupoId { get; set; }
    }
}
