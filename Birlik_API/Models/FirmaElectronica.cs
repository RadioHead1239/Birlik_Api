using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class FirmaElectronica
{
    public int IdFirma { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? FkUsuario { get; set; }

    public string? Observacion { get; set; }

    public string? Rol { get; set; }

    public int? FkReporte { get; set; }
}
