namespace Birlik.Models.Entities
{
    public class EstadoPolizaMensual
    {
        public int Mes { get; set; } 
        public int TotalVencidas { get; set; }
        public int Anuladas { get; set; }
        public int NoRenovadas { get; set; }
        public int Renovadas { get; set; }
        public int PendientesPorRenovar { get; set; }

    }
}
