using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class CorreoHistorial
{
    public int IdCorreoHistorial { get; set; }

    public string? Asunto { get; set; }

    public string? Cuerpo { get; set; }

    public string? DestinatariosExito { get; set; }

    public string? DestinatariosError { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Estado { get; set; }

    public string? Error { get; set; }
}
