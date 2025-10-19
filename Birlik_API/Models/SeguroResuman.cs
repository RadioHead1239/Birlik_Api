using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroResuman
{
    public int IdSeguroResumen { get; set; }

    public DateTime? FechaRegistroSeguro { get; set; }

    public string? EstadoSeguro { get; set; }

    public string? EstadoAtencion { get; set; }

    public string? DocumentoSeguro { get; set; }

    public int? CantidadTrabajadores { get; set; }

    public string? Usuario { get; set; }

    public DateOnly? FechaCreacionSeguro { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }

    public decimal? SueldoTotal { get; set; }
}
