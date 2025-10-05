using System;
using System.Collections.Generic;

namespace Birlik_API.Models;

public partial class Login
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Rol { get; set; }

    public string? Nombre { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
