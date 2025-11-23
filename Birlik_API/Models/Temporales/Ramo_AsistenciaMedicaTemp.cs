using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_AsistenciaMedicaTemp
    {
        [Key]
        public int Id_Ramo_AsistenciaMedicaTemp { get; set; }

        public int items { get; set; }

        public string contratante { get; set; }

        public string asegurado { get; set; }

        public string parentesco { get; set; }

        public string tipo_documento { get; set; }

        public string numero_documento { get; set; }

        public string fecha_nacimiento { get; set; }
        public string fk_usuario { get; set; }

    }
}
