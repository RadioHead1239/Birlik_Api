using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroRimacTemp
{
    public int IdRimacTemp { get; set; }

    public int? Item { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string NroDoc { get; set; } = null!;

    public string Paterno { get; set; } = null!;

    public string Materno { get; set; } = null!;

    public string Nombre1 { get; set; } = null!;

    public string? Nombre2 { get; set; }

    public string FechaNac { get; set; } = null!;

    public string? Sexo { get; set; }

    public string? Departamento { get; set; }

    public string? Provincia { get; set; }

    public string? Distrito { get; set; }

    public string? Direccion { get; set; }

    public string? RucCliente { get; set; }

    public string Sucursal { get; set; } = null!;

    public string? NivelRiesgo { get; set; }

    public string? MesPlanilla { get; set; }

    public string? Moneda { get; set; }

    public decimal Remuneracion { get; set; }

    public string? CondicionTrabajador { get; set; }

    public string? TipoProducto { get; set; }

    public string? TipoMovimiento { get; set; }

    public string? FechaInicioM { get; set; }

    public string? MonedaPrima { get; set; }

    public string? CodAseguradoR { get; set; }

    public string? Usuario { get; set; }

    public string? FkUsuario { get; set; }
}
