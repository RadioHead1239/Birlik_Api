using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Cuotum
{
    public int IdCuota { get; set; }

    public int? NumeroCuota { get; set; }

    public int? CodigoCuota { get; set; }

    public DateOnly? VencimientoCuota { get; set; }

    public decimal? Importe { get; set; }

    public DateOnly? FechaPago { get; set; }

    public string? NumeroFactura { get; set; }

    public string? ObservacionCuota { get; set; }

    public string? EstadoCuota { get; set; }

    public string? DocumentoCuota { get; set; }

    public DateTime? FechaRegistroCuota { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }

    public int? FkPrima { get; set; }

    public int? CantidadCuotas { get; set; }

    public int? MsjEnviados { get; set; }

    public string? Prefijo { get; set; }

    public string? ComprobantePago { get; set; }

    public string? DocumentoXmlcuota { get; set; }

    public string? TipoFactura { get; set; }

    public string? ConstanciaSunat { get; set; }

    public DateTime? FechaRegistroCancelacion { get; set; }

    public string? CancelacionUsuario { get; set; }

    public string? UsuarioFactura { get; set; }

    public string? UsuarioCobranza { get; set; }

    public string? EnviarConfirmacion { get; set; }

    public string? EstadoActual { get; set; }
}
