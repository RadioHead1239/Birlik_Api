using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Eps
    {
        [Key]
        public int Id_Ramo_Eps { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

        public int items { get; set; }

        public string contratante { get; set; }

        public string asegurado { get; set; }

        public string codigoAfiliado { get; set; }

        public string parentesco { get; set; }

        public string tipo_documento { get; set; }

        public string numero_documento { get; set; }

        public string fecha_nacimiento { get; set; }



    }
}
