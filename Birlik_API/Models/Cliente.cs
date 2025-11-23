using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una opcion")]
        [Column(TypeName = "nvarchar(50)")]
        public string TipoPersona { get; set; } //NATURAL - JURIDICO

        [Required(ErrorMessage = "El contratante es obligatorio")]
        public string NombreTipoPersona { get; set; } // Razon Social - Nombres y Apellidos

        [Required(ErrorMessage = "Debe seleccionar una opcion")]
        public string TipoDocumento { get; set; } // DNI/CEDULA - RUC - CEX - PAS

        [Required(ErrorMessage = "El numero de documento es obligatorio")]
        public string NumeroDocumento { get; set; }

        [Required(ErrorMessage = "La dirección es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El distrito es obligatorio")]
        public string Distrito { get; set; } //Distrito - Barrio - Comuna

        [Required(ErrorMessage = "La ciudad es obligatorio")]
        public string Ciudad { get; set; } //Departamento - Ciudad - Region

        [Required(ErrorMessage = "La provincia es obligatorio")]
        public string Provincia { get; set; } // Provincia - Region

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono1 { get; set; }

        public string? Telefono2 { get; set; }

        [Required(ErrorMessage = "El Email del contratante es obligatorio")]
        public string Email { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        [Required(ErrorMessage = "Seleccione una opcion")]
        public DateTime? FechaNacimiento { get; set; } //Cumpleaños o Aniversarios

        public string? Profesion { get; set; } //Profesion - Ocupacion

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime? VencimientoLicenciaConducir { get; set; }

        public string? Referencia { get; set; } //De donde lo conoces

        [Required(ErrorMessage = "Seleccione una opcion")]
        public int Fk_Subagente { get; set; } // Otra Tabla: Sub agente - Vendedor (Birlik - Cesar Chero - Denissa Castro )

        public int Fk_GrupoEconomico { get; set; } // Otra Tabla: Actualmente Ninguno

        public int Fk_GiroNegocio { get; set; } //Otra Tabla: Textil - Ingenieria - Gestion - ETC

        public string? CartaNombramiento { get; set; }

        public string? DniDocumento { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile DniDocumentoFile { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile CartaFile { get; set; }


        //PERSONA DE CONTACTO
        [Required(ErrorMessage = "El nombre del contacto es obligatorio")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El Email del contacto es obligatorio")]
        public string EmailContacto { get; set; }
        [Required(ErrorMessage = "El celular del contacto es obligatorio")]
        public string Celular { get; set; }

        public string? Observacion { get; set; }


        //ingresando el id del usuario
        public string Fk_usuario { get; set; }

        public DateTime FechaCreacion { get; set; }

        //AGREGANDO UNA IMAGEN
        public string? Imagen { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ImagenFile { get; set; }

        //fECHA ANTIGUEDAD CON LA QUE TRABAJA
        [Required(ErrorMessage = "La fecha es obligatorio")]
        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime? FechaAntiguedad { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime? FechaMaximoFinPoliza { get; set; }

        public int NumeroPolizas { get; set; }

        [Required(ErrorMessage = "Selecciona una opcion")]
        public string EjecutivoResponsable { get; set; }

        public string EjecutivoProvisional { get; set; }

        [NotMapped]
        public string EjecutivoProvisionalNombre { get; set; }

        public string EstadoCliente { get; set; } //Activo - Desactivo

        [NotMapped]
        public string ImagenEjecutivo { get; set; }

        public bool FacturaXML { get; set; } //Activo - Desactivo

        public int? Grupo { get; set; }

    }
}
