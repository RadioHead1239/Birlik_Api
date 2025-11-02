using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SolicitudCliente
{
    public int IdSolicitudCliente { get; set; }

    public DateTime InicioSolicitud { get; set; }

    public DateTime? FinSolicitud { get; set; }

    public string UsuarioIniciaSolicitud { get; set; } = null!;

    public string UsuarioTerminaSolicitud { get; set; } = null!;

    public string TipoError { get; set; } = null!;

    public string DetalleError { get; set; } = null!;

    public DateTime? FechaNotificacionError { get; set; }

    public string TipoRegistro { get; set; } = null!;

    public int FkPoliza { get; set; }

    public int BloqueRh { get; set; }

    public string NombreRamo { get; set; } = null!;

    public string Clasificacion { get; set; } = null!;

    public string? EstadoSolicitud { get; set; }
}
