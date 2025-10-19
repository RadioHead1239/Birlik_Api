using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class LaPositivaDetalle
{
    public int IdLaPositivaDetalle { get; set; }

    public string? Nombres { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? TipoTrab { get; set; }

    public string? TipoDoc { get; set; }

    public string? NroDoc { get; set; }

    public string? Sexo { get; set; }

    public string? EstadoCivil { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? FechaNac { get; set; }

    public string? Correo { get; set; }

    public string? Moneda { get; set; }

    public decimal? Remuneracion { get; set; }

    public string? Sede { get; set; }

    public int? FkSeguroResumen { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }
}
