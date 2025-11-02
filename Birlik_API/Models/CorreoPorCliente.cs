using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class CorreoPorCliente
{
    public int IdCorreoPorCliente { get; set; }

    public string? NombresContacto { get; set; }

    public string? CargoContacto { get; set; }

    public string? Correo { get; set; }

    public string? EstadoContacto { get; set; }

    public int? FkCliente { get; set; }
}
