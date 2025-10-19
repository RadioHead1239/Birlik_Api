using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class CompaniaSeguro
{
    public int IdCompaniaSeguro { get; set; }

    public string? NombreCompaniaSeguro { get; set; }

    public string? NombreCortoSeguro { get; set; }

    public string? EstadoSeguro { get; set; }

    public string? LogoUrl { get; set; }

    public string? LogoOpacoUrl { get; set; }

    public decimal? PrimaMinimaBase { get; set; }

    public string? ImagenPdf { get; set; }

    public string? ImagenPdfConstancia { get; set; }

    public int? RamoExclusividad { get; set; }

    public string? BotonPrimeraCuota { get; set; }

    public int? TrazabilidadCompania { get; set; }

    public string? CorreosCompaniaSeguro { get; set; }
}
