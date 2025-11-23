using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class SolicitudCliente
    {
        [Key]
        public int Id_SolicitudCliente { get; set; }

        public DateTime InicioSolicitud { get; set; } // Se crea cuando el cliente lo solicita: (SOFT) : Cuando tiene usuario y Validando su RUC

        public DateTime? FinSolicitud { get; set; } = null; // Se crea cuando el usuario adjunta las constancias y sale el envio de mensaje (SOFT)

        public string UsuarioIniciaSolicitud { get; set; } = string.Empty; // Se crea cuando el cliente lo solicita: (SOFT) - (Validar si realiza 2 o 3 veces la descarga) (SOFT)

        public string UsuarioTerminaSolicitud { get; set; } = string.Empty; // Se crea cuando el usuario adjunta las constancias y sale el envio de mensaje (SOFT)

        public string TipoError { get; set; } = "Ninguno"; // Se crea cuando el robot falla algun procedimiento, lo clasificamos (RPA)

        public string DetalleError { get; set; } = "Ninguno"; // Se crea cuando el robot falla algun procedimiento y apuntamos el detalle (RPA)

        public DateTime? FechaNotificacionError { get; set; } = null; // Para saber a que hora el robot aviso al ejecutivo (RPA)

        public string TipoRegistro { get; set; } // Solicitud Inclucion, Solicitud Renovacion - Se crea cuando el cliente lo solicita: (SOFT)

        public int Fk_Poliza { get; set; } // Se crea cuando el cliente lo solicita: (SOFT)
         
        public int Bloque_RH { get; set; } // Se crea cuando el cliente lo solicita: (SOFT)

        public string NombreRamo { get; set; } // Se crea cuando el cliente lo solicita: (SOFT)

        public string Clasificacion { get; set; } // Riesgos Humanos

        public string EstadoSolicitud { get; set; } = "Pendiente"; // Pendiente (cuando se crea), En Proceso (cuando se descarga el excel), Finalizada (cuando se envia las constancias por email)
    }
}
