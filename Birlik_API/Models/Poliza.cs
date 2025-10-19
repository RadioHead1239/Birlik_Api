using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Poliza
{
    public int IdPoliza { get; set; }

    public int? FkCliente { get; set; }

    public string? NumeroPoliza { get; set; }

    public string? Asegurado { get; set; }

    public int? FkSubAgente { get; set; }

    public int? FkCompania { get; set; }

    public int? FkRamo { get; set; }

    public string? ProductoRamo { get; set; }

    public string? TipoVigencia { get; set; }

    public DateOnly? FechaEmisionPoliza { get; set; }

    public DateOnly? VigenciaInicio { get; set; }

    public DateOnly? VigenciaFin { get; set; }

    public string? Moneda { get; set; }

    public string? DescripcionPoliza { get; set; }

    public DateTime? FechaRegistroPoliza { get; set; }

    public string? EstadoPoliza { get; set; }

    public decimal? ComisionBroker { get; set; }

    public decimal? ComisionSubAgente { get; set; }

    public string? FkUsuario { get; set; }

    public int? CantidadRenovacion { get; set; }

    public int? Trazabilidad { get; set; }

    public int? Engranaje { get; set; }

    public int? BloqueRh { get; set; }

    public string? Sede { get; set; }

    public string? ObtencionPoliza { get; set; }
}
