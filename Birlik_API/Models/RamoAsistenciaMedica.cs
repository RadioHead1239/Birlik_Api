using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoAsistenciaMedica
{
    public int IdRamoAsistenciaMedica { get; set; }

    public int FkCliente { get; set; }

    public int FkPoliza { get; set; }

    public int Items { get; set; }

    public string? Contratante { get; set; }

    public string? Asegurado { get; set; }

    public string? Parentesco { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? FechaNacimiento { get; set; }
}
