using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class DetalleUsuario
{
    public int IdDetalleUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public string? FkUser { get; set; }

    public string? CargoUsuario { get; set; }

    public string? CelularUsuario { get; set; }

    public string? ApellidoUsuario { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? ImagenUsuario { get; set; }

    public int? FkCliente { get; set; }

    public string? FkSupervisor { get; set; }

    public string? Correo { get; set; }

    public string? ClaveCorreo { get; set; }

    public DateTime? UltimaConexion { get; set; }

    public string? RolUsuario { get; set; }

    public string? EstadoUsuario { get; set; }

    public int? Puntuacion { get; set; }

    public string? ResponsablePorVacaciones { get; set; }

    public string? Sexo { get; set; }

    public string? ImagenFirma { get; set; }

    public string? ImagenFirmaCorreo { get; set; }

    public string? Antecedentes { get; set; }

    public string? HojaVida { get; set; }

    public string? CopiaDni { get; set; }

    public string? EstadoTrabajo { get; set; }

    public string? FormaTrabajo { get; set; }

    public int? NumeroGrupo { get; set; }

    public string? EnviarMensaje { get; set; }

    public string? PortadaUsuario { get; set; }

    public int? FkOrganizacion { get; set; }

    public int? GrupoEmpresa { get; set; }

    public string? TipoInformacion { get; set; }

    public string? PolizasAsignada { get; set; }

    public string? IdiomaUsuario { get; set; }
}
