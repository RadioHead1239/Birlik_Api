using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class CompaniaGp
{
    public int IdCompaniaGps { get; set; }

    public string? NombreCompaniaGps { get; set; }

    public string? NombreCortoCompaniaGps { get; set; }

    public int? FkOrganizacion { get; set; }
}
