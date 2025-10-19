using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class ConfiguracionCorreosAutomatizado
{
    public int IdConfiguracionCorreosAutomatizados { get; set; }

    public string? TipoCorreo { get; set; }

    public string? NombreAmigable { get; set; }

    public string? Descripcion { get; set; }

    public string? Activo { get; set; }

    public DateTime? HoraEjecucion { get; set; }

    public int? DiasAnticipacion { get; set; }

    public string? FrecuenciaEjecucion { get; set; }

    public string? ImagenCabecera { get; set; }

    public string? CorreosCopiaFijos { get; set; }

    public string? Destinatario { get; set; }

    public string? De { get; set; }

    public string? Prioridad { get; set; }

    public DateTime? UltimaEjecucion { get; set; }

    public DateTime? ProximaEjecucion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }
}
