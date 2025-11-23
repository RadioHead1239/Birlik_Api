using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Seguro_PacificoEpsTemp
    {
        [Key]
        public int Id_PacificoEpsTemp { get; set; }

        public int NumeroDependiente { get; set; }

        public int CodigoTipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Nombre { get; set; }

        public string FechaNacimiento { get; set; }

        public string MonedaSueldo { get; set; }

        public decimal Tarifa { get; set; }

        public string Plan { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }
    }
}
