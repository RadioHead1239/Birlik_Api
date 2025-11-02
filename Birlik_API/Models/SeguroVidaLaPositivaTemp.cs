using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroVidaLaPositivaTemp
{
    public int IdVidaLaPositivaTemp { get; set; }

    public string? Nombres { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? TipoTrab { get; set; }

    public string? TipoDoc { get; set; }

    public string? NroDoc { get; set; }

    public string? Sexo { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Moneda { get; set; }

    public decimal? Sueldo { get; set; }

    public string? FechaIngreso { get; set; }

    public int? Item { get; set; }

    public string? FkUsuario { get; set; }

    public DateOnly? FechaNac { get; set; }
}
