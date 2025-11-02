using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class LaPositivaMineraDetalle
{
    public int IdLaPositivaMineraDetalle { get; set; }

    public string? Numero { get; set; }

    public string? RazonSocial { get; set; }

    public string? Ruc { get; set; }

    public string? UnidadMinera { get; set; }

    public string? Dni { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? Nombres { get; set; }

    public string? PuestoTrabajo { get; set; }

    public string? Categoria { get; set; }

    public string? FechaNacimiento { get; set; }

    public string? Clinica { get; set; }

    public decimal? Remuneracion { get; set; }

    public int? FkSeguroResumen { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }
}
