using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Ticket
    {
        [Key]
        public int Id_Ticket { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una opcion")]
        public string TipoTicket { get; set; }

        public string? TrabajadorDNI { get; set; }

        public decimal ValorTicket { get; set; }

        public string? TextoTicket { get; set; }

        public string? GeneracionTicket { get; set; }

        public string EstadoTicket { get; set; } //Abierto - Asignado - Cerrado
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }

        //AGREGANDO UNA IMAGEN
        public string? ImagenTicket { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ImagenTicket_File { get; set; }

        public string AsignadoA { get; set; }

        [Required(ErrorMessage = "Ingresar una opcion")]
        public string DescripcionTicket { get; set; }
        public string? RespuestaTicket { get; set; }

        public string Fk_Usuario { get; set; }

        public string Fk_Polizas { get; set; }

        public string Fk_Cuotas { get; set; }

        public int Fk_Cliente { get; set; }

        public string Fk_Responsable { get; set; }

        [NotMapped]
        public List<string> ListaPolizas { get; set; }

        [NotMapped]
        public List<string> ListaCuotas { get; set; }

        public DateTime? FechaModificable1 { get; set; }

        public DateTime? FechaModificable2 { get; set; }

        public DateTime? FechaModificable3 { get; set; }

    }
}
