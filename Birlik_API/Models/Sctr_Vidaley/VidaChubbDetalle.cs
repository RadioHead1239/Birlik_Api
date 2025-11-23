using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class VidaChubbDetalle
    {
        [Key]
        public int Id_VidaChubbTemp { get; set; }
        public string PNombre { get; set; }
        public string SNombre { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Movimiento { get; set; }
        public string TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public string Genero { get; set; }
        public string FecNac { get; set; }
        public decimal Remuneracion { get; set; }
        public string fk_usuario { get; set; }
        public int? Fk_SeguroResumen { get; set; }

        public int? Fk_cliente { get; set; }

        public int? Fk_poliza { get; set; }

    }
}
