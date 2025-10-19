using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class EncargadoCliente
{
    public int IdEncargadoCliente { get; set; }

    public string? EmailEncargado { get; set; }

    public string? CargoEncargado { get; set; }

    public string? NombreEncargado { get; set; }

    public int? FkCliente { get; set; }

    public string? EstadoEncargado { get; set; }

    public string? UsoCorreo { get; set; }
}
