using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_ViajeroTemp
    {
        [Key]
        public int Id_Ramo_ViajeroTemp { get; set; }

        public int items { get; set; }

        public string tipo_plan { get; set; }

        public string origen { get; set; }

        public string destino { get; set; }

        public string contacto_emergencia { get; set; }

        public decimal pn { get; set; }

        public decimal pt { get; set; }

        public decimal comision { get; set; }

        public decimal montoComision { get; set; }

        public string fk_usuario { get; set; }


    }
}
