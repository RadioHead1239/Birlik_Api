using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroVidaMapfreTemp
{
    public int IdVidaMapfreTemp { get; set; }

    public string? TipDoc { get; set; }

    public string? NumDoc { get; set; }

    public string? ApePaterno { get; set; }

    public string? ApeMaterno { get; set; }

    public string? Nombres { get; set; }

    public decimal? Sueldo { get; set; }

    public string? Ocupacion { get; set; }

    public string? TipRiesgo { get; set; }

    public string? NombreCompleto { get; set; }

    public int? Item { get; set; }

    public string? FkUsuario { get; set; }

    public DateOnly? Nacimiento { get; set; }
}
