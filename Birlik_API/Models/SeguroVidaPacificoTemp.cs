﻿using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroVidaPacificoTemp
{
    public int IdVidaPacificoTemp { get; set; }

    public string? CodigTipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? Nacionalidad { get; set; }

    public decimal? ImporteSueldo { get; set; }

    public string? Sexo { get; set; }

    public string? Ocupacion { get; set; }

    public string? Departamento { get; set; }

    public string? Provincia { get; set; }

    public string? Distrito { get; set; }

    public string? Direccion { get; set; }

    public string? TipoTrabajador { get; set; }

    public string? Moneda { get; set; }

    public int? Item { get; set; }

    public string? FkUsuario { get; set; }

    public DateOnly? FechaNacimiento { get; set; }
}
