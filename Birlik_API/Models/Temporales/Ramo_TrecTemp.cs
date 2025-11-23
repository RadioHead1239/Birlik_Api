using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class Ramo_TrecTemp
    {
        [Key]
        public int Id_Ramo_TrecTemp { get; set; }
        public int items { get; set; }
        public string departamento_Peru { get; set; }
        public string uso { get; set; }
        public string ubicacion { get; set; }
        public string tipo_trabajo { get; set; }
        public string descripcion_maquinaria { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string nro_de_motor { get; set; }
        public string nro_Serie { get; set; }
        public int fabricacion { get; set; }
        public string endosatario { get; set; }
        public decimal sumaAsegurada { get; set; }
        public decimal tasaRiesgo { get; set; }
        public decimal pn { get; set; }
        public decimal pc { get; set; }
        public decimal pt { get; set; }
        public decimal comision { get; set; }
        public decimal montoComision { get; set; }
        public string siniestralidad { get; set; }

        public string fk_usuario { get; set; }
    }
}
