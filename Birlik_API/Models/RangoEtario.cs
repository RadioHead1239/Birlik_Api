using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class RangoEtario
    {

        [Key]
        public int Id_RangoEtario { get; set; }

        public string TipoRangoEtario { get; set; }

        public string Texto { get; set; }

        public int Valor1 { get; set; }

        public int Valor2 { get; set; }

        public int Fk_Poliza { get; set; }

        public decimal TasaRangoEtario { get; set; }


    }
}
