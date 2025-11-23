using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Poliza
    {
        [Key]
        public int Id_Poliza { get; set; }

        public int Fk_Cliente { get; set; }

        [Required(ErrorMessage = "El numero de poliza es obligatorio")]
        public string NumeroPoliza { get; set; }

        public string Asegurado { get; set; }

        public int Fk_SubAgente { get; set; }

        [Required(ErrorMessage = "Compañia de Seguro obligatorio")]
        public int FK_Compania { get; set; }

        [Required(ErrorMessage = "Ramo obligatorio")]
        public int Fk_Ramo { get; set; }

        [Required(ErrorMessage = "Producto obligatorio")]
        public string ProductoRamo { get; set; }

        [Required(ErrorMessage = "Tipo de vigencia obligatorio")]
        public string TipoVigencia { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaEmisionPoliza { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime VigenciaInicio { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime VigenciaFin { get; set; }

        [Required(ErrorMessage = "Moneda Obligatorio")]
        public string Moneda { get; set; }

        [Required(ErrorMessage = "Descripcion Obligatorio")]
        public string DescripcionPoliza { get; set; }

        public DateTime FechaRegistroPoliza { get; set; }

        public string EstadoPoliza { get; set; }

        [Range(typeof(decimal), "0.00", "100.00")]
        public decimal ComisionBroker { get; set; }

        [Range(typeof(decimal), "0.00", "100.00")]
        public decimal ComisionSubAgente { get; set; }

        public string Fk_usuario { get; set; }

        // ESTE VALOR CORRESPONDE AL ID DE LA POLIZA A RENOVAR
        public int Engranaje { get; set; }

        //ESTE VALOR CORRESPONDE AL NUMERO DE RENOVACION QUE TIENE LA POLIZA
        public int Cantidad_Renovacion { get; set; }

        //Esto es necesario para identificar si hay polizas que se crearon juntas - RIESGOS HUMANOS
        public int Trazabilidad { get; set; }

        public int Bloque_RH { get; set; }

        public string Sede { get; set; }

        public string ObtencionPoliza { get; set; }

    }
}
