using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class CorreoHistorialError
{
    public int IdCorreoHistorialError { get; set; }

    public string? Destinatario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Error { get; set; }

    public int? FkCorreoHistorial { get; set; }
}
