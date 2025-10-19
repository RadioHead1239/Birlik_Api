using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Extorno
{
    public int IdExtorno { get; set; }

    public decimal? MontoExtornado { get; set; }

    public int? FkPoliza { get; set; }

    public int? FkCliente { get; set; }

    public int? FkSeguroDetalle { get; set; }

    public DateOnly? VigenciaExtorno { get; set; }

    public string? NotaDecrito { get; set; }

    public string? CartaDevolucion { get; set; }

    public string? CartaModeloExclusion { get; set; }

    public string? ComentarioExtorno { get; set; }

    public DateTime? FechaRegistroExtorno { get; set; }

    public string? FkUsuario { get; set; }
}
