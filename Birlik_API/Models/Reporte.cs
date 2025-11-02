using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Reporte
{
    public int IdReporte { get; set; }

    public string? FkUsuario { get; set; }

    public string? Json { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaReunion { get; set; }

    public string? EstadoReunion { get; set; }
}
