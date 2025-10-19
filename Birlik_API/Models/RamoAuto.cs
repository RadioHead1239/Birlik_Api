using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoAuto
{
    public int IdRamoAuto { get; set; }

    public string? Uso { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Placa { get; set; }

    public string? NroDeMotor { get; set; }

    public string? NroSerie { get; set; }

    public string? Color { get; set; }

    public string? Gas { get; set; }

    public string? Endosatario { get; set; }

    public string? Siniestralidad { get; set; }

    public int? Items { get; set; }

    public decimal? Pn { get; set; }

    public int? Fabricacion { get; set; }

    public int? NroAsiento { get; set; }

    public decimal? SumaAsegurada { get; set; }

    public decimal? TasaRiesgo { get; set; }

    public decimal? Pc { get; set; }

    public decimal? Pt { get; set; }

    public decimal? Comision { get; set; }

    public decimal? MontoComision { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }

    public string? DepartamentoPeru { get; set; }
}
