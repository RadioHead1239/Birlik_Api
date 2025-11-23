using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class PrimaMinima
    {
        [Key]
        public int Id_PrimaMinima { get; set; }

        public string? PrimaMinimaEmision { get; set; }

        public string? PrimaMinimaRenovacion { get; set; }

        public string? PrimaMinimaInclusion { get; set; }

        public int Fk_CompaniaSeguro { get; set; }

    }
}
