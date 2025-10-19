using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class VidaProtectaDetalle
{
    public int IdVidaProtectaDetalle { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumDocumento { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApelidoMaterno { get; set; }

    public string? Nombres { get; set; }

    public string? Sexo { get; set; }

    public string? FechaNac { get; set; }

    public string? TipoTrabajador { get; set; }

    public decimal? SueldoBruto { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Celular { get; set; }

    public string? Sede { get; set; }

    public string? TipoMovimiento { get; set; }

    public string? PaisNacimiento { get; set; }

    public int? FkSeguroResumen { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }
}
