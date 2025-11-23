using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Birlik.Models.Entities
{
    public class    DetalleUsuario
    {
        [Key]
        public int Id_DetalleUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string Fk_User { get; set; }

        public string CargoUsuario { get; set; }

        public string IdiomaUsuario { get; set; }

        public string CelularUsuario { get; set; }

        public string ApellidoUsuario { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaIngreso { get; set; }

        public string? ImagenUsuario { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ImagenUsuarioFile { get; set; }

        public int Fk_Cliente { get; set; }

        public string Fk_Supervisor { get; set; }

        public string Correo { get; set; }

        public string ClaveCorreo { get; set; }

        public DateTime UltimaConexion { get; set; }

        public string RolUsuario { get; set; }

        public string EstadoUsuario { get; set; }

        public int Puntuacion { get; set; }

        public string ResponsablePorVacaciones { get; set; }

        public string Sexo { get; set; } // F y M

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ImagenFirmaFile { get; set; }

        public string? ImagenFirma { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ImagenFirmaCorreoFile { get; set; }

        public string? ImagenFirmaCorreo { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile AntecedentesFile { get; set; }

        public string? Antecedentes { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile HojaVidaFile { get; set; }

        public string? HojaVida { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile CopiaDNIFile { get; set; }

        public string? CopiaDNI { get; set; }

        public string EstadoTrabajo { get; set; }

        public string? FormaTrabajo { get; set; }

        public int NumeroGrupo { get; set; }

        public string enviarMensaje { get; set; }

        public string PortadaUsuario { get; set; }

        public int Fk_Organizacion { get; set; }

        public int GrupoEmpresa { get; set; }

        public string TipoInformacion { get; set; } // Fk_Cliente o Fk_Poliza (para saber como trabaja el cliente)

        public string PolizasAsignada { get; set; } // Si trabaja con fk_poliza entonces aqu iestara las polizas asignadas mediante comas

    }
}
