using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class TramaCliente
{
    public int IdTramaCliente { get; set; }

    public string? Nombres { get; set; }

    public string? ApPaterno { get; set; }

    public string? ApMaterno { get; set; }

    public string? PaisNacimiento { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? Sexo { get; set; }

    public string? FecNacimiento { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Sede { get; set; }

    public decimal? RemuneracionSctr { get; set; }

    public string? TipoTrabajadorSctr { get; set; }

    public string? Salud { get; set; }

    public string? Pension { get; set; }

    public string? VidaLey { get; set; }

    public decimal? RemuneracionVidaLey { get; set; }

    public string? TipoTrabajadorVidaLey { get; set; }

    public int? Item { get; set; }

    public string? FkUsuario { get; set; }
}
