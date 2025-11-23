using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Incendio
    {
        [Key]
        public int Id_Ramo_Incendio { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }




    }
}
