using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroDetalle
{
    public int IdSeguroDetalle { get; set; }

    public int? FkSeguroResumen { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumDocumento { get; set; }

    public string? ApPaterno { get; set; }

    public string? ApMaterno { get; set; }

    public string? Nombres { get; set; }

    public string? NombresCompletos { get; set; }

    public string? TipoSeguro { get; set; }

    public decimal? Sueldo { get; set; }

    public string? TipoTrabajador { get; set; }

    public string? EstadoTrabajador { get; set; }

    public DateTime? FechaRetiro { get; set; }
}
