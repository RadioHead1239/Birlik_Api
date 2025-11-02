using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Birlik_Api.Models;
using System;
using System.IO;

namespace Birlik_Api.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adjunto> Adjuntos { get; set; }

        public virtual DbSet<Anuncio> Anuncios { get; set; }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

        public virtual DbSet<Auditorium> Auditoria { get; set; }

        public virtual DbSet<Automatizacion> Automatizacions { get; set; }

        public virtual DbSet<Autorizacion> Autorizacions { get; set; }

        public virtual DbSet<Cabecera> Cabeceras { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<CompaniaGp> CompaniaGps { get; set; }

        public virtual DbSet<CompaniaSeguro> CompaniaSeguros { get; set; }

        public virtual DbSet<ConfiguracionCorreosAutomatizado> ConfiguracionCorreosAutomatizados { get; set; }

        public virtual DbSet<CorreoHistorial> CorreoHistorials { get; set; }

        public virtual DbSet<CorreoHistorialError> CorreoHistorialErrors { get; set; }

        public virtual DbSet<CorreoPorCliente> CorreoPorClientes { get; set; }

        public virtual DbSet<CorreoPorPoliza> CorreoPorPolizas { get; set; }

        public virtual DbSet<CrecerDetalle> CrecerDetalles { get; set; }

        public virtual DbSet<Cuotum> Cuota { get; set; }

        public virtual DbSet<DetalleEvento> DetalleEventos { get; set; }

        public virtual DbSet<DetalleUsuario> DetalleUsuarios { get; set; }

        public virtual DbSet<Documento> Documentos { get; set; }

        public virtual DbSet<EncargadoCliente> EncargadoClientes { get; set; }

        public virtual DbSet<EstadoPuntuacion> EstadoPuntuacions { get; set; }

        public virtual DbSet<Evento> Eventos { get; set; }

        public virtual DbSet<Extorno> Extornos { get; set; }

        public virtual DbSet<FirmaElectronica> FirmaElectronicas { get; set; }

        public virtual DbSet<GiroNegocio> GiroNegocios { get; set; }

        public virtual DbSet<Gp> Gps { get; set; }

        public virtual DbSet<GrupoEconomico> GrupoEconomicos { get; set; }

        public virtual DbSet<HistorialCartaNombramiento> HistorialCartaNombramientos { get; set; }

        public virtual DbSet<HistorialCorreo> HistorialCorreos { get; set; }

        public virtual DbSet<HistorialMensaje> HistorialMensajes { get; set; }

        public virtual DbSet<HistorialMensajeRobot> HistorialMensajeRobots { get; set; }

        public virtual DbSet<LaPositivaDetalle> LaPositivaDetalles { get; set; }

        public virtual DbSet<LaPositivaMineraDetalle> LaPositivaMineraDetalles { get; set; }

        public virtual DbSet<LogCorreosAutomatizado> LogCorreosAutomatizados { get; set; }

        public virtual DbSet<MapfreDetalle> MapfreDetalles { get; set; }

        public virtual DbSet<Mensaje> Mensajes { get; set; }

        public virtual DbSet<MensajeEnviado> MensajeEnviados { get; set; }

        public virtual DbSet<Notificacion> Notificacions { get; set; }

        public virtual DbSet<Notum> Nota { get; set; }

        public virtual DbSet<Observacion> Observacions { get; set; }

        public virtual DbSet<Organizacion> Organizacions { get; set; }

        public virtual DbSet<Pacifico2Detalle> Pacifico2Detalles { get; set; }

        public virtual DbSet<PacificoDetalle> PacificoDetalles { get; set; }

        public virtual DbSet<PacificoEpsDetalle> PacificoEpsDetalles { get; set; }

        public virtual DbSet<Personalizado> Personalizados { get; set; }

        public virtual DbSet<Poliza> Polizas { get; set; }

        public virtual DbSet<Portadum> Portada { get; set; }

        public virtual DbSet<Prima> Primas { get; set; }

        public virtual DbSet<PrimaMinima> PrimaMinimas { get; set; }

        public virtual DbSet<Producto> Productos { get; set; }

        public virtual DbSet<ProtectaDetalle> ProtectaDetalles { get; set; }

        public virtual DbSet<Punto> Puntos { get; set; }

        public virtual DbSet<Ramo> Ramos { get; set; }

        public virtual DbSet<RamoAccidentesPersonale> RamoAccidentesPersonales { get; set; }

        public virtual DbSet<RamoAccidentesPersonalesTemp> RamoAccidentesPersonalesTemps { get; set; }

        public virtual DbSet<RamoAsistenciaMedica> RamoAsistenciaMedicas { get; set; }

        public virtual DbSet<RamoAsistenciaMedicaTemp> RamoAsistenciaMedicaTemps { get; set; }

        public virtual DbSet<RamoAuto> RamoAutos { get; set; }

        public virtual DbSet<RamoAutoTemp> RamoAutoTemps { get; set; }

        public virtual DbSet<RamoCar> RamoCars { get; set; }

        public virtual DbSet<RamoDeshonestidad> RamoDeshonestidads { get; set; }

        public virtual DbSet<RamoDeshonestidadTemp> RamoDeshonestidadTemps { get; set; }

        public virtual DbSet<RamoEp> RamoEps { get; set; }

        public virtual DbSet<RamoEpsTemp> RamoEpsTemps { get; set; }

        public virtual DbSet<RamoFlotante> RamoFlotantes { get; set; }

        public virtual DbSet<RamoFlotanteTemp> RamoFlotanteTemps { get; set; }

        public virtual DbSet<RamoFola> RamoFolas { get; set; }

        public virtual DbSet<RamoFolaTemp> RamoFolaTemps { get; set; }

        public virtual DbSet<RamoHogar> RamoHogars { get; set; }

        public virtual DbSet<RamoHogarTemp> RamoHogarTemps { get; set; }

        public virtual DbSet<RamoIncendio> RamoIncendios { get; set; }

        public virtual DbSet<RamoIncendioTemp> RamoIncendioTemps { get; set; }

        public virtual DbSet<RamoRcExtracontractual> RamoRcExtracontractuals { get; set; }

        public virtual DbSet<RamoRcExtracontractualTemp> RamoRcExtracontractualTemps { get; set; }

        public virtual DbSet<RamoRcMaptel> RamoRcMaptels { get; set; }

        public virtual DbSet<RamoRcMaptelTemp> RamoRcMaptelTemps { get; set; }

        public virtual DbSet<RamoRcMaquinariaTemp> RamoRcMaquinariaTemps { get; set; }

        public virtual DbSet<RamoRcMaquinarium> RamoRcMaquinaria { get; set; }

        public virtual DbSet<RamoRcProfesional> RamoRcProfesionals { get; set; }

        public virtual DbSet<RamoRcProfesionalTemp> RamoRcProfesionalTemps { get; set; }

        public virtual DbSet<RamoRcVehicular> RamoRcVehiculars { get; set; }

        public virtual DbSet<RamoRcVehicularTemp> RamoRcVehicularTemps { get; set; }

        public virtual DbSet<RamoRoboAsalto> RamoRoboAsaltos { get; set; }

        public virtual DbSet<RamoRoboAsaltoTemp> RamoRoboAsaltoTemps { get; set; }

        public virtual DbSet<RamoSoat> RamoSoats { get; set; }

        public virtual DbSet<RamoSoatTemp> RamoSoatTemps { get; set; }

        public virtual DbSet<RamoTransporte> RamoTransportes { get; set; }

        public virtual DbSet<RamoTransporteTemp> RamoTransporteTemps { get; set; }

        public virtual DbSet<RamoTrec> RamoTrecs { get; set; }

        public virtual DbSet<RamoTrecTemp> RamoTrecTemps { get; set; }

        public virtual DbSet<RamoViajero> RamoViajeros { get; set; }

        public virtual DbSet<RamoViajeroTemp> RamoViajeroTemps { get; set; }

        public virtual DbSet<RangoEtario> RangoEtarios { get; set; }

        public virtual DbSet<Registro> Registros { get; set; }

        public virtual DbSet<Reporte> Reportes { get; set; }

        public virtual DbSet<RimacDetalle> RimacDetalles { get; set; }

        public virtual DbSet<RimacOriginalDetalle> RimacOriginalDetalles { get; set; }

        public virtual DbSet<SanitasDetalle> SanitasDetalles { get; set; }

        public virtual DbSet<SeguroCrecerTemp> SeguroCrecerTemps { get; set; }

        public virtual DbSet<SeguroDetalle> SeguroDetalles { get; set; }

        public virtual DbSet<SeguroLaPositivaMineraTemp> SeguroLaPositivaMineraTemps { get; set; }

        public virtual DbSet<SeguroLaPositivaTemp> SeguroLaPositivaTemps { get; set; }

        public virtual DbSet<SeguroMapfreTemp> SeguroMapfreTemps { get; set; }

        public virtual DbSet<SeguroPacifico2Temp> SeguroPacifico2Temps { get; set; }

        public virtual DbSet<SeguroPacificoEpsTemp> SeguroPacificoEpsTemps { get; set; }

        public virtual DbSet<SeguroPacificoTemp> SeguroPacificoTemps { get; set; }

        public virtual DbSet<SeguroProtectaTemp> SeguroProtectaTemps { get; set; }

        public virtual DbSet<SeguroResuman> SeguroResumen { get; set; }

        public virtual DbSet<SeguroRimacOriginalTemp> SeguroRimacOriginalTemps { get; set; }

        public virtual DbSet<SeguroRimacTemp> SeguroRimacTemps { get; set; }

        public virtual DbSet<SeguroRpatemp> SeguroRpatemps { get; set; }

        public virtual DbSet<SeguroSanitasTemp> SeguroSanitasTemps { get; set; }

        public virtual DbSet<SeguroVidaChubbTemp> SeguroVidaChubbTemps { get; set; }

        public virtual DbSet<SeguroVidaCrecerTemp> SeguroVidaCrecerTemps { get; set; }

        public virtual DbSet<SeguroVidaLaPositivaTemp> SeguroVidaLaPositivaTemps { get; set; }

        public virtual DbSet<SeguroVidaMapfreTemp> SeguroVidaMapfreTemps { get; set; }

        public virtual DbSet<SeguroVidaPacificoTemp> SeguroVidaPacificoTemps { get; set; }

        public virtual DbSet<SeguroVidaPositivaAdelantadoTemp> SeguroVidaPositivaAdelantadoTemps { get; set; }

        public virtual DbSet<SeguroVidaProtectaTemp> SeguroVidaProtectaTemps { get; set; }

        public virtual DbSet<SeguroVidaRimacOriginalTemp> SeguroVidaRimacOriginalTemps { get; set; }

        public virtual DbSet<SeguroVidaRimacTemp> SeguroVidaRimacTemps { get; set; }

        public virtual DbSet<Siniestro> Siniestros { get; set; }

        public virtual DbSet<SiniestroCar> SiniestroCars { get; set; }

        public virtual DbSet<SiniestroSctr> SiniestroSctrs { get; set; }

        public virtual DbSet<SiniestroTransporte> SiniestroTransportes { get; set; }

        public virtual DbSet<SiniestroTrec> SiniestroTrecs { get; set; }

        public virtual DbSet<SiniestroVehicular> SiniestroVehiculars { get; set; }

        public virtual DbSet<SiniestroVidaLey> SiniestroVidaLeys { get; set; }

        public virtual DbSet<Solicitud> Solicituds { get; set; }

        public virtual DbSet<SolicitudCliente> SolicitudClientes { get; set; }

        public virtual DbSet<SubAgente> SubAgentes { get; set; }

        public virtual DbSet<Tarea> Tareas { get; set; }

        public virtual DbSet<Ticket> Tickets { get; set; }

        public virtual DbSet<TopeRemuneracion> TopeRemuneracions { get; set; }

        public virtual DbSet<TramaCliente> TramaClientes { get; set; }

        public virtual DbSet<VidaCrecerDetalle> VidaCrecerDetalles { get; set; }

        public virtual DbSet<VidaLaPositivaDetalle> VidaLaPositivaDetalles { get; set; }

        public virtual DbSet<VidaMapfreDetalle> VidaMapfreDetalles { get; set; }

        public virtual DbSet<VidaPacificoDetalle> VidaPacificoDetalles { get; set; }

        public virtual DbSet<VidaPositivaAdelantadoDetalle> VidaPositivaAdelantadoDetalles { get; set; }

        public virtual DbSet<VidaProtectaDetalle> VidaProtectaDetalles { get; set; }

        public virtual DbSet<VidaRimacDetalle> VidaRimacDetalles { get; set; }

        public virtual DbSet<VidaRimacOriginalDetalle> VidaRimacOriginalDetalles { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                var config = new ConfigurationBuilder()
//                    .SetBasePath(Directory.GetCurrentDirectory())
//                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//                    .Build();

//#if DEBUG
//                var conn = config.GetConnectionString("LocalConnection");
//#else
//        var conn = config.GetConnectionString("DefaultConnection");
//#endif
//                optionsBuilder.UseSqlServer(conn);
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Adjunto>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Adjuntos__3214EC07D3ADCB20");

                entity.HasOne(d => d.Correo).WithMany(p => p.Adjuntos)
                    .HasForeignKey(d => d.CorreoId)
                    .HasConstraintName("FK__Adjuntos__Correo__7CD98669");
            });

            modelBuilder.Entity<Anuncio>(entity =>
            {
                entity.HasKey(e => e.IdAnuncio);

                entity.ToTable("Anuncio");

                entity.Property(e => e.IdAnuncio).HasColumnName("Id_Anuncio");
                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
                entity.Property(e => e.TipoAnuncio).HasMaxLength(50);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);
                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);
                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");
                            j.ToTable("AspNetUserRoles");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);
                entity.Property(e => e.ProviderKey).HasMaxLength(128);
                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);
                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Auditorium>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Auditori__3214EC27E32903DE");

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.ComandoSql).HasColumnName("ComandoSQL");
                entity.Property(e => e.DireccionIp)
                    .HasMaxLength(50)
                    .HasColumnName("DireccionIP");
                entity.Property(e => e.FechaHora).HasColumnType("datetime");
                entity.Property(e => e.NombreAplicacion).HasMaxLength(100);
                entity.Property(e => e.NombreHost).HasMaxLength(100);
                entity.Property(e => e.NombreTrigger).HasMaxLength(100);
                entity.Property(e => e.Operacion).HasMaxLength(10);
                entity.Property(e => e.Spid).HasColumnName("SPID");
                entity.Property(e => e.TablaAfectada).HasMaxLength(255);
                entity.Property(e => e.UsuarioInsercion).HasMaxLength(50);
            });

            modelBuilder.Entity<Automatizacion>(entity =>
            {
                entity.HasKey(e => e.IdAutomatizacion);

                entity.ToTable("Automatizacion");

                entity.Property(e => e.IdAutomatizacion).HasColumnName("Id_Automatizacion");
                entity.Property(e => e.Asunto).HasMaxLength(250);
                entity.Property(e => e.CabeceraUrl).HasMaxLength(500);
                entity.Property(e => e.ConCopia).HasMaxLength(100);
                entity.Property(e => e.CorreoEmisor).HasMaxLength(150);
                entity.Property(e => e.DescripcionAutomatizacion).HasMaxLength(500);
                entity.Property(e => e.EstadoAutomatizacion).HasMaxLength(100);
                entity.Property(e => e.FirmaCorreo).HasMaxLength(500);
                entity.Property(e => e.ObservacionAutomatizacion).HasMaxLength(500);
                entity.Property(e => e.TipoAutomatizacion).HasMaxLength(500);
            });

            modelBuilder.Entity<Autorizacion>(entity =>
            {
                entity.HasKey(e => e.IdAutorizacion);

                entity.ToTable("Autorizacion");

                entity.Property(e => e.IdAutorizacion).HasColumnName("Id_Autorizacion");
                entity.Property(e => e.EstadoAutorizacion).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCuota).HasColumnName("Fk_Cuota");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.TipoAutorizacion).HasMaxLength(50);
            });

            modelBuilder.Entity<Cabecera>(entity =>
            {
                entity.HasKey(e => e.IdCabecera);

                entity.ToTable("Cabecera");

                entity.Property(e => e.IdCabecera).HasColumnName("Id_Cabecera");
                entity.Property(e => e.ActionUso).HasMaxLength(150);
                entity.Property(e => e.AreaUso).HasMaxLength(150);
                entity.Property(e => e.ControladorUso).HasMaxLength(150);
                entity.Property(e => e.Imagen).HasMaxLength(150);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("Cliente");

                entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
                entity.Property(e => e.CartaNombramiento).HasMaxLength(500);
                entity.Property(e => e.Celular).HasMaxLength(500);
                entity.Property(e => e.Ciudad).HasMaxLength(500);
                entity.Property(e => e.Direccion).HasMaxLength(500);
                entity.Property(e => e.Distrito).HasMaxLength(500);
                entity.Property(e => e.DniDocumento).HasMaxLength(500);
                entity.Property(e => e.EjecutivoProvisional).HasMaxLength(50);
                entity.Property(e => e.EjecutivoResponsable).HasMaxLength(80);
                entity.Property(e => e.Email).HasMaxLength(500);
                entity.Property(e => e.EmailContacto).HasMaxLength(500);
                entity.Property(e => e.EstadoCliente).HasMaxLength(50);
                entity.Property(e => e.FacturaXml).HasColumnName("FacturaXML");
                entity.Property(e => e.FechaAntiguedad).HasColumnType("datetime");
                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
                entity.Property(e => e.FkGiroNegocio).HasColumnName("Fk_GiroNegocio");
                entity.Property(e => e.FkGrupoEconomico).HasColumnName("Fk_GrupoEconomico");
                entity.Property(e => e.FkSubagente).HasColumnName("Fk_Subagente");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(500)
                    .HasColumnName("Fk_usuario");
                entity.Property(e => e.Imagen).HasMaxLength(450);
                entity.Property(e => e.Nombres).HasMaxLength(500);
                entity.Property(e => e.Notificacion).HasMaxLength(500);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(500);
                entity.Property(e => e.Observacion).HasMaxLength(500);
                entity.Property(e => e.Profesion).HasMaxLength(500);
                entity.Property(e => e.Provincia).HasMaxLength(500);
                entity.Property(e => e.Referencia).HasMaxLength(500);
                entity.Property(e => e.Telefono1).HasMaxLength(500);
                entity.Property(e => e.Telefono2).HasMaxLength(500);
                entity.Property(e => e.TipoDocumento).HasMaxLength(500);
                entity.Property(e => e.TipoPersona).HasMaxLength(50);
            });

            modelBuilder.Entity<CompaniaGp>(entity =>
            {
                entity.HasKey(e => e.IdCompaniaGps);

                entity.ToTable("CompaniaGPS");

                entity.Property(e => e.IdCompaniaGps).HasColumnName("Id_Compania_GPS");
                entity.Property(e => e.FkOrganizacion).HasColumnName("Fk_Organizacion");
                entity.Property(e => e.NombreCompaniaGps)
                    .HasMaxLength(350)
                    .HasColumnName("NombreCompaniaGPS");
                entity.Property(e => e.NombreCortoCompaniaGps)
                    .HasMaxLength(350)
                    .HasColumnName("NombreCortoCompaniaGPS");
            });

            modelBuilder.Entity<CompaniaSeguro>(entity =>
            {
                entity.HasKey(e => e.IdCompaniaSeguro);

                entity.ToTable("CompaniaSeguro");

                entity.Property(e => e.IdCompaniaSeguro).HasColumnName("Id_CompaniaSeguro");
                entity.Property(e => e.BotonPrimeraCuota).HasMaxLength(50);
                entity.Property(e => e.CorreosCompaniaSeguro).HasMaxLength(1000);
                entity.Property(e => e.EstadoSeguro).HasMaxLength(50);
                entity.Property(e => e.ImagenPdf).HasMaxLength(150);
                entity.Property(e => e.ImagenPdfConstancia).HasMaxLength(150);
                entity.Property(e => e.LogoOpacoUrl).HasMaxLength(150);
                entity.Property(e => e.LogoUrl).HasMaxLength(150);
                entity.Property(e => e.NombreCompaniaSeguro).HasMaxLength(500);
                entity.Property(e => e.NombreCortoSeguro).HasMaxLength(100);
                entity.Property(e => e.PrimaMinimaBase).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ConfiguracionCorreosAutomatizado>(entity =>
            {
                entity.HasKey(e => e.IdConfiguracionCorreosAutomatizados);

                entity.Property(e => e.IdConfiguracionCorreosAutomatizados).HasColumnName("Id_ConfiguracionCorreosAutomatizados");
                entity.Property(e => e.Activo).HasMaxLength(50);
                entity.Property(e => e.CorreosCopiaFijos).HasMaxLength(1000);
                entity.Property(e => e.De).HasMaxLength(1000);
                entity.Property(e => e.Destinatario).HasMaxLength(1000);
                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
                entity.Property(e => e.FrecuenciaEjecucion).HasMaxLength(1000);
                entity.Property(e => e.HoraEjecucion).HasColumnType("datetime");
                entity.Property(e => e.ImagenCabecera).HasMaxLength(1000);
                entity.Property(e => e.NombreAmigable).HasMaxLength(1000);
                entity.Property(e => e.Prioridad).HasMaxLength(1000);
                entity.Property(e => e.ProximaEjecucion).HasColumnType("datetime");
                entity.Property(e => e.TipoCorreo).HasMaxLength(1000);
                entity.Property(e => e.UltimaEjecucion).HasColumnType("datetime");
            });

            modelBuilder.Entity<CorreoHistorial>(entity =>
            {
                entity.HasKey(e => e.IdCorreoHistorial);

                entity.ToTable("CorreoHistorial");

                entity.Property(e => e.IdCorreoHistorial).HasColumnName("Id_CorreoHistorial");
                entity.Property(e => e.Asunto).HasMaxLength(500);
                entity.Property(e => e.Estado).HasMaxLength(50);
                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            });

            modelBuilder.Entity<CorreoHistorialError>(entity =>
            {
                entity.HasKey(e => e.IdCorreoHistorialError);

                entity.ToTable("CorreoHistorialError");

                entity.Property(e => e.IdCorreoHistorialError).HasColumnName("Id_CorreoHistorialError");
                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
                entity.Property(e => e.FkCorreoHistorial).HasColumnName("Fk_CorreoHistorial");
            });

            modelBuilder.Entity<CorreoPorCliente>(entity =>
            {
                entity.HasKey(e => e.IdCorreoPorCliente);

                entity.ToTable("CorreoPorCliente");

                entity.Property(e => e.IdCorreoPorCliente).HasColumnName("Id_CorreoPorCliente");
                entity.Property(e => e.CargoContacto).HasMaxLength(500);
                entity.Property(e => e.Correo).HasMaxLength(250);
                entity.Property(e => e.EstadoContacto).HasMaxLength(250);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.NombresContacto).HasMaxLength(500);
            });

            modelBuilder.Entity<CorreoPorPoliza>(entity =>
            {
                entity.HasKey(e => e.IdCorreoPoliza).HasName("PK_CorreoPoliza");

                entity.ToTable("CorreoPorPoliza");

                entity.Property(e => e.IdCorreoPoliza).HasColumnName("Id_CorreoPoliza");
                entity.Property(e => e.EmailAdicional).HasMaxLength(500);
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.TipoCorreoPorPoliza).HasMaxLength(500);
            });

            modelBuilder.Entity<CrecerDetalle>(entity =>
            {
                entity.HasKey(e => e.IdCrecerDetalle);

                entity.ToTable("CrecerDetalle");

                entity.Property(e => e.IdCrecerDetalle).HasColumnName("Id_CrecerDetalle");
                entity.Property(e => e.ApMaterno).HasMaxLength(50);
                entity.Property(e => e.ApPaterno).HasMaxLength(50);
                entity.Property(e => e.EstadoCivil).HasMaxLength(50);
                entity.Property(e => e.FecNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumIdent).HasMaxLength(50);
                entity.Property(e => e.PaisNacimiento).HasMaxLength(50);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede)
                    .HasMaxLength(300)
                    .IsUnicode(false);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoIdent).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

            modelBuilder.Entity<Cuotum>(entity =>
            {
                entity.HasKey(e => e.IdCuota);

                entity.Property(e => e.IdCuota).HasColumnName("Id_Cuota");
                entity.Property(e => e.CancelacionUsuario)
                    .HasMaxLength(500)
                    .HasColumnName("Cancelacion_Usuario");
                entity.Property(e => e.CantidadCuotas).HasColumnName("Cantidad_Cuotas");
                entity.Property(e => e.ComprobantePago).HasMaxLength(350);
                entity.Property(e => e.ConstanciaSunat).HasMaxLength(500);
                entity.Property(e => e.DocumentoCuota).HasMaxLength(350);
                entity.Property(e => e.DocumentoXmlcuota)
                    .HasMaxLength(350)
                    .HasColumnName("DocumentoXMLCuota");
                entity.Property(e => e.EnviarConfirmacion).HasMaxLength(500);
                entity.Property(e => e.EstadoActual).HasMaxLength(500);
                entity.Property(e => e.EstadoCuota).HasMaxLength(50);
                entity.Property(e => e.FechaRegistroCancelacion).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistroCuota).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkPrima).HasColumnName("Fk_Prima");
                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.NumeroCuota).HasColumnName("Numero_Cuota");
                entity.Property(e => e.NumeroFactura).HasMaxLength(50);
                entity.Property(e => e.ObservacionCuota).HasMaxLength(250);
                entity.Property(e => e.Prefijo).HasMaxLength(50);
                entity.Property(e => e.TipoFactura).HasMaxLength(50);
                entity.Property(e => e.UsuarioCobranza).HasMaxLength(500);
                entity.Property(e => e.UsuarioFactura).HasMaxLength(500);
            });

            modelBuilder.Entity<DetalleEvento>(entity =>
            {
                entity.HasKey(e => e.IdDetalleEvento);

                entity.ToTable("DetalleEvento");

                entity.Property(e => e.IdDetalleEvento).HasColumnName("Id_DetalleEvento");
                entity.Property(e => e.FechaConfirmacion).HasColumnType("datetime");
                entity.Property(e => e.FkEvento).HasColumnName("Fk_Evento");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.RespuestaEvento).HasMaxLength(500);
            });

            modelBuilder.Entity<DetalleUsuario>(entity =>
            {
                entity.HasKey(e => e.IdDetalleUsuario);

                entity.ToTable("DetalleUsuario");

                entity.Property(e => e.IdDetalleUsuario).HasColumnName("Id_DetalleUsuario");
                entity.Property(e => e.Antecedentes).HasMaxLength(150);
                entity.Property(e => e.ApellidoUsuario).HasMaxLength(100);
                entity.Property(e => e.CargoUsuario).HasMaxLength(150);
                entity.Property(e => e.CelularUsuario).HasMaxLength(50);
                entity.Property(e => e.ClaveCorreo).HasMaxLength(100);
                entity.Property(e => e.CopiaDni)
                    .HasMaxLength(150)
                    .HasColumnName("CopiaDNI");
                entity.Property(e => e.Correo).HasMaxLength(100);
                entity.Property(e => e.EnviarMensaje)
                    .HasMaxLength(50)
                    .HasColumnName("enviarMensaje");
                entity.Property(e => e.EstadoTrabajo).HasMaxLength(150);
                entity.Property(e => e.EstadoUsuario).HasMaxLength(50);
                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkOrganizacion).HasColumnName("Fk_Organizacion");
                entity.Property(e => e.FkSupervisor)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Supervisor");
                entity.Property(e => e.FkUser)
                    .HasMaxLength(100)
                    .HasColumnName("Fk_User");
                entity.Property(e => e.FormaTrabajo).HasMaxLength(150);
                entity.Property(e => e.HojaVida).HasMaxLength(150);
                entity.Property(e => e.IdiomaUsuario).HasMaxLength(100);
                entity.Property(e => e.ImagenFirma).HasMaxLength(50);
                entity.Property(e => e.ImagenFirmaCorreo).HasMaxLength(150);
                entity.Property(e => e.ImagenUsuario).HasMaxLength(250);
                entity.Property(e => e.NombreUsuario).HasMaxLength(100);
                entity.Property(e => e.PolizasAsignada).HasMaxLength(100);
                entity.Property(e => e.PortadaUsuario).HasMaxLength(50);
                entity.Property(e => e.ResponsablePorVacaciones).HasMaxLength(50);
                entity.Property(e => e.RolUsuario).HasMaxLength(50);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoInformacion).HasMaxLength(50);
                entity.Property(e => e.UltimaConexion).HasColumnType("datetime");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.IdDocumento);

                entity.ToTable("Documento");

                entity.Property(e => e.IdDocumento).HasColumnName("Id_Documento");
                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.RutaDocumento).HasMaxLength(500);
                entity.Property(e => e.TituloDocumento).HasMaxLength(500);
            });

            modelBuilder.Entity<EncargadoCliente>(entity =>
            {
                entity.HasKey(e => e.IdEncargadoCliente).HasName("PK_Encargado_Cliente");

                entity.ToTable("EncargadoCliente");

                entity.Property(e => e.IdEncargadoCliente).HasColumnName("Id_Encargado_Cliente");
                entity.Property(e => e.CargoEncargado).HasMaxLength(500);
                entity.Property(e => e.EstadoEncargado).HasMaxLength(500);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.NombreEncargado).HasMaxLength(500);
                entity.Property(e => e.UsoCorreo).HasMaxLength(500);
            });

            modelBuilder.Entity<EstadoPuntuacion>(entity =>
            {
                entity.HasKey(e => e.IdEstadoPuntuacion);

                entity.ToTable("EstadoPuntuacion");

                entity.Property(e => e.Color).HasMaxLength(50);
                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.IdEvento);

                entity.ToTable("Evento");

                entity.Property(e => e.IdEvento).HasColumnName("Id_Evento");
                entity.Property(e => e.ArchivoEvento).HasMaxLength(500);
                entity.Property(e => e.EstadoEvento).HasMaxLength(50);
                entity.Property(e => e.FechaFinEvento).HasColumnType("datetime");
                entity.Property(e => e.FechaInicioEvento).HasColumnType("datetime");
                entity.Property(e => e.NombreEvento).HasMaxLength(500);
                entity.Property(e => e.TipoEvento).HasMaxLength(500);
                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<Extorno>(entity =>
            {
                entity.HasKey(e => e.IdExtorno);

                entity.ToTable("Extorno");

                entity.Property(e => e.IdExtorno).HasColumnName("Id_Extorno");
                entity.Property(e => e.CartaDevolucion)
                    .HasMaxLength(1500)
                    .IsUnicode(false);
                entity.Property(e => e.CartaModeloExclusion)
                    .HasMaxLength(1500)
                    .IsUnicode(false);
                entity.Property(e => e.ComentarioExtorno)
                    .HasMaxLength(5500)
                    .IsUnicode(false);
                entity.Property(e => e.FechaRegistroExtorno).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkSeguroDetalle).HasColumnName("Fk_SeguroDetalle");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_usuario");
                entity.Property(e => e.MontoExtornado).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.NotaDecrito)
                    .HasMaxLength(1500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FirmaElectronica>(entity =>
            {
                entity.HasKey(e => e.IdFirma);

                entity.ToTable("FirmaElectronica");

                entity.Property(e => e.IdFirma).HasColumnName("idFirma");
                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro");
                entity.Property(e => e.FkReporte).HasColumnName("fkReporte");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fkUsuario");
                entity.Property(e => e.Observacion)
                    .HasMaxLength(250)
                    .HasColumnName("observacion");
                entity.Property(e => e.Rol)
                    .HasMaxLength(50)
                    .HasColumnName("rol");
            });

            modelBuilder.Entity<GiroNegocio>(entity =>
            {
                entity.HasKey(e => e.IdGiroNegocio);

                entity.ToTable("GiroNegocio");

                entity.Property(e => e.IdGiroNegocio).HasColumnName("Id_GiroNegocio");
                entity.Property(e => e.CodigoGiro).HasMaxLength(500);
                entity.Property(e => e.DescripcionGiroNegocio).HasMaxLength(500);
                entity.Property(e => e.EstadoGiro).HasMaxLength(50);
            });

            modelBuilder.Entity<Gp>(entity =>
            {
                entity.HasKey(e => e.IdGps);

                entity.ToTable("GPS");

                entity.Property(e => e.IdGps).HasColumnName("Id_GPS");
                entity.Property(e => e.DocumentoGps)
                    .HasMaxLength(350)
                    .HasColumnName("DocumentoGPS");
                entity.Property(e => e.FechaRegistroGps)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaRegistroGPS");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(350)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.NombreEmpresaGps)
                    .HasMaxLength(350)
                    .HasColumnName("nombreEmpresaGPS");
                entity.Property(e => e.VencimientoGps)
                    .HasColumnType("datetime")
                    .HasColumnName("VencimientoGPS");
            });

            modelBuilder.Entity<GrupoEconomico>(entity =>
            {
                entity.HasKey(e => e.IdGrupoEconomico);

                entity.ToTable("GrupoEconomico");

                entity.Property(e => e.IdGrupoEconomico).HasColumnName("Id_GrupoEconomico");
                entity.Property(e => e.DescripcionGrupoEconomico).HasMaxLength(50);
            });

            modelBuilder.Entity<HistorialCartaNombramiento>(entity =>
            {
                entity.HasKey(e => e.IdCartaNombramiento).HasName("PK__Historia__094AF3F7346FCB4B");

                entity.ToTable("Historial_CartaNombramiento");

                entity.Property(e => e.IdCartaNombramiento).HasColumnName("Id_CartaNombramiento");
                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(500)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.UrlArchivo).HasMaxLength(500);

                entity.HasOne(d => d.FkClienteNavigation).WithMany(p => p.HistorialCartaNombramientos)
                    .HasForeignKey(d => d.FkCliente)
                    .HasConstraintName("FK__Historial__Fk_Cl__038683F8");
            });

            modelBuilder.Entity<HistorialCorreo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Historia__3214EC079ADD3959");

                entity.Property(e => e.CorreoDestinatario).HasMaxLength(500);
                entity.Property(e => e.FechaRecibido).HasColumnType("datetime");
                entity.Property(e => e.Sentimiento).HasMaxLength(50);
            });

            modelBuilder.Entity<HistorialMensaje>(entity =>
            {
                entity.HasKey(e => e.IdHistorialMensaje);

                entity.ToTable("HistorialMensaje");

                entity.Property(e => e.IdHistorialMensaje).HasColumnName("Id_HistorialMensaje");
                entity.Property(e => e.FechaRegistroHistorialMensaje).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCuota).HasColumnName("Fk_Cuota");
                entity.Property(e => e.FkDetalleUsuario).HasColumnName("Fk_DetalleUsuario");
                entity.Property(e => e.FkMensajeEnviado).HasColumnName("Fk_MensajeEnviado");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.TipoHistorialMensaje).HasMaxLength(500);
                entity.Property(e => e.Usuario).HasMaxLength(500);
            });

            modelBuilder.Entity<HistorialMensajeRobot>(entity =>
            {
                entity.HasKey(e => e.IdHistorialMensajeRobot);

                entity.ToTable("HistorialMensajeRobot");

                entity.Property(e => e.IdHistorialMensajeRobot).HasColumnName("Id_HistorialMensajeRobot");
                entity.Property(e => e.Estado).HasMaxLength(1000);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.Observaciones).HasMaxLength(1000);
                entity.Property(e => e.RespuestaCliente).HasMaxLength(1000);
                entity.Property(e => e.TipoMensaje).HasMaxLength(1000);
                entity.Property(e => e.UsuarioAprobador).HasMaxLength(1000);
            });

            modelBuilder.Entity<LaPositivaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdLaPositivaDetalle);

                entity.ToTable("LaPositivaDetalle");

                entity.Property(e => e.IdLaPositivaDetalle).HasColumnName("Id_LaPositivaDetalle");
                entity.Property(e => e.Correo).HasMaxLength(50);
                entity.Property(e => e.Direccion).HasMaxLength(250);
                entity.Property(e => e.EstadoCivil).HasMaxLength(50);
                entity.Property(e => e.FechaNac).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(50);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(300);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.Telefono).HasMaxLength(50);
                entity.Property(e => e.TipoDoc).HasMaxLength(50);
                entity.Property(e => e.TipoTrab).HasMaxLength(50);
            });

            modelBuilder.Entity<LaPositivaMineraDetalle>(entity =>
            {
                entity.HasKey(e => e.IdLaPositivaMineraDetalle);

                entity.ToTable("LaPositivaMineraDetalle");

                entity.Property(e => e.IdLaPositivaMineraDetalle).HasColumnName("Id_LaPositivaMineraDetalle");
                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(250)
                    .HasColumnName("apellidoMaterno");
                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(250)
                    .HasColumnName("apellidoPaterno");
                entity.Property(e => e.Categoria)
                    .HasMaxLength(250)
                    .HasColumnName("categoria");
                entity.Property(e => e.Clinica)
                    .HasMaxLength(250)
                    .HasColumnName("clinica");
                entity.Property(e => e.Dni)
                    .HasMaxLength(250)
                    .HasColumnName("dni");
                entity.Property(e => e.FechaNacimiento)
                    .HasMaxLength(250)
                    .HasColumnName("fechaNacimiento");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Nombres)
                    .HasMaxLength(250)
                    .HasColumnName("nombres");
                entity.Property(e => e.Numero)
                    .HasMaxLength(250)
                    .HasColumnName("numero");
                entity.Property(e => e.PuestoTrabajo)
                    .HasMaxLength(250)
                    .HasColumnName("puestoTrabajo");
                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(250)
                    .HasColumnName("razonSocial");
                entity.Property(e => e.Remuneracion)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("remuneracion");
                entity.Property(e => e.Ruc)
                    .HasMaxLength(250)
                    .HasColumnName("RUC");
                entity.Property(e => e.UnidadMinera)
                    .HasMaxLength(250)
                    .HasColumnName("unidadMinera");
            });

            modelBuilder.Entity<LogCorreosAutomatizado>(entity =>
            {
                entity.HasKey(e => e.IdLogCorreosAutomatizados);

                entity.Property(e => e.IdLogCorreosAutomatizados).HasColumnName("Id_LogCorreosAutomatizados");
                entity.Property(e => e.AsuntoCorreo).HasMaxLength(1000);
                entity.Property(e => e.CategoriaCorreo).HasMaxLength(1000);
                entity.Property(e => e.CodigoErrorApi)
                    .HasMaxLength(1000)
                    .HasColumnName("CodigoErrorAPI");
                entity.Property(e => e.CopiasCorreo).HasMaxLength(1000);
                entity.Property(e => e.CreadoPor).HasMaxLength(1000);
                entity.Property(e => e.DestinarioCorreo).HasMaxLength(1000);
                entity.Property(e => e.EstadoEnvio).HasMaxLength(1000);
                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
                entity.Property(e => e.FechaHoraEnvio).HasColumnType("datetime");
                entity.Property(e => e.FechaHoraProgramada).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCuota).HasColumnName("Fk_Cuota");
                entity.Property(e => e.FkGps).HasColumnName("Fk_GPS");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkTarea).HasColumnName("Fk_Tarea");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(1000)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.ImagenCabecera).HasMaxLength(1000);
                entity.Property(e => e.MensajeError).HasMaxLength(1000);
                entity.Property(e => e.MetadatosJson)
                    .HasMaxLength(1000)
                    .HasColumnName("MetadatosJSON");
                entity.Property(e => e.TipoCorreo).HasMaxLength(1000);
            });

            modelBuilder.Entity<MapfreDetalle>(entity =>
            {
                entity.HasKey(e => e.IdMapfreDetalle);

                entity.ToTable("MapfreDetalle");

                entity.Property(e => e.IdMapfreDetalle).HasColumnName("Id_MapfreDetalle");
                entity.Property(e => e.ApeMaterno)
                    .HasMaxLength(100)
                    .HasColumnName("apeMaterno");
                entity.Property(e => e.ApePaterno)
                    .HasMaxLength(100)
                    .HasColumnName("apePaterno");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Nacimiento)
                    .HasMaxLength(20)
                    .HasColumnName("nacimiento");
                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(500)
                    .HasColumnName("nombre_Completo");
                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .HasColumnName("nombres");
                entity.Property(e => e.NumDoc)
                    .HasMaxLength(50)
                    .HasColumnName("numDoc");
                entity.Property(e => e.Sueldo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sueldo");
                entity.Property(e => e.TipDoc)
                    .HasMaxLength(50)
                    .HasColumnName("tipDoc");
            });

            modelBuilder.Entity<Mensaje>(entity =>
            {
                entity.HasKey(e => e.IdMensaje);

                entity.ToTable("Mensaje");

                entity.Property(e => e.IdMensaje).HasColumnName("Id_Mensaje");
                entity.Property(e => e.ArchivoInformativo).HasMaxLength(500);
                entity.Property(e => e.EstadoMensaje).HasMaxLength(50);
                entity.Property(e => e.FechaLeido).HasColumnType("datetime");
                entity.Property(e => e.FechaMensaje).HasColumnType("datetime");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.NombreMensaje).HasMaxLength(500);
                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<MensajeEnviado>(entity =>
            {
                entity.HasKey(e => e.IdMensajeEnviado);

                entity.ToTable("MensajeEnviado");

                entity.Property(e => e.IdMensajeEnviado).HasColumnName("Id_MensajeEnviado");
                entity.Property(e => e.Archivo1Mensaje).HasMaxLength(500);
                entity.Property(e => e.Archivo2Mensaje).HasMaxLength(500);
                entity.Property(e => e.Archivo3Mensaje).HasMaxLength(500);
                entity.Property(e => e.Archivo4Mensaje).HasMaxLength(500);
                entity.Property(e => e.ArchivoVisualizar).HasMaxLength(1000);
                entity.Property(e => e.CopiaMensajeEnviado).HasMaxLength(500);
                entity.Property(e => e.EstadoMensaje).HasMaxLength(500);
                entity.Property(e => e.FechaProgramada).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistroMensajeEnviado).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.GeneradoMensajeEnviado).HasMaxLength(50);
                entity.Property(e => e.ImagenMensaje).HasMaxLength(500);
            });

            modelBuilder.Entity<Notificacion>(entity =>
            {
                entity.HasKey(e => e.IdNotificacion);

                entity.ToTable("Notificacion");

                entity.Property(e => e.IdNotificacion).HasColumnName("Id_Notificacion");
                entity.Property(e => e.DescripcionNotificacion).HasMaxLength(200);
                entity.Property(e => e.FechaNotificacion).HasColumnType("datetime");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.TipoNotificacion).HasMaxLength(50);
                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<Notum>(entity =>
            {
                entity.HasKey(e => e.IdNota);

                entity.Property(e => e.IdNota).HasColumnName("Id_Nota");
                entity.Property(e => e.DescripcionNota).HasMaxLength(500);
                entity.Property(e => e.FechaRecordatorio).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistroNota).HasColumnType("datetime");
                entity.Property(e => e.FkClienteNota).HasColumnName("Fk_ClienteNota");
                entity.Property(e => e.FkCuota).HasColumnName("Fk_Cuota");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.TipoNota).HasMaxLength(500);
            });

            modelBuilder.Entity<Observacion>(entity =>
            {
                entity.HasKey(e => e.IdObservacion);

                entity.ToTable("Observacion");

                entity.Property(e => e.IdObservacion).HasColumnName("Id_Observacion");
                entity.Property(e => e.Categoria).HasMaxLength(500);
                entity.Property(e => e.FechaObservacion).HasColumnType("datetime");
                entity.Property(e => e.FkGlobal).HasColumnName("Fk_Global");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(500)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.Tipo).HasMaxLength(500);
            });

            modelBuilder.Entity<Organizacion>(entity =>
            {
                entity.HasKey(e => e.IdOrganizacion);

                entity.ToTable("Organizacion");

                entity.Property(e => e.IdOrganizacion).HasColumnName("Id_Organizacion");
                entity.Property(e => e.CorreoCobranza).HasMaxLength(500);
                entity.Property(e => e.CorreosCopia).HasMaxLength(1000);
                entity.Property(e => e.Direccion).HasMaxLength(500);
                entity.Property(e => e.FechaInscripcion).HasColumnName("Fecha_Inscripcion");
                entity.Property(e => e.ImgOrganizacion)
                    .HasMaxLength(500)
                    .HasColumnName("Img_Organizacion");
                entity.Property(e => e.MetodoTrabajo).HasMaxLength(500);
                entity.Property(e => e.NomOrganizacion)
                    .HasMaxLength(500)
                    .HasColumnName("Nom_Organizacion");
                entity.Property(e => e.NumTelefonico)
                    .HasMaxLength(500)
                    .HasColumnName("Num_Telefonico");
            });

            modelBuilder.Entity<Pacifico2Detalle>(entity =>
            {
                entity.HasKey(e => e.IdPacifico2Detalle);

                entity.ToTable("Pacifico2Detalle");

                entity.Property(e => e.IdPacifico2Detalle).HasColumnName("Id_Pacifico2Detalle");
                entity.Property(e => e.ApellidoMaterno).HasMaxLength(50);
                entity.Property(e => e.ApellidoPaterno).HasMaxLength(50);
                entity.Property(e => e.CodigoAsegurado).HasMaxLength(50);
                entity.Property(e => e.CodigoTipoDocumento).HasMaxLength(50);
                entity.Property(e => e.Condicion).HasMaxLength(50);
                entity.Property(e => e.Departamento).HasMaxLength(70);
                entity.Property(e => e.Direccion).HasMaxLength(150);
                entity.Property(e => e.Distrito).HasMaxLength(70);
                entity.Property(e => e.FechaInicioVigencia).HasMaxLength(50);
                entity.Property(e => e.FechaNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.ImporteSueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MesPlanilla).HasMaxLength(50);
                entity.Property(e => e.MonedaPrima).HasMaxLength(50);
                entity.Property(e => e.MonedaSueldo).HasMaxLength(50);
                entity.Property(e => e.Nacionalidad).HasMaxLength(50);
                entity.Property(e => e.NivelRiesgo).HasMaxLength(50);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(50);
                entity.Property(e => e.Ocupacion).HasMaxLength(70);
                entity.Property(e => e.PrimerNombre).HasMaxLength(50);
                entity.Property(e => e.Provincia).HasMaxLength(70);
                entity.Property(e => e.ProyObra).HasMaxLength(50);
                entity.Property(e => e.Ruc)
                    .HasMaxLength(50)
                    .HasColumnName("RUC");
                entity.Property(e => e.SegundoNombre).HasMaxLength(50);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoMovimiento).HasMaxLength(50);
                entity.Property(e => e.TipoProducto).HasMaxLength(50);
            });

            modelBuilder.Entity<PacificoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdPacificoDetalle);

                entity.ToTable("PacificoDetalle");

                entity.Property(e => e.IdPacificoDetalle).HasColumnName("Id_PacificoDetalle");
                entity.Property(e => e.ApellidoMaterno).HasMaxLength(50);
                entity.Property(e => e.ApellidoPaterno).HasMaxLength(50);
                entity.Property(e => e.FechaNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.ImporteSueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MonedaSueldo).HasMaxLength(50);
                entity.Property(e => e.Nacionalidad).HasMaxLength(50);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(50);
                entity.Property(e => e.Observaciones).HasMaxLength(250);
                entity.Property(e => e.PrimerNombre).HasMaxLength(50);
                entity.Property(e => e.SegundoNombre).HasMaxLength(50);
                entity.Property(e => e.Sexo).HasMaxLength(50);
            });

            modelBuilder.Entity<PacificoEpsDetalle>(entity =>
            {
                entity.HasKey(e => e.IdPacificoEpsDetalle);

                entity.ToTable("PacificoEpsDetalle");

                entity.Property(e => e.IdPacificoEpsDetalle).HasColumnName("Id_PacificoEpsDetalle");
                entity.Property(e => e.FechaNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.MonedaSueldo).HasMaxLength(50);
                entity.Property(e => e.Nombre).HasMaxLength(1000);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(50);
                entity.Property(e => e.Plan).HasMaxLength(100);
                entity.Property(e => e.Tarifa).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Personalizado>(entity =>
            {
                entity.HasKey(e => e.IdPersonalizado);

                entity.ToTable("Personalizado");

                entity.Property(e => e.IdPersonalizado).HasColumnName("Id_Personalizado");
                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
                entity.Property(e => e.TipoPersonalizado).HasMaxLength(50);
            });

            modelBuilder.Entity<Poliza>(entity =>
            {
                entity.HasKey(e => e.IdPoliza);

                entity.ToTable("Poliza");

                entity.Property(e => e.IdPoliza).HasColumnName("Id_Poliza");
                entity.Property(e => e.Asegurado).HasMaxLength(250);
                entity.Property(e => e.BloqueRh).HasColumnName("Bloque_RH");
                entity.Property(e => e.CantidadRenovacion).HasColumnName("Cantidad_Renovacion");
                entity.Property(e => e.ComisionBroker).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.ComisionSubAgente).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.DescripcionPoliza)
                    .HasMaxLength(1500)
                    .IsUnicode(false);
                entity.Property(e => e.EstadoPoliza).HasMaxLength(100);
                entity.Property(e => e.FechaRegistroPoliza).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCompania).HasColumnName("FK_Compania");
                entity.Property(e => e.FkRamo).HasColumnName("Fk_Ramo");
                entity.Property(e => e.FkSubAgente).HasColumnName("Fk_SubAgente");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_usuario");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.NumeroPoliza).HasMaxLength(150);
                entity.Property(e => e.ObtencionPoliza).HasMaxLength(300);
                entity.Property(e => e.ProductoRamo).HasMaxLength(250);
                entity.Property(e => e.Sede).HasMaxLength(300);
                entity.Property(e => e.TipoVigencia).HasMaxLength(150);
            });

            modelBuilder.Entity<Portadum>(entity =>
            {
                entity.HasKey(e => e.IdPortada).HasName("PK__Portada__7B872C22485FE26B");

                entity.Property(e => e.IdPortada).HasColumnName("Id_Portada");
                entity.Property(e => e.FkGlobal).HasColumnName("Fk_Global");
                entity.Property(e => e.ImagenPortada).HasMaxLength(255);
                entity.Property(e => e.TipoPortada).HasMaxLength(255);
            });

            modelBuilder.Entity<Prima>(entity =>
            {
                entity.HasKey(e => e.IdPrima);

                entity.ToTable("Prima");

                entity.Property(e => e.IdPrima).HasColumnName("Id_Prima");
                entity.Property(e => e.CantidadCuotas).HasColumnName("Cantidad_Cuotas");
                entity.Property(e => e.DocumentoPrima).HasMaxLength(150);
                entity.Property(e => e.FechaRegistroPrima).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FormaPagoPrima).HasMaxLength(150);
                entity.Property(e => e.ImporteCadaCuota).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.ImporteComisionBroker).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.ImporteComisionSubagente).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.NumeroConvenio).HasMaxLength(50);
                entity.Property(e => e.PrimaComercial).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.PrimaMinima).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.PrimaNeta).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.PrimaTotal).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.SumaAsegurada).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TasaRiesgo).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PrimaMinima>(entity =>
            {
                entity.HasKey(e => e.IdPrimaMinima);

                entity.ToTable("PrimaMinima");

                entity.Property(e => e.IdPrimaMinima).HasColumnName("Id_PrimaMinima");
                entity.Property(e => e.FkCompaniaSeguro).HasColumnName("Fk_CompaniaSeguro");
                entity.Property(e => e.PrimaMinimaEmision)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.PrimaMinimaInclusion)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.PrimaMinimaRenovacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("Producto");

                entity.Property(e => e.IdProducto).HasColumnName("Id_Producto");
                entity.Property(e => e.DescripcionCortoProducto).HasMaxLength(50);
                entity.Property(e => e.DescripcionProducto).HasMaxLength(500);
                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProtectaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdProtectaDetalle);

                entity.ToTable("ProtectaDetalle");

                entity.Property(e => e.IdProtectaDetalle).HasColumnName("Id_ProtectaDetalle");
                entity.Property(e => e.ApMaterno).HasMaxLength(50);
                entity.Property(e => e.ApPaterno).HasMaxLength(50);
                entity.Property(e => e.EstadoCivil).HasMaxLength(50);
                entity.Property(e => e.FecNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumIdent).HasMaxLength(50);
                entity.Property(e => e.PaisNacimiento).HasMaxLength(50);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(300);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoIdent).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

            modelBuilder.Entity<Punto>(entity =>
            {
                entity.HasKey(e => e.IdPuntos);

                entity.Property(e => e.IdPuntos).HasColumnName("Id_Puntos");
                entity.Property(e => e.Accion).HasMaxLength(50);
                entity.Property(e => e.EjecutivoAsignado).HasMaxLength(50);
                entity.Property(e => e.EstadoPunto).HasMaxLength(50);
                entity.Property(e => e.FechaRegistroPuntos).HasColumnType("datetime");
                entity.Property(e => e.FkTarea).HasColumnName("Fk_Tarea");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.TipoPunto).HasMaxLength(50);
            });

            modelBuilder.Entity<Ramo>(entity =>
            {
                entity.HasKey(e => e.IdRamo);

                entity.ToTable("Ramo");

                entity.Property(e => e.IdRamo).HasColumnName("Id_Ramo");
                entity.Property(e => e.DescripcionCortoRamo).HasMaxLength(50);
                entity.Property(e => e.DescripcionRamo).HasMaxLength(500);
                entity.Property(e => e.EstadoRamo).HasMaxLength(50);
            });

            modelBuilder.Entity<RamoAccidentesPersonale>(entity =>
            {
                entity.HasKey(e => e.IdRamoAccidentesPersonales);

                entity.ToTable("Ramo_AccidentesPersonales");

                entity.Property(e => e.IdRamoAccidentesPersonales).HasColumnName("Id_Ramo_AccidentesPersonales");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.GiroNegocio).HasColumnName("giro_negocio");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroTrabajadores).HasColumnName("nro_trabajadores");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.UbicacionRiesgo).HasColumnName("ubicacion_riesgo");
            });

            modelBuilder.Entity<RamoAccidentesPersonalesTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoAccidentesPersonalesTemp);

                entity.ToTable("Ramo_AccidentesPersonalesTemp");

                entity.Property(e => e.IdRamoAccidentesPersonalesTemp).HasColumnName("Id_Ramo_AccidentesPersonalesTemp");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.GiroNegocio).HasColumnName("giro_negocio");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroTrabajadores).HasColumnName("nro_trabajadores");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.UbicacionRiesgo).HasColumnName("ubicacion_riesgo");
            });

            modelBuilder.Entity<RamoAsistenciaMedica>(entity =>
            {
                entity.HasKey(e => e.IdRamoAsistenciaMedica);

                entity.ToTable("Ramo_AsistenciaMedica");

                entity.Property(e => e.IdRamoAsistenciaMedica).HasColumnName("Id_Ramo_AsistenciaMedica");
                entity.Property(e => e.Asegurado).HasColumnName("asegurado");
                entity.Property(e => e.Contratante).HasColumnName("contratante");
                entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.NumeroDocumento).HasColumnName("numero_documento");
                entity.Property(e => e.Parentesco).HasColumnName("parentesco");
                entity.Property(e => e.TipoDocumento).HasColumnName("tipo_documento");
            });

            modelBuilder.Entity<RamoAsistenciaMedicaTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoAsistenciaMedicaTemp);

                entity.ToTable("Ramo_AsistenciaMedicaTemp");

                entity.Property(e => e.IdRamoAsistenciaMedicaTemp).HasColumnName("Id_Ramo_AsistenciaMedicaTemp");
                entity.Property(e => e.Asegurado).HasColumnName("asegurado");
                entity.Property(e => e.Contratante).HasColumnName("contratante");
                entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.NumeroDocumento).HasColumnName("numero_documento");
                entity.Property(e => e.Parentesco).HasColumnName("parentesco");
                entity.Property(e => e.TipoDocumento).HasColumnName("tipo_documento");
            });

            modelBuilder.Entity<RamoAuto>(entity =>
            {
                entity.HasKey(e => e.IdRamoAuto);

                entity.ToTable("Ramo_Auto");

                entity.Property(e => e.IdRamoAuto).HasColumnName("Id_Ramo_Auto");
                entity.Property(e => e.Color)
                    .HasMaxLength(500)
                    .HasColumnName("color");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru)
                    .HasMaxLength(50)
                    .HasColumnName("departamento_Peru");
                entity.Property(e => e.Endosatario)
                    .HasMaxLength(500)
                    .HasColumnName("endosatario");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Gas)
                    .HasMaxLength(500)
                    .HasColumnName("gas");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca)
                    .HasMaxLength(500)
                    .HasColumnName("marca");
                entity.Property(e => e.Modelo)
                    .HasMaxLength(500)
                    .HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroAsiento).HasColumnName("nro_asiento");
                entity.Property(e => e.NroDeMotor)
                    .HasMaxLength(500)
                    .HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie)
                    .HasMaxLength(500)
                    .HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa)
                    .HasMaxLength(500)
                    .HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad)
                    .HasMaxLength(500)
                    .HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.Uso)
                    .HasMaxLength(500)
                    .HasColumnName("uso");
            });

            modelBuilder.Entity<RamoAutoTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoAutoTemp);

                entity.ToTable("Ramo_AutoTemp");

                entity.Property(e => e.IdRamoAutoTemp).HasColumnName("Id_Ramo_AutoTemp");
                entity.Property(e => e.Color)
                    .HasMaxLength(500)
                    .HasColumnName("color");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru)
                    .HasMaxLength(50)
                    .HasColumnName("departamento_Peru");
                entity.Property(e => e.Endosatario)
                    .HasMaxLength(500)
                    .HasColumnName("endosatario");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Gas)
                    .HasMaxLength(500)
                    .HasColumnName("gas");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca)
                    .HasMaxLength(500)
                    .HasColumnName("marca");
                entity.Property(e => e.Modelo)
                    .HasMaxLength(500)
                    .HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroAsiento).HasColumnName("nro_asiento");
                entity.Property(e => e.NroDeMotor)
                    .HasMaxLength(500)
                    .HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie)
                    .HasMaxLength(500)
                    .HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa)
                    .HasMaxLength(500)
                    .HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad)
                    .HasMaxLength(500)
                    .HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.Uso)
                    .HasMaxLength(500)
                    .HasColumnName("uso");
            });

            modelBuilder.Entity<RamoCar>(entity =>
            {
                entity.HasKey(e => e.IdRamoCar);

                entity.ToTable("Ramo_Car");

                entity.Property(e => e.IdRamoCar).HasColumnName("Id_Ramo_Car");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.RutaDocumentoContrato)
                    .HasMaxLength(500)
                    .HasColumnName("RutaDocumento_Contrato");
                entity.Property(e => e.RutaDocumentoCronograma)
                    .HasMaxLength(500)
                    .HasColumnName("RutaDocumento_Cronograma");
                entity.Property(e => e.RutaDocumentoMemoria)
                    .HasMaxLength(500)
                    .HasColumnName("RutaDocumento_Memoria");
                entity.Property(e => e.RutaDocumentoPresupuesto)
                    .HasMaxLength(500)
                    .HasColumnName("RutaDocumento_Presupuesto");
                entity.Property(e => e.TipoConstruccion).HasMaxLength(500);
                entity.Property(e => e.UbicacionProyecto).HasMaxLength(500);
            });

            modelBuilder.Entity<RamoDeshonestidad>(entity =>
            {
                entity.HasKey(e => e.IdRamoDeshonestidad);

                entity.ToTable("Ramo_Deshonestidad");

                entity.Property(e => e.IdRamoDeshonestidad).HasColumnName("Id_Ramo_Deshonestidad");
                entity.Property(e => e.ActividadRealizar).HasColumnName("actividad_realizar");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroTrabajadores).HasColumnName("nro_trabajadores");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.UbicacionTrabajo).HasColumnName("ubicacion_trabajo");
            });

            modelBuilder.Entity<RamoDeshonestidadTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoDeshonestidadTemp);

                entity.ToTable("Ramo_DeshonestidadTemp");

                entity.Property(e => e.IdRamoDeshonestidadTemp).HasColumnName("Id_Ramo_DeshonestidadTemp");
                entity.Property(e => e.ActividadRealizar).HasColumnName("actividad_realizar");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroTrabajadores).HasColumnName("nro_trabajadores");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.UbicacionTrabajo).HasColumnName("ubicacion_trabajo");
            });

            modelBuilder.Entity<RamoEp>(entity =>
            {
                entity.HasKey(e => e.IdRamoEps);

                entity.ToTable("Ramo_Eps");

                entity.Property(e => e.IdRamoEps).HasColumnName("Id_Ramo_Eps");
                entity.Property(e => e.Asegurado).HasColumnName("asegurado");
                entity.Property(e => e.CodigoAfiliado).HasColumnName("codigoAfiliado");
                entity.Property(e => e.Contratante).HasColumnName("contratante");
                entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.NumeroDocumento).HasColumnName("numero_documento");
                entity.Property(e => e.Parentesco).HasColumnName("parentesco");
                entity.Property(e => e.TipoDocumento).HasColumnName("tipo_documento");
            });

            modelBuilder.Entity<RamoEpsTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoEpsTemp);

                entity.ToTable("Ramo_EpsTemp");

                entity.Property(e => e.IdRamoEpsTemp).HasColumnName("Id_Ramo_EpsTemp");
                entity.Property(e => e.Asegurado).HasColumnName("asegurado");
                entity.Property(e => e.CodigoAfiliado).HasColumnName("codigoAfiliado");
                entity.Property(e => e.Contratante).HasColumnName("contratante");
                entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.NumeroDocumento).HasColumnName("numero_documento");
                entity.Property(e => e.Parentesco).HasColumnName("parentesco");
                entity.Property(e => e.TipoDocumento).HasColumnName("tipo_documento");
            });

            modelBuilder.Entity<RamoFlotante>(entity =>
            {
                entity.HasKey(e => e.IdRamoFlotante);

                entity.ToTable("Ramo_Flotante");

                entity.Property(e => e.IdRamoFlotante).HasColumnName("Id_Ramo_Flotante");
                entity.Property(e => e.Asegurado).HasColumnName("asegurado");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DescripcionMercaderiaTransportar).HasColumnName("descripcionMercaderia_transportar");
                entity.Property(e => e.Destino).HasColumnName("destino");
                entity.Property(e => e.FechaSalidaOrigen).HasColumnName("fechaSalida_origen");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Origen).HasColumnName("origen");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Tasa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasa");
                entity.Property(e => e.TipoEmbalaje).HasColumnName("tipo_embalaje");
            });

            modelBuilder.Entity<RamoFlotanteTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoFlotanteTemp);

                entity.ToTable("Ramo_FlotanteTemp");

                entity.Property(e => e.IdRamoFlotanteTemp).HasColumnName("Id_Ramo_FlotanteTemp");
                entity.Property(e => e.Asegurado).HasColumnName("asegurado");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DescripcionMercaderiaTransportar).HasColumnName("descripcionMercaderia_transportar");
                entity.Property(e => e.Destino).HasColumnName("destino");
                entity.Property(e => e.FechaSalidaOrigen).HasColumnName("fechaSalida_origen");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Origen).HasColumnName("origen");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Tasa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasa");
                entity.Property(e => e.TipoEmbalaje).HasColumnName("tipo_embalaje");
            });

            modelBuilder.Entity<RamoFola>(entity =>
            {
                entity.HasKey(e => e.IdRamoFola);

                entity.ToTable("Ramo_Fola");

                entity.Property(e => e.IdRamoFola).HasColumnName("Id_Ramo_Fola");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Plan).HasColumnName("plan");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Profesion).HasColumnName("profesion");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SueldoPracticante)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sueldo_practicante");
                entity.Property(e => e.TipoTrabajoPracticante).HasColumnName("tipo_trabajo_practicante");
            });

            modelBuilder.Entity<RamoFolaTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoFolaTemp);

                entity.ToTable("Ramo_FolaTemp");

                entity.Property(e => e.IdRamoFolaTemp).HasColumnName("Id_Ramo_FolaTemp");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Plan).HasColumnName("plan");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Profesion).HasColumnName("profesion");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SueldoPracticante)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sueldo_practicante");
                entity.Property(e => e.TipoTrabajoPracticante).HasColumnName("tipo_trabajo_practicante");
            });

            modelBuilder.Entity<RamoHogar>(entity =>
            {
                entity.HasKey(e => e.IdRamoHogar);

                entity.ToTable("Ramo_Hogar");

                entity.Property(e => e.IdRamoHogar).HasColumnName("Id_Ramo_Hogar");
                entity.Property(e => e.AnioConstruccion).HasColumnName("anio_construccion");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.Direccion).HasColumnName("direccion");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MateriaAsegurada).HasColumnName("materia_asegurada");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NumeroPisos).HasColumnName("numero_pisos");
                entity.Property(e => e.NumeroSotanos).HasColumnName("numero_sotanos");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SumaAseguradaInmueble)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada_inmueble");
                entity.Property(e => e.UsoInmueble).HasColumnName("uso_inmueble");
            });

            modelBuilder.Entity<RamoHogarTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoHogarTemp);

                entity.ToTable("Ramo_HogarTemp");

                entity.Property(e => e.IdRamoHogarTemp).HasColumnName("Id_Ramo_HogarTemp");
                entity.Property(e => e.AnioConstruccion).HasColumnName("anio_construccion");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.Direccion).HasColumnName("direccion");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MateriaAsegurada).HasColumnName("materia_asegurada");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NumeroPisos).HasColumnName("numero_pisos");
                entity.Property(e => e.NumeroSotanos).HasColumnName("numero_sotanos");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SumaAseguradaInmueble)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada_inmueble");
                entity.Property(e => e.UsoInmueble).HasColumnName("uso_inmueble");
            });

            modelBuilder.Entity<RamoIncendio>(entity =>
            {
                entity.HasKey(e => e.IdRamoIncendio);

                entity.ToTable("Ramo_Incendio");

                entity.Property(e => e.IdRamoIncendio).HasColumnName("Id_Ramo_Incendio");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
            });

            modelBuilder.Entity<RamoIncendioTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoIncendioTemp);

                entity.ToTable("Ramo_IncendioTemp");

                entity.Property(e => e.IdRamoIncendioTemp).HasColumnName("Id_Ramo_IncendioTemp");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
            });

            modelBuilder.Entity<RamoRcExtracontractual>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcExtracontractual);

                entity.ToTable("Ramo_RcExtracontractual");

                entity.Property(e => e.IdRamoRcExtracontractual).HasColumnName("Id_Ramo_RcExtracontractual");
                entity.Property(e => e.AseguradoAdicional).HasColumnName("asegurado_Adicional");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru).HasColumnName("departamento_peru");
                entity.Property(e => e.DescripcionActividadProyecto).HasColumnName("descripcion_ActividadProyecto");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.MontoContratado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoContratado");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad).HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.TipoTrabajo).HasColumnName("tipoTrabajo");
                entity.Property(e => e.UbicacionRiesgo).HasColumnName("ubicacionRiesgo");
            });

            modelBuilder.Entity<RamoRcExtracontractualTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcExtracontractualTemp);

                entity.ToTable("Ramo_RcExtracontractualTemp");

                entity.Property(e => e.IdRamoRcExtracontractualTemp).HasColumnName("Id_Ramo_RcExtracontractualTemp");
                entity.Property(e => e.AseguradoAdicional).HasColumnName("asegurado_Adicional");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru).HasColumnName("departamento_peru");
                entity.Property(e => e.DescripcionActividadProyecto).HasColumnName("descripcion_ActividadProyecto");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.MontoContratado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoContratado");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad).HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.TipoTrabajo).HasColumnName("tipoTrabajo");
                entity.Property(e => e.UbicacionRiesgo).HasColumnName("ubicacionRiesgo");
            });

            modelBuilder.Entity<RamoRcMaptel>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcMaptel);

                entity.ToTable("Ramo_RcMaptel");

                entity.Property(e => e.IdRamoRcMaptel).HasColumnName("Id_Ramo_RcMaptel");
                entity.Property(e => e.AseguradoAdicional).HasColumnName("asegurado_adicional");
                entity.Property(e => e.Color).HasColumnName("color");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru).HasColumnName("departamento_Peru");
                entity.Property(e => e.DescripcionActividadProyecto).HasColumnName("descripcion_actividadProyecto");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Gas).HasColumnName("gas");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca).HasColumnName("marca");
                entity.Property(e => e.Modelo).HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.MontoContratado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto_contratado");
                entity.Property(e => e.NroAsiento).HasColumnName("nro_asiento");
                entity.Property(e => e.NroDeMotor).HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie).HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa).HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad).HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.TipoTrabajo).HasColumnName("tipo_trabajo");
                entity.Property(e => e.UbicacionRiesgo).HasColumnName("ubicacion_riesgo");
                entity.Property(e => e.UitAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("uit_asegurada");
            });

            modelBuilder.Entity<RamoRcMaptelTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcMaptelTemp);

                entity.ToTable("Ramo_RcMaptelTemp");

                entity.Property(e => e.IdRamoRcMaptelTemp).HasColumnName("Id_Ramo_RcMaptelTemp");
                entity.Property(e => e.AseguradoAdicional).HasColumnName("asegurado_adicional");
                entity.Property(e => e.Color).HasColumnName("color");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru).HasColumnName("departamento_Peru");
                entity.Property(e => e.DescripcionActividadProyecto).HasColumnName("descripcion_actividadProyecto");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Gas).HasColumnName("gas");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca).HasColumnName("marca");
                entity.Property(e => e.Modelo).HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.MontoContratado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("monto_contratado");
                entity.Property(e => e.NroAsiento).HasColumnName("nro_asiento");
                entity.Property(e => e.NroDeMotor).HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie).HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa).HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad).HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.TipoTrabajo).HasColumnName("tipo_trabajo");
                entity.Property(e => e.UbicacionRiesgo).HasColumnName("ubicacion_riesgo");
                entity.Property(e => e.UitAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("uit_asegurada");
            });

            modelBuilder.Entity<RamoRcMaquinariaTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcMaquinariaTemp);

                entity.ToTable("Ramo_RcMaquinariaTemp");

                entity.Property(e => e.IdRamoRcMaquinariaTemp).HasColumnName("Id_Ramo_RcMaquinariaTemp");
                entity.Property(e => e.AseguradoAdicional).HasColumnName("asegurado_adicional");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru).HasColumnName("departamento_Peru");
                entity.Property(e => e.DescripcionMaquinaria).HasColumnName("descripcion_maquinaria");
                entity.Property(e => e.Endosatario).HasColumnName("endosatario");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca).HasColumnName("marca");
                entity.Property(e => e.Modelo).HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroDeMotor).HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie).HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa).HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad).HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.TipoTrabajo).HasColumnName("tipo_trabajo");
                entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");
                entity.Property(e => e.Uso).HasColumnName("uso");
            });

            modelBuilder.Entity<RamoRcMaquinarium>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcMaquinaria);

                entity.ToTable("Ramo_RcMaquinaria");

                entity.Property(e => e.IdRamoRcMaquinaria).HasColumnName("Id_Ramo_RcMaquinaria");
                entity.Property(e => e.AseguradoAdicional).HasColumnName("asegurado_adicional");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru).HasColumnName("departamento_Peru");
                entity.Property(e => e.DescripcionMaquinaria).HasColumnName("descripcion_maquinaria");
                entity.Property(e => e.Endosatario).HasColumnName("endosatario");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca).HasColumnName("marca");
                entity.Property(e => e.Modelo).HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroDeMotor).HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie).HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa).HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad).HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.TipoTrabajo).HasColumnName("tipo_trabajo");
                entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");
                entity.Property(e => e.Uso).HasColumnName("uso");
            });

            modelBuilder.Entity<RamoRcProfesional>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcProfesional);

                entity.ToTable("Ramo_RcProfesional");

                entity.Property(e => e.IdRamoRcProfesional).HasColumnName("Id_Ramo_RcProfesional");
                entity.Property(e => e.CaracteristicasRiesgo).HasColumnName("caracteristicas_riesgo");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.GiroNegocio).HasColumnName("giro_negocio");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasa_riesgo");
                entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");
                entity.Property(e => e.ValorAsegurado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorAsegurado");
            });

            modelBuilder.Entity<RamoRcProfesionalTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcProfesionalTemp);

                entity.ToTable("Ramo_RcProfesionalTemp");

                entity.Property(e => e.IdRamoRcProfesionalTemp).HasColumnName("Id_Ramo_RcProfesionalTemp");
                entity.Property(e => e.CaracteristicasRiesgo).HasColumnName("caracteristicas_riesgo");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.GiroNegocio).HasColumnName("giro_negocio");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasa_riesgo");
                entity.Property(e => e.Ubicacion).HasColumnName("ubicacion");
                entity.Property(e => e.ValorAsegurado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valorAsegurado");
            });

            modelBuilder.Entity<RamoRcVehicular>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcVehicular);

                entity.ToTable("Ramo_RcVehicular");

                entity.Property(e => e.IdRamoRcVehicular).HasColumnName("Id_Ramo_RcVehicular");
                entity.Property(e => e.Color).HasColumnName("color");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru).HasColumnName("departamento_peru");
                entity.Property(e => e.Endosatario).HasColumnName("endosatario");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Gas).HasColumnName("gas");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca).HasColumnName("marca");
                entity.Property(e => e.Modelo).HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroAsiento).HasColumnName("nro_asiento");
                entity.Property(e => e.NroMotor).HasColumnName("nro_motor");
                entity.Property(e => e.NroSerie).HasColumnName("nro_serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa).HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad).HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.SumaAseguradaRc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAseguradaRC");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.Uso).HasColumnName("uso");
            });

            modelBuilder.Entity<RamoRcVehicularTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoRcVehicularTemp);

                entity.ToTable("Ramo_RcVehicularTemp");

                entity.Property(e => e.IdRamoRcVehicularTemp).HasColumnName("Id_Ramo_RcVehicularTemp");
                entity.Property(e => e.Color).HasColumnName("color");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru).HasColumnName("departamento_peru");
                entity.Property(e => e.Endosatario).HasColumnName("endosatario");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Gas).HasColumnName("gas");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca).HasColumnName("marca");
                entity.Property(e => e.Modelo).HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroAsiento).HasColumnName("nro_asiento");
                entity.Property(e => e.NroMotor).HasColumnName("nro_motor");
                entity.Property(e => e.NroSerie).HasColumnName("nro_serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa).HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad).HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.SumaAseguradaRc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAseguradaRC");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.Uso).HasColumnName("uso");
            });

            modelBuilder.Entity<RamoRoboAsalto>(entity =>
            {
                entity.HasKey(e => e.IdRamoRoboAsalto);

                entity.ToTable("Ramo_RoboAsalto");

                entity.Property(e => e.IdRamoRoboAsalto).HasColumnName("Id_Ramo_RoboAsalto");
                entity.Property(e => e.CaracteristicasRiesgo).HasColumnName("caracteristicas_riesgo");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.GiroNegocio).HasColumnName("giro_negocio");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MateriaAsegurada).HasColumnName("materia_asegurada");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroLocalesAsegurado).HasColumnName("nro_locales_asegurado");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.ValorAsegurado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_asegurado");
                entity.Property(e => e.ValorDeclarado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_declarado");
            });

            modelBuilder.Entity<RamoRoboAsaltoTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoRoboAsaltoTemp);

                entity.ToTable("Ramo_RoboAsaltoTemp");

                entity.Property(e => e.IdRamoRoboAsaltoTemp).HasColumnName("Id_Ramo_RoboAsaltoTemp");
                entity.Property(e => e.CaracteristicasRiesgo).HasColumnName("caracteristicas_riesgo");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.GiroNegocio).HasColumnName("giro_negocio");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MateriaAsegurada).HasColumnName("materia_asegurada");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroLocalesAsegurado).HasColumnName("nro_locales_asegurado");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.ValorAsegurado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_asegurado");
                entity.Property(e => e.ValorDeclarado)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_declarado");
            });

            modelBuilder.Entity<RamoSoat>(entity =>
            {
                entity.HasKey(e => e.IdRamoSoat);

                entity.ToTable("Ramo_Soat");

                entity.Property(e => e.IdRamoSoat).HasColumnName("Id_Ramo_Soat");
                entity.Property(e => e.Color)
                    .HasMaxLength(500)
                    .HasColumnName("color");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru)
                    .HasMaxLength(500)
                    .HasColumnName("departamento_Peru");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca)
                    .HasMaxLength(500)
                    .HasColumnName("marca");
                entity.Property(e => e.Modelo)
                    .HasMaxLength(500)
                    .HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroAsiento).HasColumnName("nro_asiento");
                entity.Property(e => e.NroDeMotor)
                    .HasMaxLength(500)
                    .HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie)
                    .HasMaxLength(500)
                    .HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa)
                    .HasMaxLength(500)
                    .HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad)
                    .HasMaxLength(500)
                    .HasColumnName("siniestralidad");
                entity.Property(e => e.Uso)
                    .HasMaxLength(500)
                    .HasColumnName("uso");
            });

            modelBuilder.Entity<RamoSoatTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoSoatTemp);

                entity.ToTable("Ramo_SoatTemp");

                entity.Property(e => e.IdRamoSoatTemp).HasColumnName("Id_Ramo_SoatTemp");
                entity.Property(e => e.Color)
                    .HasMaxLength(500)
                    .HasColumnName("color");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru)
                    .HasMaxLength(500)
                    .HasColumnName("departamento_Peru");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca)
                    .HasMaxLength(500)
                    .HasColumnName("marca");
                entity.Property(e => e.Modelo)
                    .HasMaxLength(500)
                    .HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroAsiento).HasColumnName("nro_asiento");
                entity.Property(e => e.NroDeMotor)
                    .HasMaxLength(500)
                    .HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie)
                    .HasMaxLength(500)
                    .HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa)
                    .HasMaxLength(500)
                    .HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad)
                    .HasMaxLength(500)
                    .HasColumnName("siniestralidad");
                entity.Property(e => e.Uso)
                    .HasMaxLength(500)
                    .HasColumnName("uso");
            });

            modelBuilder.Entity<RamoTransporte>(entity =>
            {
                entity.HasKey(e => e.IdRamoTransporte);

                entity.ToTable("Ramo_Transporte");

                entity.Property(e => e.IdRamoTransporte).HasColumnName("Id_Ramo_Transporte");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Lea).HasColumnName("lea");
                entity.Property(e => e.Lme).HasColumnName("lme");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.RadioAccion).HasColumnName("radio_accion");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasa_riesgo");
                entity.Property(e => e.TipoMercaderia).HasColumnName("tipo_mercaderia");
            });

            modelBuilder.Entity<RamoTransporteTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoTransporteTemp);

                entity.ToTable("Ramo_TransporteTemp");

                entity.Property(e => e.IdRamoTransporteTemp).HasColumnName("Id_Ramo_TransporteTemp");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Lea).HasColumnName("lea");
                entity.Property(e => e.Lme).HasColumnName("lme");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.RadioAccion).HasColumnName("radio_accion");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasa_riesgo");
                entity.Property(e => e.TipoMercaderia).HasColumnName("tipo_mercaderia");
            });

            modelBuilder.Entity<RamoTrec>(entity =>
            {
                entity.HasKey(e => e.IdRamoTrec);

                entity.ToTable("Ramo_Trec");

                entity.Property(e => e.IdRamoTrec).HasColumnName("Id_Ramo_Trec");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru)
                    .HasMaxLength(500)
                    .HasColumnName("departamento_Peru");
                entity.Property(e => e.DescripcionMaquinaria)
                    .HasMaxLength(500)
                    .HasColumnName("descripcion_maquinaria");
                entity.Property(e => e.Endosatario)
                    .HasMaxLength(500)
                    .HasColumnName("endosatario");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca)
                    .HasMaxLength(500)
                    .HasColumnName("marca");
                entity.Property(e => e.Modelo)
                    .HasMaxLength(500)
                    .HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroDeMotor)
                    .HasMaxLength(500)
                    .HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie)
                    .HasMaxLength(500)
                    .HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa)
                    .HasMaxLength(500)
                    .HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad)
                    .HasMaxLength(500)
                    .HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.TipoTrabajo)
                    .HasMaxLength(500)
                    .HasColumnName("tipo_trabajo");
                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(500)
                    .HasColumnName("ubicacion");
                entity.Property(e => e.Uso)
                    .HasMaxLength(500)
                    .HasColumnName("uso");
            });

            modelBuilder.Entity<RamoTrecTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoTrecTemp);

                entity.ToTable("Ramo_TrecTemp");

                entity.Property(e => e.IdRamoTrecTemp).HasColumnName("Id_Ramo_TrecTemp");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.DepartamentoPeru)
                    .HasMaxLength(500)
                    .HasColumnName("departamento_Peru");
                entity.Property(e => e.DescripcionMaquinaria)
                    .HasMaxLength(500)
                    .HasColumnName("descripcion_maquinaria");
                entity.Property(e => e.Endosatario)
                    .HasMaxLength(500)
                    .HasColumnName("endosatario");
                entity.Property(e => e.Fabricacion).HasColumnName("fabricacion");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.Marca)
                    .HasMaxLength(500)
                    .HasColumnName("marca");
                entity.Property(e => e.Modelo)
                    .HasMaxLength(500)
                    .HasColumnName("modelo");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.NroDeMotor)
                    .HasMaxLength(500)
                    .HasColumnName("nro_de_motor");
                entity.Property(e => e.NroSerie)
                    .HasMaxLength(500)
                    .HasColumnName("nro_Serie");
                entity.Property(e => e.Pc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pc");
                entity.Property(e => e.Placa)
                    .HasMaxLength(500)
                    .HasColumnName("placa");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.Siniestralidad)
                    .HasMaxLength(500)
                    .HasColumnName("siniestralidad");
                entity.Property(e => e.SumaAsegurada)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sumaAsegurada");
                entity.Property(e => e.TasaRiesgo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tasaRiesgo");
                entity.Property(e => e.TipoTrabajo)
                    .HasMaxLength(500)
                    .HasColumnName("tipo_trabajo");
                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(500)
                    .HasColumnName("ubicacion");
                entity.Property(e => e.Uso)
                    .HasMaxLength(500)
                    .HasColumnName("uso");
            });

            modelBuilder.Entity<RamoViajero>(entity =>
            {
                entity.HasKey(e => e.IdRamoViajero);

                entity.ToTable("Ramo_Viajero");

                entity.Property(e => e.IdRamoViajero).HasColumnName("Id_Ramo_Viajero");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.ContactoEmergencia).HasColumnName("contacto_emergencia");
                entity.Property(e => e.Destino).HasColumnName("destino");
                entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("fk_poliza");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Origen).HasColumnName("origen");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.TipoPlan).HasColumnName("tipo_plan");
            });

            modelBuilder.Entity<RamoViajeroTemp>(entity =>
            {
                entity.HasKey(e => e.IdRamoViajeroTemp);

                entity.ToTable("Ramo_ViajeroTemp");

                entity.Property(e => e.IdRamoViajeroTemp).HasColumnName("Id_Ramo_ViajeroTemp");
                entity.Property(e => e.Comision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("comision");
                entity.Property(e => e.ContactoEmergencia).HasColumnName("contacto_emergencia");
                entity.Property(e => e.Destino).HasColumnName("destino");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Items).HasColumnName("items");
                entity.Property(e => e.MontoComision)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("montoComision");
                entity.Property(e => e.Origen).HasColumnName("origen");
                entity.Property(e => e.Pn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pn");
                entity.Property(e => e.Pt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("pt");
                entity.Property(e => e.TipoPlan).HasColumnName("tipo_plan");
            });

            modelBuilder.Entity<RangoEtario>(entity =>
            {
                entity.HasKey(e => e.IdRangoEtario);

                entity.ToTable("RangoEtario");

                entity.Property(e => e.IdRangoEtario).HasColumnName("Id_RangoEtario");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.TasaRangoEtario).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Texto).HasMaxLength(500);
                entity.Property(e => e.TipoRangoEtario).HasMaxLength(500);
            });

            modelBuilder.Entity<Registro>(entity =>
            {
                entity.HasKey(e => e.IdRegistro);

                entity.ToTable("Registro");

                entity.Property(e => e.IdRegistro).HasColumnName("Id_Registro");
                entity.Property(e => e.DescripcionRegistro).HasMaxLength(500);
                entity.Property(e => e.Estado).HasMaxLength(50);
                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCuota).HasColumnName("Fk_Cuota");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.TipoRegistro).HasMaxLength(100);
            });

            modelBuilder.Entity<Reporte>(entity =>
            {
                entity.HasKey(e => e.IdReporte);

                entity.ToTable("Reporte");

                entity.Property(e => e.IdReporte).HasColumnName("idReporte");
                entity.Property(e => e.Estado).HasMaxLength(50);
                entity.Property(e => e.EstadoReunion).HasMaxLength(50);
                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro");
                entity.Property(e => e.FechaReunion).HasColumnType("datetime");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fkUsuario");
                entity.Property(e => e.Json).HasColumnName("json");
            });

            modelBuilder.Entity<RimacDetalle>(entity =>
            {
                entity.HasKey(e => e.IdRimacDetalle);

                entity.ToTable("RimacDetalle");

                entity.Property(e => e.IdRimacDetalle).HasColumnName("Id_RimacDetalle");
                entity.Property(e => e.CodAseguradoR)
                    .HasMaxLength(50)
                    .HasColumnName("Cod_AseguradoR");
                entity.Property(e => e.CondicionTrabajador)
                    .HasMaxLength(50)
                    .HasColumnName("Condicion_Trabajador");
                entity.Property(e => e.Departamento).HasMaxLength(50);
                entity.Property(e => e.Direccion).HasMaxLength(50);
                entity.Property(e => e.Distrito).HasMaxLength(50);
                entity.Property(e => e.FechaInicioM)
                    .HasMaxLength(50)
                    .HasColumnName("Fecha_InicioM");
                entity.Property(e => e.FechaNac).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.MesPlanilla)
                    .HasMaxLength(50)
                    .HasColumnName("Mes_Planilla");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.MonedaPrima)
                    .HasMaxLength(50)
                    .HasColumnName("Moneda_Prima");
                entity.Property(e => e.NivelRiesgo)
                    .HasMaxLength(50)
                    .HasColumnName("Nivel_Riesgo");
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(50);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Provincia).HasMaxLength(50);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.RucCliente)
                    .HasMaxLength(50)
                    .HasColumnName("Ruc_Cliente");
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.Sucursal).HasMaxLength(50);
                entity.Property(e => e.TipoDoc).HasMaxLength(50);
                entity.Property(e => e.TipoMovimient)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Movimient");
                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Producto");
                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<RimacOriginalDetalle>(entity =>
            {
                entity.HasKey(e => e.IdRimacOriginalDetalle);

                entity.ToTable("RimacOriginalDetalle");

                entity.Property(e => e.IdRimacOriginalDetalle).HasColumnName("Id_RimacOriginalDetalle");
                entity.Property(e => e.FechaNac).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.NroDoc).HasMaxLength(50);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Producto).HasMaxLength(150);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoDoc).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

            modelBuilder.Entity<SanitasDetalle>(entity =>
            {
                entity.HasKey(e => e.IdSanitasDetalle);

                entity.ToTable("SanitasDetalle");

                entity.Property(e => e.IdSanitasDetalle).HasColumnName("Id_SanitasDetalle");
                entity.Property(e => e.ApMaterno).HasMaxLength(50);
                entity.Property(e => e.ApPaterno).HasMaxLength(50);
                entity.Property(e => e.EstadoCivil).HasMaxLength(50);
                entity.Property(e => e.FecNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumIdent).HasMaxLength(50);
                entity.Property(e => e.PaisNacimiento).HasMaxLength(50);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede)
                    .HasMaxLength(300)
                    .IsUnicode(false);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoIdent).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroCrecerTemp>(entity =>
            {
                entity.HasKey(e => e.IdCrecerTemp);

                entity.ToTable("Seguro_CrecerTemp");

                entity.Property(e => e.IdCrecerTemp).HasColumnName("Id_CrecerTemp");
                entity.Property(e => e.ApMaterno).HasMaxLength(50);
                entity.Property(e => e.ApPaterno).HasMaxLength(50);
                entity.Property(e => e.EstadoCivil).HasMaxLength(50);
                entity.Property(e => e.FecNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumIdent).HasMaxLength(50);
                entity.Property(e => e.PaisNacimiento).HasMaxLength(50);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(300);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoIdent).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroDetalle>(entity =>
            {
                entity.HasKey(e => e.IdSeguroDetalle);

                entity.ToTable("SeguroDetalle");

                entity.Property(e => e.IdSeguroDetalle).HasColumnName("Id_SeguroDetalle");
                entity.Property(e => e.ApMaterno).HasMaxLength(150);
                entity.Property(e => e.ApPaterno).HasMaxLength(150);
                entity.Property(e => e.EstadoTrabajador).HasMaxLength(150);
                entity.Property(e => e.FechaRetiro).HasColumnType("datetime");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NombresCompletos).HasMaxLength(500);
                entity.Property(e => e.NumDocumento).HasMaxLength(50);
                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TipoDocumento).HasMaxLength(50);
                entity.Property(e => e.TipoSeguro).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(150);
            });

            modelBuilder.Entity<SeguroLaPositivaMineraTemp>(entity =>
            {
                entity.HasKey(e => e.IdLaPositivaMineraTemp);

                entity.ToTable("Seguro_LaPositivaMineraTemp");

                entity.Property(e => e.IdLaPositivaMineraTemp).HasColumnName("Id_LaPositivaMineraTemp");
                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(250)
                    .HasColumnName("apellidoMaterno");
                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(250)
                    .HasColumnName("apellidoPaterno");
                entity.Property(e => e.Categoria)
                    .HasMaxLength(250)
                    .HasColumnName("categoria");
                entity.Property(e => e.Clinica)
                    .HasMaxLength(250)
                    .HasColumnName("clinica");
                entity.Property(e => e.Dni)
                    .HasMaxLength(250)
                    .HasColumnName("dni");
                entity.Property(e => e.FechaNacimiento)
                    .HasMaxLength(250)
                    .HasColumnName("fechaNacimiento");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(250)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Nombres)
                    .HasMaxLength(250)
                    .HasColumnName("nombres");
                entity.Property(e => e.Numero)
                    .HasMaxLength(250)
                    .HasColumnName("numero");
                entity.Property(e => e.PuestoTrabajo)
                    .HasMaxLength(250)
                    .HasColumnName("puestoTrabajo");
                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(250)
                    .HasColumnName("razonSocial");
                entity.Property(e => e.Remuneracion)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("remuneracion");
                entity.Property(e => e.Ruc)
                    .HasMaxLength(250)
                    .HasColumnName("RUC");
                entity.Property(e => e.UnidadMinera)
                    .HasMaxLength(250)
                    .HasColumnName("unidadMinera");
            });

            modelBuilder.Entity<SeguroLaPositivaTemp>(entity =>
            {
                entity.HasKey(e => e.IdLaPositivaTemp);

                entity.ToTable("Seguro_LaPositivaTemp");

                entity.Property(e => e.IdLaPositivaTemp).HasColumnName("Id_LaPositivaTemp");
                entity.Property(e => e.Correo).HasMaxLength(50);
                entity.Property(e => e.Direccion).HasMaxLength(250);
                entity.Property(e => e.EstadoCivil).HasMaxLength(50);
                entity.Property(e => e.FechaNac).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(50);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(300);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.Telefono).HasMaxLength(50);
                entity.Property(e => e.TipoDoc).HasMaxLength(50);
                entity.Property(e => e.TipoTrab).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroMapfreTemp>(entity =>
            {
                entity.HasKey(e => e.IdSeguroMapfreTemp);

                entity.ToTable("Seguro_MapfreTemp");

                entity.Property(e => e.IdSeguroMapfreTemp).HasColumnName("Id_Seguro_MapfreTemp");
                entity.Property(e => e.ApeMaterno)
                    .HasMaxLength(100)
                    .HasColumnName("apeMaterno");
                entity.Property(e => e.ApePaterno)
                    .HasMaxLength(100)
                    .HasColumnName("apePaterno");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Nacimiento)
                    .HasMaxLength(20)
                    .HasColumnName("nacimiento");
                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(500)
                    .HasColumnName("nombre_Completo");
                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .HasColumnName("nombres");
                entity.Property(e => e.NumDoc)
                    .HasMaxLength(50)
                    .HasColumnName("numDoc");
                entity.Property(e => e.Sueldo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sueldo");
                entity.Property(e => e.TipDoc)
                    .HasMaxLength(50)
                    .HasColumnName("tipDoc");
            });

            modelBuilder.Entity<SeguroPacifico2Temp>(entity =>
            {
                entity.HasKey(e => e.IdPacifico2Temp);

                entity.ToTable("Seguro_Pacifico2Temp");

                entity.Property(e => e.IdPacifico2Temp).HasColumnName("Id_Pacifico2Temp");
                entity.Property(e => e.ApellidoMaterno).HasMaxLength(50);
                entity.Property(e => e.ApellidoPaterno).HasMaxLength(50);
                entity.Property(e => e.CodigoAsegurado).HasMaxLength(50);
                entity.Property(e => e.CodigoTipoDocumento).HasMaxLength(50);
                entity.Property(e => e.Condicion).HasMaxLength(50);
                entity.Property(e => e.Departamento).HasMaxLength(70);
                entity.Property(e => e.Direccion).HasMaxLength(150);
                entity.Property(e => e.Distrito).HasMaxLength(70);
                entity.Property(e => e.FechaInicioVigencia).HasMaxLength(50);
                entity.Property(e => e.FechaNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.ImporteSueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MesPlanilla).HasMaxLength(50);
                entity.Property(e => e.MonedaPrima).HasMaxLength(50);
                entity.Property(e => e.MonedaSueldo).HasMaxLength(50);
                entity.Property(e => e.Nacionalidad).HasMaxLength(50);
                entity.Property(e => e.NivelRiesgo).HasMaxLength(50);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(50);
                entity.Property(e => e.Ocupacion).HasMaxLength(70);
                entity.Property(e => e.PrimerNombre).HasMaxLength(50);
                entity.Property(e => e.Provincia).HasMaxLength(70);
                entity.Property(e => e.ProyObra).HasMaxLength(50);
                entity.Property(e => e.Ruc)
                    .HasMaxLength(50)
                    .HasColumnName("RUC");
                entity.Property(e => e.SegundoNombre).HasMaxLength(50);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoMovimiento).HasMaxLength(50);
                entity.Property(e => e.TipoProducto).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroPacificoEpsTemp>(entity =>
            {
                entity.HasKey(e => e.IdPacificoEpsTemp);

                entity.ToTable("Seguro_PacificoEpsTemp");

                entity.Property(e => e.IdPacificoEpsTemp).HasColumnName("Id_PacificoEpsTemp");
                entity.Property(e => e.FechaNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.MonedaSueldo).HasMaxLength(50);
                entity.Property(e => e.Nombre).HasMaxLength(1000);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(50);
                entity.Property(e => e.Plan).HasMaxLength(100);
                entity.Property(e => e.Tarifa).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<SeguroPacificoTemp>(entity =>
            {
                entity.HasKey(e => e.IdPacificoTemp);

                entity.ToTable("Seguro_PacificoTemp");

                entity.Property(e => e.IdPacificoTemp).HasColumnName("Id_PacificoTemp");
                entity.Property(e => e.ApellidoMaterno).HasMaxLength(50);
                entity.Property(e => e.ApellidoPaterno).HasMaxLength(50);
                entity.Property(e => e.FechaNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.ImporteSueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MonedaSueldo).HasMaxLength(50);
                entity.Property(e => e.Nacionalidad).HasMaxLength(50);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(50);
                entity.Property(e => e.Observaciones).HasMaxLength(250);
                entity.Property(e => e.PrimerNombre).HasMaxLength(50);
                entity.Property(e => e.SegundoNombre).HasMaxLength(50);
                entity.Property(e => e.Sexo).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroProtectaTemp>(entity =>
            {
                entity.HasKey(e => e.IdProtectaTemp);

                entity.ToTable("Seguro_ProtectaTemp");

                entity.Property(e => e.IdProtectaTemp).HasColumnName("Id_ProtectaTemp");
                entity.Property(e => e.ApMaterno).HasMaxLength(50);
                entity.Property(e => e.ApPaterno).HasMaxLength(50);
                entity.Property(e => e.EstadoCivil).HasMaxLength(50);
                entity.Property(e => e.FecNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumIdent).HasMaxLength(50);
                entity.Property(e => e.PaisNacimiento).HasMaxLength(50);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(300);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoIdent).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroResuman>(entity =>
            {
                entity.HasKey(e => e.IdSeguroResumen);

                entity.Property(e => e.IdSeguroResumen).HasColumnName("Id_SeguroResumen");
                entity.Property(e => e.DocumentoSeguro).HasMaxLength(200);
                entity.Property(e => e.EstadoAtencion).HasMaxLength(50);
                entity.Property(e => e.EstadoSeguro).HasMaxLength(50);
                entity.Property(e => e.FechaRegistroSeguro).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.SueldoTotal).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<SeguroRimacOriginalTemp>(entity =>
            {
                entity.HasKey(e => e.IdSeguroRimacOriginalTemp);

                entity.ToTable("Seguro_RimacOriginalTemp");

                entity.Property(e => e.IdSeguroRimacOriginalTemp).HasColumnName("Id_Seguro_RimacOriginalTemp");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.NroDoc).HasMaxLength(50);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Producto).HasMaxLength(150);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoDoc).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Trabajador");
            });

            modelBuilder.Entity<SeguroRimacTemp>(entity =>
            {
                entity.HasKey(e => e.IdRimacTemp);

                entity.ToTable("Seguro_RimacTemp");

                entity.Property(e => e.IdRimacTemp).HasColumnName("Id_RimacTemp");
                entity.Property(e => e.CodAseguradoR)
                    .HasMaxLength(50)
                    .HasColumnName("Cod_AseguradoR");
                entity.Property(e => e.CondicionTrabajador)
                    .HasMaxLength(50)
                    .HasColumnName("Condicion_Trabajador");
                entity.Property(e => e.Departamento).HasMaxLength(50);
                entity.Property(e => e.Direccion).HasMaxLength(50);
                entity.Property(e => e.Distrito).HasMaxLength(50);
                entity.Property(e => e.FechaInicioM)
                    .HasMaxLength(50)
                    .HasColumnName("Fecha_InicioM");
                entity.Property(e => e.FechaNac).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.MesPlanilla)
                    .HasMaxLength(50)
                    .HasColumnName("Mes_Planilla");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.MonedaPrima)
                    .HasMaxLength(50)
                    .HasColumnName("Moneda_Prima");
                entity.Property(e => e.NivelRiesgo)
                    .HasMaxLength(50)
                    .HasColumnName("Nivel_Riesgo");
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(50);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Provincia).HasMaxLength(50);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.RucCliente)
                    .HasMaxLength(50)
                    .HasColumnName("Ruc_Cliente");
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.Sucursal).HasMaxLength(50);
                entity.Property(e => e.TipoDoc).HasMaxLength(50);
                entity.Property(e => e.TipoMovimiento).HasMaxLength(50);
                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Producto");
                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroRpatemp>(entity =>
            {
                entity.HasKey(e => e.IdSeguroRpatemp);

                entity.ToTable("SeguroRPATemp");

                entity.Property(e => e.IdSeguroRpatemp).HasColumnName("Id_SeguroRPATemp");
                entity.Property(e => e.FechaFactura).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.NumeroDocumento).HasMaxLength(50);
                entity.Property(e => e.NumeroPoliza).HasMaxLength(50);
                entity.Property(e => e.TipoDocumento).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroSanitasTemp>(entity =>
            {
                entity.HasKey(e => e.IdSanitasTemp);

                entity.ToTable("Seguro_SanitasTemp");

                entity.Property(e => e.IdSanitasTemp).HasColumnName("Id_SanitasTemp");
                entity.Property(e => e.ApMaterno).HasMaxLength(50);
                entity.Property(e => e.ApPaterno).HasMaxLength(50);
                entity.Property(e => e.EstadoCivil).HasMaxLength(50);
                entity.Property(e => e.FecNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumIdent).HasMaxLength(50);
                entity.Property(e => e.PaisNacimiento).HasMaxLength(50);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(300);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoIdent).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroVidaChubbTemp>(entity =>
            {
                entity.HasKey(e => e.IdSeguroVidaTemp).HasName("PK__SeguroVi__E830D2BB8674F148");

                entity.ToTable("SeguroVida_ChubbTemp");

                entity.Property(e => e.IdSeguroVidaTemp).HasColumnName("Id_SeguroVidaTemp");
                entity.Property(e => e.ApeMaterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.ApePaterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.FecNac)
                    .HasMaxLength(20)
                    .IsUnicode(false);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(150)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Genero)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.Movimiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.NroDoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);
                entity.Property(e => e.Pnombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PNombre");
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(10, 2)");
                entity.Property(e => e.Snombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SNombre");
                entity.Property(e => e.TipoDoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SeguroVidaCrecerTemp>(entity =>
            {
                entity.HasKey(e => e.IdVidaCrecerTemp);

                entity.ToTable("SeguroVida_CrecerTemp");

                entity.Property(e => e.IdVidaCrecerTemp).HasColumnName("Id_VidaCrecerTemp");
                entity.Property(e => e.ApMaterno).HasMaxLength(150);
                entity.Property(e => e.ApPaterno).HasMaxLength(150);
                entity.Property(e => e.EstadoCivil).HasMaxLength(150);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Nacionalidad).HasMaxLength(150);
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2).HasMaxLength(150);
                entity.Property(e => e.NumDocumento).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TipoDocumento).HasMaxLength(150);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(150);
            });

            modelBuilder.Entity<SeguroVidaLaPositivaTemp>(entity =>
            {
                entity.HasKey(e => e.IdVidaLaPositivaTemp);

                entity.ToTable("SeguroVida_LaPositivaTemp");

                entity.Property(e => e.IdVidaLaPositivaTemp).HasColumnName("Id_VidaLaPositivaTemp");
                entity.Property(e => e.Correo).HasMaxLength(150);
                entity.Property(e => e.Direccion).HasMaxLength(250);
                entity.Property(e => e.EstadoCivil).HasMaxLength(150);
                entity.Property(e => e.FechaIngreso).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Moneda).HasMaxLength(150);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(150);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Telefono).HasMaxLength(150);
                entity.Property(e => e.TipoDoc).HasMaxLength(150);
                entity.Property(e => e.TipoTrab).HasMaxLength(150);
            });

            modelBuilder.Entity<SeguroVidaMapfreTemp>(entity =>
            {
                entity.HasKey(e => e.IdVidaMapfreTemp);

                entity.ToTable("SeguroVida_MapfreTemp");

                entity.Property(e => e.IdVidaMapfreTemp).HasColumnName("Id_VidaMapfreTemp");
                entity.Property(e => e.ApeMaterno).HasMaxLength(150);
                entity.Property(e => e.ApePaterno).HasMaxLength(150);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.NombreCompleto).HasMaxLength(500);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumDoc).HasMaxLength(150);
                entity.Property(e => e.Ocupacion).HasMaxLength(50);
                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TipDoc).HasMaxLength(150);
                entity.Property(e => e.TipRiesgo).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroVidaPacificoTemp>(entity =>
            {
                entity.HasKey(e => e.IdVidaPacificoTemp);

                entity.ToTable("SeguroVida_PacificoTemp");

                entity.Property(e => e.IdVidaPacificoTemp).HasColumnName("Id_VidaPacificoTemp");
                entity.Property(e => e.ApellidoMaterno).HasMaxLength(150);
                entity.Property(e => e.ApellidoPaterno).HasMaxLength(150);
                entity.Property(e => e.CodigTipoDocumento).HasMaxLength(150);
                entity.Property(e => e.Departamento).HasMaxLength(100);
                entity.Property(e => e.Direccion).HasMaxLength(200);
                entity.Property(e => e.Distrito).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.ImporteSueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nacionalidad).HasMaxLength(50);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(150);
                entity.Property(e => e.Ocupacion).HasMaxLength(100);
                entity.Property(e => e.PrimerNombre).HasMaxLength(150);
                entity.Property(e => e.Provincia).HasMaxLength(100);
                entity.Property(e => e.SegundoNombre).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

            modelBuilder.Entity<SeguroVidaPositivaAdelantadoTemp>(entity =>
            {
                entity.HasKey(e => e.IdSeguroVidaPositivaAdelantadoTemp).HasName("PK_SeguroVida_ProtectaAdelantadoTemp");

                entity.ToTable("SeguroVida_PositivaAdelantadoTemp");

                entity.Property(e => e.IdSeguroVidaPositivaAdelantadoTemp).HasColumnName("Id_SeguroVida_PositivaAdelantadoTemp");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(150)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Moneda).HasMaxLength(150);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(150);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.TipoDoc).HasMaxLength(150);
                entity.Property(e => e.TipoTrab).HasMaxLength(150);
            });

            modelBuilder.Entity<SeguroVidaProtectaTemp>(entity =>
            {
                entity.HasKey(e => e.IdVidaProtectaTemp);

                entity.ToTable("SeguroVida_ProtectaTemp");

                entity.Property(e => e.IdVidaProtectaTemp).HasColumnName("Id_VidaProtectaTemp");
                entity.Property(e => e.ApelidoMaterno).HasMaxLength(150);
                entity.Property(e => e.ApellidoPaterno).HasMaxLength(150);
                entity.Property(e => e.Celular).HasMaxLength(150);
                entity.Property(e => e.CorreoElectronico).HasMaxLength(150);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumDocumento).HasMaxLength(150);
                entity.Property(e => e.PaisNacimiento).HasMaxLength(150);
                entity.Property(e => e.Sede).HasMaxLength(300);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.SueldoBruto).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TipoDocumento).HasMaxLength(150);
                entity.Property(e => e.TipoMovimiento).HasMaxLength(150);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(150);
            });

            modelBuilder.Entity<SeguroVidaRimacOriginalTemp>(entity =>
            {
                entity.HasKey(e => e.IdSeguroVidaRimacOriginalTemp);

                entity.ToTable("SeguroVida_RimacOriginalTemp");

                entity.Property(e => e.IdSeguroVidaRimacOriginalTemp).HasColumnName("Id_SeguroVida_RimacOriginalTemp");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.NroDoc).HasMaxLength(50);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.SucursalEmpresa)
                    .HasMaxLength(500)
                    .HasColumnName("Sucursal_Empresa");
                entity.Property(e => e.TipoDoc).HasMaxLength(50);
                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(500)
                    .HasColumnName("Tipo_Producto");
                entity.Property(e => e.TipoTrabajador)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Trabajador");
            });

            modelBuilder.Entity<SeguroVidaRimacTemp>(entity =>
            {
                entity.HasKey(e => e.IdVidaRimacTemp).HasName("PK_VidaRimacTemp");

                entity.ToTable("SeguroVida_RimacTemp");

                entity.Property(e => e.IdVidaRimacTemp).HasColumnName("Id_VidaRimacTemp");
                entity.Property(e => e.CodAseguradoRimac)
                    .HasMaxLength(150)
                    .HasColumnName("Cod_AseguradoRimac");
                entity.Property(e => e.CondicionTrabajador)
                    .HasMaxLength(150)
                    .HasColumnName("Condicion_Trabajador");
                entity.Property(e => e.Departamento).HasMaxLength(250);
                entity.Property(e => e.Direccion).HasMaxLength(250);
                entity.Property(e => e.Distrito).HasMaxLength(250);
                entity.Property(e => e.FechaInicioMovimiento).HasMaxLength(150);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(150)
                    .HasColumnName("fk_usuario");
                entity.Property(e => e.Item).HasColumnName("item");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.MesPlanilla).HasMaxLength(150);
                entity.Property(e => e.Moneda).HasMaxLength(150);
                entity.Property(e => e.MonedaPrima).HasMaxLength(150);
                entity.Property(e => e.NivelRiesgo).HasMaxLength(150);
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(150);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Provincia).HasMaxLength(250);
                entity.Property(e => e.RucCliente).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.Sucursal).HasMaxLength(150);
                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TipoDoc).HasMaxLength(150);
                entity.Property(e => e.TipoMovimiento).HasMaxLength(150);
                entity.Property(e => e.TipoProducto).HasMaxLength(150);
            });

            modelBuilder.Entity<Siniestro>(entity =>
            {
                entity.HasKey(e => e.IdSiniestro);

                entity.ToTable("Siniestro");

                entity.Property(e => e.IdSiniestro).HasColumnName("Id_Siniestro");
                entity.Property(e => e.AtencionCon)
                    .HasMaxLength(250)
                    .HasColumnName("atencionCon");
                entity.Property(e => e.DenunciaPolicial)
                    .HasMaxLength(250)
                    .HasColumnName("denunciaPolicial");
                entity.Property(e => e.DocumentoSiniestro1).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro10).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro11).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro12).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro13).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro14).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro15).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro2).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro3).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro4).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro5).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro6).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro7).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro8).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestro9).HasMaxLength(250);
                entity.Property(e => e.FechaCreacionSiniestro).HasColumnType("datetime");
                entity.Property(e => e.FechaEntregUnidad).HasColumnType("datetime");
                entity.Property(e => e.FechaSalidaUnidad).HasColumnType("datetime");
                entity.Property(e => e.FechaSiniestro).HasColumnType("datetime");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkUser)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_User");
                entity.Property(e => e.FotoSiniestro1).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro10).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro11).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro12).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro13).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro14).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro15).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro2).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro3).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro4).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro5).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro6).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro7).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro8).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestro9).HasMaxLength(250);
                entity.Property(e => e.Heridos)
                    .HasMaxLength(250)
                    .HasColumnName("heridos");
                entity.Property(e => e.MonedaDanio)
                    .HasMaxLength(250)
                    .HasColumnName("monedaDanio");
                entity.Property(e => e.MotivoSiniestro).HasMaxLength(250);
                entity.Property(e => e.PlacaTercero)
                    .HasMaxLength(250)
                    .HasColumnName("placaTercero");
                entity.Property(e => e.PresupuestoDanio).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TallerAtencionSiniestro).HasMaxLength(250);
                entity.Property(e => e.VehicuOperativo)
                    .HasMaxLength(250)
                    .HasColumnName("vehicuOperativo");
            });

            modelBuilder.Entity<SiniestroCar>(entity =>
            {
                entity.HasKey(e => e.IdSiniestroCar);

                entity.ToTable("SiniestroCar");

                entity.Property(e => e.IdSiniestroCar).HasColumnName("Id_SiniestroCar");
                entity.Property(e => e.CartaSiniestroCar1).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroCar2).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroCar3).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroCar4).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroCar5).HasMaxLength(250);
                entity.Property(e => e.CelularPersonaEncargadaSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.CelularPersonaReporteSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.ConclusionCiasegurosiniestroCar)
                    .HasMaxLength(250)
                    .HasColumnName("ConclusionCIASEGUROSiniestroCar");
                entity.Property(e => e.CorreoPersonaEncargadaSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.DatoAjustadorSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.DeducibleSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar1).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar10).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar11).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar12).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar13).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar14).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar15).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar2).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar3).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar4).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar5).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar6).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar7).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar8).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroCar9).HasMaxLength(250);
                entity.Property(e => e.FechaAbonoIndemnizacionSiniestroCar).HasColumnType("datetime");
                entity.Property(e => e.FechaCreacionSiniestroCar).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistroSiniestroCar).HasColumnType("datetime");
                entity.Property(e => e.FechaReporteCompaniaSiniestroCar).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCompania).HasColumnName("Fk_Compania");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkRamoCar).HasColumnName("Fk_RamoCar");
                entity.Property(e => e.FkUser)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_User");
                entity.Property(e => e.FotoSiniestroCar1).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar10).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar11).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar12).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar13).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar14).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar15).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar2).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar3).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar4).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar5).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar6).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar7).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar8).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroCar9).HasMaxLength(250);
                entity.Property(e => e.InformeFinalSiniestroCar1).HasMaxLength(250);
                entity.Property(e => e.InformeFinalSiniestroCar2).HasMaxLength(250);
                entity.Property(e => e.InformeFinalSiniestroCar3).HasMaxLength(250);
                entity.Property(e => e.InformeFinalSiniestroCar4).HasMaxLength(250);
                entity.Property(e => e.InformeFinalSiniestroCar5).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroCar1).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroCar2).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroCar3).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroCar4).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroCar5).HasMaxLength(250);
                entity.Property(e => e.LugarSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.MonedaIndemnizacionSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.MonedaReclamacionSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.MontoIndemnizacionSiniestroCar).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MontoMinimoDeducibleSiniestroCar).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MontoReclamacionSiniestroCar).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.NombrePersonaReporteSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.NumeroAjusteSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.ObservacionSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.PorcentajeDeducibleSiniestroCar).HasMaxLength(250);
                entity.Property(e => e.ReporteDaniosSiniestroCar1).HasMaxLength(250);
                entity.Property(e => e.ReporteDaniosSiniestroCar2).HasMaxLength(250);
                entity.Property(e => e.ReporteDaniosSiniestroCar3).HasMaxLength(250);
                entity.Property(e => e.ReporteDaniosSiniestroCar4).HasMaxLength(250);
                entity.Property(e => e.ReporteDaniosSiniestroCar5).HasMaxLength(250);
            });

            modelBuilder.Entity<SiniestroSctr>(entity =>
            {
                entity.HasKey(e => e.IdSiniestroSctr);

                entity.ToTable("SiniestroSCTR");

                entity.Property(e => e.IdSiniestroSctr).HasColumnName("Id_SiniestroSCTR");
                entity.Property(e => e.ApematernosiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("apematernosiniestroSCTR");
                entity.Property(e => e.ApepaternosiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("apepaternosiniestroSCTR");
                entity.Property(e => e.ArchivoSiniestroSctr1)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR1");
                entity.Property(e => e.ArchivoSiniestroSctr10)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR10");
                entity.Property(e => e.ArchivoSiniestroSctr11)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR11");
                entity.Property(e => e.ArchivoSiniestroSctr12)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR12");
                entity.Property(e => e.ArchivoSiniestroSctr13)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR13");
                entity.Property(e => e.ArchivoSiniestroSctr14)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR14");
                entity.Property(e => e.ArchivoSiniestroSctr15)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR15");
                entity.Property(e => e.ArchivoSiniestroSctr2)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR2");
                entity.Property(e => e.ArchivoSiniestroSctr3)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR3");
                entity.Property(e => e.ArchivoSiniestroSctr4)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR4");
                entity.Property(e => e.ArchivoSiniestroSctr5)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR5");
                entity.Property(e => e.ArchivoSiniestroSctr6)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR6");
                entity.Property(e => e.ArchivoSiniestroSctr7)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR7");
                entity.Property(e => e.ArchivoSiniestroSctr8)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR8");
                entity.Property(e => e.ArchivoSiniestroSctr9)
                    .HasMaxLength(250)
                    .HasColumnName("ArchivoSiniestroSCTR9");
                entity.Property(e => e.CartaGarantiaSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("cartaGarantiaSiniestroSCTR");
                entity.Property(e => e.ClinicaAtencionSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("clinicaAtencionSiniestroSCTR");
                entity.Property(e => e.ContactoApellidoSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("contactoApellidoSiniestroSCTR");
                entity.Property(e => e.ContactoCargoSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("contactoCargoSiniestroSCTR");
                entity.Property(e => e.ContactoEmailSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("contactoEmailSiniestroSCTR");
                entity.Property(e => e.ContactoNombreSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("contactoNombreSiniestroSCTR");
                entity.Property(e => e.ContactoTelefonoSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("contactoTelefonoSiniestroSCTR");
                entity.Property(e => e.DescansoMedicoSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("descansoMedicoSiniestroSCTR");
                entity.Property(e => e.DescripcionSiniestroSctr).HasColumnName("descripcionSiniestroSCTR");
                entity.Property(e => e.DnisiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("DNISiniestroSCTR");
                entity.Property(e => e.FechaRegistroSiniestroSctr)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaRegistroSiniestroSCTR");
                entity.Property(e => e.FechaSiniestroSctr)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaSiniestroSCTR");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCompania).HasColumnName("Fk_Compania");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkRamoSctr).HasColumnName("Fk_RamoSctr");
                entity.Property(e => e.FkUser)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_User");
                entity.Property(e => e.LiquidacionSctr)
                    .HasMaxLength(250)
                    .HasColumnName("liquidacionSCTR");
                entity.Property(e => e.LugarSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("lugarSiniestroSCTR");
                entity.Property(e => e.NombresiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("nombresiniestroSCTR");
                entity.Property(e => e.ObservacionSctr).HasColumnName("ObservacionSCTR");
                entity.Property(e => e.SolicitudSiniestroSctr1)
                    .HasMaxLength(250)
                    .HasColumnName("SolicitudSiniestroSCTR1");
                entity.Property(e => e.SolicitudSiniestroSctr2)
                    .HasMaxLength(250)
                    .HasColumnName("SolicitudSiniestroSCTR2");
                entity.Property(e => e.SolicitudSiniestroSctr3)
                    .HasMaxLength(250)
                    .HasColumnName("SolicitudSiniestroSCTR3");
                entity.Property(e => e.SolicitudSiniestroSctr4)
                    .HasMaxLength(250)
                    .HasColumnName("SolicitudSiniestroSCTR4");
                entity.Property(e => e.SolicitudSiniestroSctr5)
                    .HasMaxLength(250)
                    .HasColumnName("SolicitudSiniestroSCTR5");
                entity.Property(e => e.TipoSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("tipoSiniestroSCTR");
                entity.Property(e => e.TrasladoSiniestroSctr)
                    .HasMaxLength(250)
                    .HasColumnName("trasladoSiniestroSCTR");
            });

            modelBuilder.Entity<SiniestroTransporte>(entity =>
            {
                entity.HasKey(e => e.IdSiniestroTransporte);

                entity.ToTable("SiniestroTransporte");

                entity.Property(e => e.IdSiniestroTransporte).HasColumnName("Id_SiniestroTransporte");
                entity.Property(e => e.CartaSiniestroTransporte1).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroTransporte2).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroTransporte3).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroTransporte4).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroTransporte5).HasMaxLength(250);
                entity.Property(e => e.CelularPersonaEncargadaSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.CelularPersonaReportoSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.ConclusionCiasegurosiniestroTransporte)
                    .HasMaxLength(250)
                    .HasColumnName("ConclusionCIASEGUROSiniestroTransporte");
                entity.Property(e => e.CorreoPersonaEncargadaSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.DatosAjustadorSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.DeducibleSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte1).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte10).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte11).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte12).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte13).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte14).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte15).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte2).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte3).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte4).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte5).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte6).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte7).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte8).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTransporte9).HasMaxLength(250);
                entity.Property(e => e.FechaAbonoIndemnizacionSiniestroTransporte).HasColumnType("datetime");
                entity.Property(e => e.FechaCreacionSiniestroTransporte).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistroSiniestroTransporte).HasColumnType("datetime");
                entity.Property(e => e.FechaReporteCompaniaSiniestroTransporte).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCompania).HasColumnName("Fk_Compania");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkRamoTransporte).HasColumnName("Fk_RamoTransporte");
                entity.Property(e => e.FkUser)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_User");
                entity.Property(e => e.FotoSiniestroTransporte1).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte10).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte11).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte12).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte13).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte14).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte15).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte2).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte3).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte4).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte5).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte6).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte7).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte8).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTransporte9).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTransporte1).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTransporte2).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTransporte3).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTransporte4).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTransporte5).HasMaxLength(250);
                entity.Property(e => e.LugarSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.MonedaIndemnizacionSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.MonedaReclamacionSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.MontoIndemnizacionSiniestroTransporte).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MontoMinimoDeducibleSiniestroTransporte).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MontoReclamacionSiniestroTransporte).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.NombrePersonaReportoSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.NumeroAjusteSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.ObservacionSiniestroTransporte).HasMaxLength(250);
                entity.Property(e => e.PorcentajeDeducibleSiniestroTransporte).HasMaxLength(250);
            });

            modelBuilder.Entity<SiniestroTrec>(entity =>
            {
                entity.HasKey(e => e.IdSiniestroTrec);

                entity.ToTable("SiniestroTrec");

                entity.Property(e => e.IdSiniestroTrec).HasColumnName("Id_SiniestroTrec");
                entity.Property(e => e.CartaSiniestroTrec1).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroTrec2).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroTrec3).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroTrec4).HasMaxLength(250);
                entity.Property(e => e.CartaSiniestroTrec5).HasMaxLength(250);
                entity.Property(e => e.CelularPersonaEncargadaSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.CelularPersonaReportoSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.ConclusionCiasegurosiniestroTrec)
                    .HasMaxLength(250)
                    .HasColumnName("ConclusionCIASEGUROSiniestroTrec");
                entity.Property(e => e.CorreoPersonaEncargadaSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.DatosAjustadorSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.DeducibleSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec1).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec10).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec11).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec12).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec13).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec14).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec15).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec2).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec3).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec4).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec5).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec6).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec7).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec8).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroTrec9).HasMaxLength(250);
                entity.Property(e => e.FechaAbonoIndemnizacionSiniestroTrec).HasColumnType("datetime");
                entity.Property(e => e.FechaCreacionSiniestroTrec).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistroSiniestroTrec).HasColumnType("datetime");
                entity.Property(e => e.FechaReporteCompaniaSiniestroTrec).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCompania).HasColumnName("Fk_Compania");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkRamoTrec).HasColumnName("Fk_RamoTrec");
                entity.Property(e => e.FkUser)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_User");
                entity.Property(e => e.FotoSiniestroTrec1).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec10).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec11).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec12).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec13).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec14).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec15).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec2).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec3).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec4).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec5).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec6).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec7).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec8).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroTrec9).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTrec1).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTrec2).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTrec3).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTrec4).HasMaxLength(250);
                entity.Property(e => e.InformeSiniestroTrec5).HasMaxLength(250);
                entity.Property(e => e.LugarSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.MonedaIndemnizacionSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.MonedaReclamacionSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.MontoIndenminazcionSiniestroTrec).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MontoMinimoDeducibleSiniestroTrec).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MontoReclamadoSiniestroTrec).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.NombrePersonaReportoSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.NumeroAjusteSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.ObservacionSiniestroTrec).HasMaxLength(250);
                entity.Property(e => e.PorcentajeDeducibleSiniestroTrec).HasMaxLength(250);
            });

            modelBuilder.Entity<SiniestroVehicular>(entity =>
            {
                entity.HasKey(e => e.IdSiniestroVehicular);

                entity.ToTable("SiniestroVehicular");

                entity.Property(e => e.IdSiniestroVehicular).HasColumnName("Id_SiniestroVehicular");
                entity.Property(e => e.DañoSiniestroVehicular).HasMaxLength(250);
                entity.Property(e => e.DeducibleSiniestroVehicular).HasMaxLength(500);
                entity.Property(e => e.DenunciaPolicialSiniestroVehicular).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular1).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular10).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular11).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular12).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular13).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular14).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular15).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular2).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular3).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular4).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular5).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular6).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular7).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular8).HasMaxLength(250);
                entity.Property(e => e.DocumentoSiniestroVehicular9).HasMaxLength(250);
                entity.Property(e => e.EntregaUnidadSiniestroVehicular).HasColumnType("datetime");
                entity.Property(e => e.FechaCreacionSiniestroVehicular).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistroSiniestroVehicular).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCompania).HasColumnName("Fk_Compania");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkRamoVehicular).HasColumnName("Fk_RamoVehicular");
                entity.Property(e => e.FkUser)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_User");
                entity.Property(e => e.FotoSiniestroVehicular1).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular10).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular11).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular12).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular13).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular14).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular15).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular2).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular3).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular4).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular5).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular6).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular7).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular8).HasMaxLength(250);
                entity.Property(e => e.FotoSiniestroVehicular9).HasMaxLength(250);
                entity.Property(e => e.GpssiniestroVehicular)
                    .HasMaxLength(250)
                    .HasColumnName("GPSSiniestroVehicular");
                entity.Property(e => e.HeridosSiniestroVehicular).HasMaxLength(250);
                entity.Property(e => e.MonedaDanioSiniestroVehicular).HasMaxLength(250);
                entity.Property(e => e.MontoMinimoDeducibleSiniestroVehicular).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.PlacaTerceroSiniestroVehicular).HasMaxLength(250);
                entity.Property(e => e.PorcentajeDeducibleSiniestroVehicular).HasMaxLength(500);
                entity.Property(e => e.PresupuestoSiniestroVehicular).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.SalidaUnidadSiniestroVehicular).HasColumnType("datetime");
                entity.Property(e => e.SoatsiniestroVehicular)
                    .HasMaxLength(250)
                    .HasColumnName("SOATSiniestroVehicular");
                entity.Property(e => e.TallerAtencionSiniestroVehicular).HasMaxLength(250);
                entity.Property(e => e.VehiculoOperativoSiniestroVehicular).HasMaxLength(250);
            });

            modelBuilder.Entity<SiniestroVidaLey>(entity =>
            {
                entity.HasKey(e => e.IdSiniestroVidaLey);

                entity.ToTable("SiniestroVidaLey");

                entity.Property(e => e.IdSiniestroVidaLey).HasColumnName("Id_SiniestroVidaLey");
                entity.Property(e => e.ApematernoVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("apematernoVidaLey");
                entity.Property(e => e.ApepaternoVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("apepaternoVidaLey");
                entity.Property(e => e.ArchivoSiniestroVidaLey1).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey10).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey11).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey12).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey13).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey14).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey15).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey2).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey3).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey4).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey5).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey6).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey7).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey8).HasMaxLength(250);
                entity.Property(e => e.ArchivoSiniestroVidaLey9).HasMaxLength(250);
                entity.Property(e => e.CausaFallecimientoSiniestroVidaLey).HasMaxLength(250);
                entity.Property(e => e.CoberturaAdicionalSiniestroVidaLey).HasMaxLength(250);
                entity.Property(e => e.CoberturaSiniestroVidaLey1).HasMaxLength(250);
                entity.Property(e => e.CoberturaSiniestroVidaLey2).HasMaxLength(250);
                entity.Property(e => e.CoberturaSiniestroVidaLey3).HasMaxLength(250);
                entity.Property(e => e.CoberturaSiniestroVidaLey4).HasMaxLength(250);
                entity.Property(e => e.CoberturaSiniestroVidaLey5).HasMaxLength(250);
                entity.Property(e => e.ContactoApellidoSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("contactoApellidoSiniestroVidaLey");
                entity.Property(e => e.ContactoCargoSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("contactoCargoSiniestroVidaLey");
                entity.Property(e => e.ContactoEmailSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("contactoEmailSiniestroVidaLey");
                entity.Property(e => e.ContactoNombreSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("contactoNombreSiniestroVidaLey");
                entity.Property(e => e.ContactoTelefonoSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("contactoTelefonoSiniestroVidaLey");
                entity.Property(e => e.DnisiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("DNISiniestroVidaLey");
                entity.Property(e => e.EncargadaApellidoSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("encargadaApellidoSiniestroVidaLey");
                entity.Property(e => e.EncargadaCargoSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("encargadaCargoSiniestroVidaLey");
                entity.Property(e => e.EncargadaEmailSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("encargadaEmailSiniestroVidaLey");
                entity.Property(e => e.EncargadaNombreSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("encargadaNombreSiniestroVidaLey");
                entity.Property(e => e.EncargadaTelefonoSiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("encargadaTelefonoSiniestroVidaLey");
                entity.Property(e => e.FechaAvisoSiniestroVidaLey).HasColumnType("datetime");
                entity.Property(e => e.FechaDecesoSiniestroVidaLey).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistroSiniestroVidaLey).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCompania).HasColumnName("Fk_Compania");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkRamoVida).HasColumnName("Fk_RamoVida");
                entity.Property(e => e.FkUser)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_User");
                entity.Property(e => e.MotivoFallecimientoSiniestroVidaLey).HasMaxLength(250);
                entity.Property(e => e.NombresiniestroVidaLey)
                    .HasMaxLength(250)
                    .HasColumnName("nombresiniestroVidaLey");
                entity.Property(e => e.SolicitudSiniestroVidaLey1).HasMaxLength(250);
                entity.Property(e => e.SolicitudSiniestroVidaLey2).HasMaxLength(250);
                entity.Property(e => e.SolicitudSiniestroVidaLey3).HasMaxLength(250);
                entity.Property(e => e.SolicitudSiniestroVidaLey4).HasMaxLength(250);
                entity.Property(e => e.SolicitudSiniestroVidaLey5).HasMaxLength(250);
            });

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.ToTable("Solicitud");

                entity.Property(e => e.IdSolicitud).HasColumnName("Id_Solicitud");
                entity.Property(e => e.DescripcionSolicitud).HasMaxLength(200);
                entity.Property(e => e.EstadoSolicitud).HasMaxLength(50);
                entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.TipoSolicitud).HasMaxLength(50);
                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<SolicitudCliente>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudCliente).HasName("PK__Solicitu__1A9E17FCF7A284B9");

                entity.ToTable("SolicitudCliente");

                entity.Property(e => e.IdSolicitudCliente).HasColumnName("Id_SolicitudCliente");
                entity.Property(e => e.BloqueRh).HasColumnName("Bloque_RH");
                entity.Property(e => e.DetalleError).HasDefaultValue("Ninguno");
                entity.Property(e => e.EstadoSolicitud).HasMaxLength(50);
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_Poliza");
                entity.Property(e => e.TipoError).HasDefaultValue("Ninguno");
                entity.Property(e => e.UsuarioIniciaSolicitud).HasDefaultValue("");
                entity.Property(e => e.UsuarioTerminaSolicitud).HasDefaultValue("");
            });

            modelBuilder.Entity<SubAgente>(entity =>
            {
                entity.HasKey(e => e.IdSubAgente);

                entity.ToTable("SubAgente");

                entity.Property(e => e.IdSubAgente).HasColumnName("Id_SubAgente");
                entity.Property(e => e.DescripcionSubAgente).HasMaxLength(50);
            });

            modelBuilder.Entity<Tarea>(entity =>
            {
                entity.HasKey(e => e.IdTarea);

                entity.ToTable("Tarea");

                entity.Property(e => e.IdTarea).HasColumnName("Id_Tarea");
                entity.Property(e => e.ArchivoTarea).HasMaxLength(500);
                entity.Property(e => e.ArchivoTarea1).HasMaxLength(500);
                entity.Property(e => e.ArchivoTarea2).HasMaxLength(500);
                entity.Property(e => e.ArchivoTarea3).HasMaxLength(500);
                entity.Property(e => e.ArchivoTarea4).HasMaxLength(500);
                entity.Property(e => e.ArchivoTarea5).HasMaxLength(500);
                entity.Property(e => e.EjecutivoApoyo).HasMaxLength(50);
                entity.Property(e => e.EstadoTarea).HasMaxLength(500);
                entity.Property(e => e.FechaRegistroTarea).HasColumnType("datetime");
                entity.Property(e => e.FechaRespuesta).HasColumnType("datetime");
                entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.Usuario).HasMaxLength(50);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.IdTicket);

                entity.ToTable("Ticket");

                entity.Property(e => e.IdTicket).HasColumnName("Id_Ticket");
                entity.Property(e => e.AsignadoA).HasMaxLength(150);
                entity.Property(e => e.DescripcionTicket).HasMaxLength(500);
                entity.Property(e => e.EstadoTicket).HasMaxLength(50);
                entity.Property(e => e.FechaModificable1).HasColumnType("datetime");
                entity.Property(e => e.FechaModificable2).HasColumnType("datetime");
                entity.Property(e => e.FechaModificable3).HasColumnType("datetime");
                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
                entity.Property(e => e.FkCliente).HasColumnName("Fk_Cliente");
                entity.Property(e => e.FkCuotas)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_Cuotas");
                entity.Property(e => e.FkPolizas)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_Polizas");
                entity.Property(e => e.FkResponsable)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Responsable");
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(150)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.GeneracionTicket)
                    .HasMaxLength(550)
                    .IsUnicode(false);
                entity.Property(e => e.ImagenTicket).HasMaxLength(500);
                entity.Property(e => e.RespuestaTicket).HasMaxLength(500);
                entity.Property(e => e.TextoTicket)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.TipoTicket).HasMaxLength(150);
                entity.Property(e => e.TrabajadorDni)
                    .HasMaxLength(150)
                    .HasColumnName("TrabajadorDNI");
                entity.Property(e => e.ValorTicket).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TopeRemuneracion>(entity =>
            {
                entity.HasKey(e => e.IdTopeRemuneracion);

                entity.ToTable("TopeRemuneracion");

                entity.Property(e => e.IdTopeRemuneracion).HasColumnName("Id_TopeRemuneracion");
                entity.Property(e => e.EstadoTopeRemuneracion).HasMaxLength(50);
                entity.Property(e => e.SueldoTope).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TramaCliente>(entity =>
            {
                entity.HasKey(e => e.IdTramaCliente);

                entity.ToTable("TramaCliente");

                entity.Property(e => e.IdTramaCliente).HasColumnName("Id_TramaCliente");
                entity.Property(e => e.ApMaterno).HasMaxLength(100);
                entity.Property(e => e.ApPaterno).HasMaxLength(100);
                entity.Property(e => e.EstadoCivil).HasMaxLength(50);
                entity.Property(e => e.FecNacimiento).HasMaxLength(50);
                entity.Property(e => e.FkUsuario)
                    .HasMaxLength(50)
                    .HasColumnName("Fk_Usuario");
                entity.Property(e => e.Nombres).HasMaxLength(300);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(50);
                entity.Property(e => e.PaisNacimiento).HasMaxLength(100);
                entity.Property(e => e.Pension).HasMaxLength(50);
                entity.Property(e => e.RemuneracionSctr).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.RemuneracionVidaLey).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Salud).HasMaxLength(50);
                entity.Property(e => e.Sede).HasMaxLength(100);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoDocumento).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajadorSctr).HasMaxLength(100);
                entity.Property(e => e.TipoTrabajadorVidaLey).HasMaxLength(100);
                entity.Property(e => e.VidaLey).HasMaxLength(50);
            });

            modelBuilder.Entity<VidaCrecerDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVidaCrecerDetalle);

                entity.ToTable("VidaCrecerDetalle");

                entity.Property(e => e.IdVidaCrecerDetalle).HasColumnName("Id_VidaCrecerDetalle");
                entity.Property(e => e.ApMaterno).HasMaxLength(150);
                entity.Property(e => e.ApPaterno).HasMaxLength(150);
                entity.Property(e => e.EstadoCivil).HasMaxLength(150);
                entity.Property(e => e.FechaNac).HasMaxLength(150);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Nacionalidad).HasMaxLength(150);
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2).HasMaxLength(150);
                entity.Property(e => e.NumDocumento).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TipoDocumento).HasMaxLength(150);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(150);
            });

            modelBuilder.Entity<VidaLaPositivaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVidaLaPositivaDetalle);

                entity.ToTable("VidaLaPositivaDetalle");

                entity.Property(e => e.IdVidaLaPositivaDetalle).HasColumnName("Id_VidaLaPositivaDetalle");
                entity.Property(e => e.Correo).HasMaxLength(150);
                entity.Property(e => e.Direccion).HasMaxLength(250);
                entity.Property(e => e.EstadoCivil).HasMaxLength(150);
                entity.Property(e => e.FechaIngreso).HasMaxLength(50);
                entity.Property(e => e.FechaNac).HasMaxLength(150);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Moneda).HasMaxLength(150);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(150);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Telefono).HasMaxLength(150);
                entity.Property(e => e.TipoDoc).HasMaxLength(150);
                entity.Property(e => e.TipoTrab).HasMaxLength(150);
            });

            modelBuilder.Entity<VidaMapfreDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVidaMapfreDetalle);

                entity.ToTable("VidaMapfreDetalle");

                entity.Property(e => e.IdVidaMapfreDetalle).HasColumnName("Id_VidaMapfreDetalle");
                entity.Property(e => e.ApeMaterno).HasMaxLength(150);
                entity.Property(e => e.ApePaterno).HasMaxLength(150);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Nacimiento).HasMaxLength(150);
                entity.Property(e => e.NombreCompleto).HasMaxLength(500);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumDoc).HasMaxLength(150);
                entity.Property(e => e.Ocupacion).HasMaxLength(50);
                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TipDoc).HasMaxLength(150);
                entity.Property(e => e.TipRiesgo).HasMaxLength(50);
            });

            modelBuilder.Entity<VidaPacificoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVidaPacificoDetalle);

                entity.ToTable("VidaPacificoDetalle");

                entity.Property(e => e.IdVidaPacificoDetalle).HasColumnName("Id_VidaPacificoDetalle");
                entity.Property(e => e.ApellidoMaterno).HasMaxLength(150);
                entity.Property(e => e.ApellidoPaterno).HasMaxLength(150);
                entity.Property(e => e.CodigTipoDocumento).HasMaxLength(150);
                entity.Property(e => e.Departamento).HasMaxLength(100);
                entity.Property(e => e.Direccion).HasMaxLength(200);
                entity.Property(e => e.Distrito).HasMaxLength(50);
                entity.Property(e => e.FechaNacimiento).HasMaxLength(150);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.ImporteSueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Moneda).HasMaxLength(50);
                entity.Property(e => e.Nacionalidad).HasMaxLength(50);
                entity.Property(e => e.NumeroDocumento).HasMaxLength(150);
                entity.Property(e => e.Ocupacion).HasMaxLength(100);
                entity.Property(e => e.PrimerNombre).HasMaxLength(150);
                entity.Property(e => e.Provincia).HasMaxLength(100);
                entity.Property(e => e.SegundoNombre).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

            modelBuilder.Entity<VidaPositivaAdelantadoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVidaPositivaAdelantadoDetalle).HasName("PK_VidaProtectaAdelantadoDetalle");

                entity.ToTable("VidaPositivaAdelantadoDetalle");

                entity.Property(e => e.IdVidaPositivaAdelantadoDetalle).HasColumnName("Id_VidaPositivaAdelantadoDetalle");
                entity.Property(e => e.FechaNac).HasMaxLength(150);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Moneda).HasMaxLength(150);
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(150);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sede).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.TipoDoc).HasMaxLength(150);
                entity.Property(e => e.TipoTrab).HasMaxLength(150);
            });

            modelBuilder.Entity<VidaProtectaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVidaProtectaDetalle);

                entity.ToTable("VidaProtectaDetalle");

                entity.Property(e => e.IdVidaProtectaDetalle).HasColumnName("Id_VidaProtectaDetalle");
                entity.Property(e => e.ApelidoMaterno).HasMaxLength(150);
                entity.Property(e => e.ApellidoPaterno).HasMaxLength(150);
                entity.Property(e => e.Celular).HasMaxLength(150);
                entity.Property(e => e.CorreoElectronico).HasMaxLength(150);
                entity.Property(e => e.FechaNac).HasMaxLength(150);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Nombres).HasMaxLength(150);
                entity.Property(e => e.NumDocumento).HasMaxLength(150);
                entity.Property(e => e.PaisNacimiento).HasMaxLength(150);
                entity.Property(e => e.Sede).HasMaxLength(300);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.SueldoBruto).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TipoDocumento).HasMaxLength(150);
                entity.Property(e => e.TipoMovimiento).HasMaxLength(150);
                entity.Property(e => e.TipoTrabajador).HasMaxLength(150);
            });

            modelBuilder.Entity<VidaRimacDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVidaRimacDetalle);

                entity.ToTable("VidaRimacDetalle");

                entity.Property(e => e.IdVidaRimacDetalle).HasColumnName("Id_VidaRimacDetalle");
                entity.Property(e => e.CodAseguradoRimac)
                    .HasMaxLength(150)
                    .HasColumnName("Cod_AseguradoRimac");
                entity.Property(e => e.CondicionTrabajador)
                    .HasMaxLength(150)
                    .HasColumnName("Condicion_Trabajador");
                entity.Property(e => e.Departamento).HasMaxLength(250);
                entity.Property(e => e.Direccion).HasMaxLength(250);
                entity.Property(e => e.Distrito).HasMaxLength(250);
                entity.Property(e => e.FechaInicioMovimiento).HasMaxLength(150);
                entity.Property(e => e.FechaNac).HasMaxLength(150);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.MesPlanilla).HasMaxLength(150);
                entity.Property(e => e.Moneda).HasMaxLength(150);
                entity.Property(e => e.MonedaPrima).HasMaxLength(150);
                entity.Property(e => e.NivelRiesgo).HasMaxLength(150);
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2).HasMaxLength(150);
                entity.Property(e => e.NroDoc).HasMaxLength(150);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Provincia).HasMaxLength(250);
                entity.Property(e => e.RucCliente).HasMaxLength(150);
                entity.Property(e => e.Sexo).HasMaxLength(150);
                entity.Property(e => e.Sucursal).HasMaxLength(150);
                entity.Property(e => e.Sueldo).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.TipoDoc).HasMaxLength(150);
                entity.Property(e => e.TipoMovimiento).HasMaxLength(150);
                entity.Property(e => e.TipoProducto).HasMaxLength(150);
                entity.Property(e => e.Usuario).HasMaxLength(150);
            });

            modelBuilder.Entity<VidaRimacOriginalDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVidaRimacOriginalDetalle).HasName("PK_VidaRimacOriginalcDetalle");

                entity.ToTable("VidaRimacOriginalDetalle");

                entity.Property(e => e.IdVidaRimacOriginalDetalle).HasColumnName("Id_VidaRimacOriginalDetalle");
                entity.Property(e => e.FechaNac).HasMaxLength(50);
                entity.Property(e => e.FkCliente).HasColumnName("Fk_cliente");
                entity.Property(e => e.FkPoliza).HasColumnName("Fk_poliza");
                entity.Property(e => e.FkSeguroResumen).HasColumnName("Fk_SeguroResumen");
                entity.Property(e => e.Materno).HasMaxLength(150);
                entity.Property(e => e.Nombre1).HasMaxLength(150);
                entity.Property(e => e.Nombre2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.NroDoc).HasMaxLength(50);
                entity.Property(e => e.Paterno).HasMaxLength(150);
                entity.Property(e => e.Remuneracion).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.Sexo).HasMaxLength(50);
                entity.Property(e => e.SucursalEmpresa)
                    .HasMaxLength(500)
                    .HasColumnName("Sucursal_Empresa");
                entity.Property(e => e.TipoDoc).HasMaxLength(50);
                entity.Property(e => e.TipoProducto)
                    .HasMaxLength(500)
                    .HasColumnName("Tipo_Producto");
                entity.Property(e => e.TipoTrabajador).HasMaxLength(50);
            });

        }
    }
}
