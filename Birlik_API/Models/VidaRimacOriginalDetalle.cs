using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class VidaRimacOriginalDetalle
{
    public int IdVidaRimacOriginalDetalle { get; set; }

    public string? TipoDoc { get; set; }

    public string? NroDoc { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? Nombre1 { get; set; }

    public string? Nombre2 { get; set; }

    public string? FechaNac { get; set; }

    public string? Sexo { get; set; }

    public decimal? Remuneracion { get; set; }

    public string? TipoTrabajador { get; set; }

    public int? FkSeguroResumen { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }

    public string? TipoProducto { get; set; }

    public string? SucursalEmpresa { get; set; }
}
