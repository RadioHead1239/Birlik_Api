using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Gp
{
    public int IdGps { get; set; }

    public string? DocumentoGps { get; set; }

    public DateTime? FechaRegistroGps { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }

    public DateTime? VencimientoGps { get; set; }

    public string? FkUsuario { get; set; }

    public string? NombreEmpresaGps { get; set; }
}
