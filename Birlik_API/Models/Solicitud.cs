using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Solicitud
{
    public int IdSolicitud { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public string? TipoSolicitud { get; set; }

    public string? DescripcionSolicitud { get; set; }

    public string? EstadoSolicitud { get; set; }

    public string? Usuario { get; set; }

    public string? FkUsuario { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }
}
