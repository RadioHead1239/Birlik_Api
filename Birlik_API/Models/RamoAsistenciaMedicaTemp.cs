using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoAsistenciaMedicaTemp
{
    public int IdRamoAsistenciaMedicaTemp { get; set; }

    public int Items { get; set; }

    public string? Contratante { get; set; }

    public string? Asegurado { get; set; }

    public string? Parentesco { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? FechaNacimiento { get; set; }

    public string? FkUsuario { get; set; }
}
