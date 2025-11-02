using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroVidaCrecerTemp
{
    public int IdVidaCrecerTemp { get; set; }

    public string? ApPaterno { get; set; }

    public string? ApMaterno { get; set; }

    public string? Nombre1 { get; set; }

    public string? Nombre2 { get; set; }

    public string? Nacionalidad { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumDocumento { get; set; }

    public string? Sexo { get; set; }

    public string? EstadoCivil { get; set; }

    public string? TipoTrabajador { get; set; }

    public decimal? Sueldo { get; set; }

    public int? Item { get; set; }

    public string? FkUsuario { get; set; }

    public DateOnly? FechaNac { get; set; }
}
