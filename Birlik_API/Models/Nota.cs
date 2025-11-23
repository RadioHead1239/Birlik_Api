using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Nota
    {
        [Key]
        public int Id_Nota { get; set; }

        public string TipoNota { get; set; }

        public string DescripcionNota { get; set; }

        public DateTime FechaRegistroNota { get; set; }

        public int Fk_Cuota { get; set; }

        public int Fk_CLienteNota { get; set; }

        public int Fk_Poliza { get; set; }

        public string Fk_Usuario { get; set; }

        public DateTime? FechaRecordatorio { get; set; }

    }
}
