using Birlik.Models;
using Birlik.Models.Entities;
using Birlik.Models.Entities.Ramos;
using Birlik.Models.Entities.Rpa;
using Birlik.Models.Entities.Sctr_Vidaley;
using Birlik.Models.Entities.Siniestros;
using Birlik.Models.Entities.Temporales;
using Microsoft.EntityFrameworkCore;

namespace Birlik.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //------------STAR MIGUEL

        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<SubAgente> SubAgente { get; set; }

        public virtual DbSet<GiroNegocio> GiroNegocio { get; set; }

        public virtual DbSet<GrupoEconomico> GrupoEconomico { get; set; }

        public virtual DbSet<Poliza> Poliza { get; set; }

        public virtual DbSet<Prima> Prima { get; set; }

        public virtual DbSet<Cuota> Cuota { get; set; }

        public virtual DbSet<GPS> GPS { get; set; }

        public virtual DbSet<CompaniaGPS> CompaniaGPS { get; set; }

        public virtual DbSet<Ramo> Ramo { get; set; }

        public virtual DbSet<CompaniaSeguro> CompaniaSeguro { get; set; }

        public virtual DbSet<Registro> Registro { get; set; }

        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<Mensaje> Mensaje { get; set; }

        public virtual DbSet<Notificacion> Notificacion { get; set; }

        public virtual DbSet<DetalleUsuario> DetalleUsuario { get; set; }

        public virtual DbSet<Documento> Documento { get; set; }

        public virtual DbSet<TopeRemuneracion> TopeRemuneracion { get; set; }

        public virtual DbSet<Factura> Factura { get; set; }

        public virtual DbSet<PuntuacionUsuario> PuntuacionUsuario { get; set; }

        public virtual DbSet<PrimaMinima> PrimaMinima { get; set; }

        public virtual DbSet<Siniestro> Siniestro { get; set; }

        public virtual DbSet<Tarea> Tarea { get; set; }

        public virtual DbSet<Nota> Nota { get; set; }

        public virtual DbSet<RangoEtario> RangoEtario { get; set; }

        public virtual DbSet<SeguroRPATemp> SeguroRPATemp { get; set; }

        public virtual DbSet<Ticket> Ticket { get; set; }

        public virtual DbSet<CorreoPorPoliza> CorreoPorPoliza { get; set; }

        public virtual DbSet<Autorizacion> Autorizacion { get; set; }

        public virtual DbSet<Puntos> Puntos { get; set; }

        public virtual DbSet<Evento> Evento { get; set; }

        public virtual DbSet<DetalleEvento> DetalleEvento { get; set; }

        public virtual DbSet<SiniestroSCTR> SiniestroSCTR { get; set; }

        public virtual DbSet<SiniestroVidaLey> SiniestroVidaLey { get; set; }

        public virtual DbSet<SiniestroVehicular> SiniestroVehicular { get; set; }

        public virtual DbSet<SiniestroTrec> SiniestroTrec { get; set; }

        public virtual DbSet<SiniestroCar> SiniestroCar { get; set; }

        public virtual DbSet<SiniestroTransporte> SiniestroTransporte { get; set; }

        public virtual DbSet<TramaCliente> TramaCliente { get; set; }

        public virtual DbSet<Observacion> Observacion { get; set; }

        public virtual DbSet<Cabecera> Cabecera { get; set; }

        public virtual DbSet<CorreoHistorialError> CorreoHistorialError { get; set; }

        public virtual DbSet<CorreoHistorial> CorreoHistorial { get; set; }

        public virtual DbSet<CorreoPorCliente> CorreoPorCliente { get; set; }

        public virtual DbSet<EncargadoCliente> EncargadoCliente { get; set; }

        public virtual DbSet<Anuncio> Anuncio { get; set; }

        public virtual DbSet<HistorialCorreos> HistorialCorreos { get; set; }

        public virtual DbSet<Adjuntos> Adjuntos { get; set; }

        public virtual DbSet<Personalizado> Personalizado { get; set; }

        public virtual DbSet<Organizacion> Organizacion { get; set; }

        public virtual DbSet<MensajeEnviado> MensajeEnviado { get; set; }

        //RAMOS----------------------
        public virtual DbSet<Ramo_Auto> Ramo_Auto { get; set; }
        public virtual DbSet<Ramo_Soat> Ramo_Soat { get; set; }
        public virtual DbSet<Ramo_Trec> Ramo_Trec { get; set; }
        public virtual DbSet<Ramo_Car> Ramo_Car { get; set; }
        public virtual DbSet<Ramo_Eps> Ramo_Eps { get; set; }
        public virtual DbSet<Ramo_Incendio> Ramo_Incendio { get; set; }
        public virtual DbSet<Ramo_RcMaquinaria> Ramo_RcMaquinaria { get; set; }
        public virtual DbSet<Ramo_RcMaptel> Ramo_RcMaptel { get; set; }
        public virtual DbSet<Ramo_RcVehicular> Ramo_RcVehicular { get; set; }
        public virtual DbSet<Ramo_RcExtracontractual> Ramo_RcExtracontractual { get; set; }
        public virtual DbSet<Ramo_AsistenciaMedica> Ramo_AsistenciaMedica { get; set; }
        public virtual DbSet<Ramo_Transporte> Ramo_Transporte { get; set; }
        public virtual DbSet<Ramo_RcProfesional> Ramo_RcProfesional { get; set; }
        public virtual DbSet<Ramo_Fola> Ramo_Fola { get; set; }
        public virtual DbSet<Ramo_Viajero> Ramo_Viajero { get; set; }
        public virtual DbSet<Ramo_RoboAsalto> Ramo_RoboAsalto { get; set; }
        public virtual DbSet<Ramo_Flotante> Ramo_Flotante { get; set; }
        public virtual DbSet<Ramo_Deshonestidad> Ramo_Deshonestidad { get; set; }
        public virtual DbSet<Ramo_AccidentesPersonales> Ramo_AccidentesPersonales { get; set; }
        public virtual DbSet<Ramo_Hogar> Ramo_Hogar { get; set; }

        public virtual DbSet<Ramo_Dubai> Ramo_Dubai { get; set; }

        //TEMPORALES POLIZA-------------------
        public virtual DbSet<Ramo_AutoTemp> Ramo_AutoTemp { get; set; }
        public virtual DbSet<Ramo_SoatTemp> Ramo_SoatTemp { get; set; }
        public virtual DbSet<Ramo_TrecTemp> Ramo_TrecTemp { get; set; }
        public virtual DbSet<Ramo_EpsTemp> Ramo_EpsTemp { get; set; }
        public virtual DbSet<Ramo_IncendioTemp> Ramo_IncendioTemp { get; set; }
        public virtual DbSet<Ramo_RcMaquinariaTemp> Ramo_RcMaquinariaTemp { get; set; }
        public virtual DbSet<Ramo_RcMaptelTemp> Ramo_RcMaptelTemp { get; set; }
        public virtual DbSet<Ramo_RcVehicularTemp> Ramo_RcVehicularTemp { get; set; }
        public virtual DbSet<Ramo_RcExtracontractualTemp> Ramo_RcExtracontractualTemp { get; set; }
        public virtual DbSet<Ramo_AsistenciaMedicaTemp> Ramo_AsistenciaMedicaTemp { get; set; }
        public virtual DbSet<Ramo_TransporteTemp> Ramo_TransporteTemp { get; set; }
        public virtual DbSet<Ramo_RcProfesionalTemp> Ramo_RcProfesionalTemp { get; set; }
        public virtual DbSet<Ramo_FolaTemp> Ramo_FolaTemp { get; set; }
        public virtual DbSet<Ramo_ViajeroTemp> Ramo_ViajeroTemp { get; set; }
        public virtual DbSet<Ramo_RoboAsaltoTemp> Ramo_RoboAsaltoTemp { get; set; }
        public virtual DbSet<Ramo_FlotanteTemp> Ramo_FlotanteTemp { get; set; }
        public virtual DbSet<Ramo_DeshonestidadTemp> Ramo_DeshonestidadTemp { get; set; }
        public virtual DbSet<Ramo_AccidentesPersonalesTemp> Ramo_AccidentesPersonalesTemp { get; set; }
        public virtual DbSet<Ramo_HogarTemp> Ramo_HogarTemp { get; set; }

        public virtual DbSet<Ramo_DubaiTemp> Ramo_DubaiTemp { get; set; }



        public virtual DbSet<Seguro_CrecerTemp> Seguro_CrecerTemp { get; set; }
        public virtual DbSet<Seguro_LaPositivaTemp> Seguro_LaPositivaTemp { get; set; }
        public virtual DbSet<Seguro_PacificoEpsTemp> Seguro_PacificoEpsTemp { get; set; }
        public virtual DbSet<PacificoEpsDetalle> PacificoEpsDetalle { get; set; }


        public virtual DbSet<Seguro_LaPositivaMineraTemp> Seguro_LaPositivaMineraTemp { get; set; }
        public virtual DbSet<Seguro_MapfreTemp> Seguro_MapfreTemp { get; set; }
        public virtual DbSet<Seguro_PacificoTemp> Seguro_PacificoTemp { get; set; }
        public virtual DbSet<Seguro_Pacifico2Temp> Seguro_Pacifico2Temp { get; set; }
        public virtual DbSet<Seguro_RimacTemp> Seguro_RimacTemp { get; set; }
        public virtual DbSet<Seguro_SanitasTemp> Seguro_SanitasTemp { get; set; }
        public virtual DbSet<Seguro_ProtectaTemp> Seguro_ProtectaTemp { get; set; }
        public virtual DbSet<SeguroVida_ChubbTemp> SeguroVida_ChubbTemp { get; set; }
        public virtual DbSet<SeguroVida_CrecerTemp> SeguroVida_CrecerTemp { get; set; }

        public virtual DbSet<SeguroVida_LaPositivaTemp> SeguroVida_LaPositivaTemp { get; set; }
        public virtual DbSet<SeguroVida_MapfreTemp> SeguroVida_MapfreTemp { get; set; }
        public virtual DbSet<SeguroVida_PacificoTemp> SeguroVida_PacificoTemp { get; set; }
        public virtual DbSet<SeguroVida_ProtectaTemp> SeguroVida_ProtectaTemp { get; set; }

        public virtual DbSet<SeguroVida_PositivaAdelantadoTemp> SeguroVida_PositivaAdelantadoTemp { get; set; }
        public virtual DbSet<SeguroVida_RimacTemp> SeguroVida_RimacTemp { get; set; }

        public virtual DbSet<SeguroVida_RimacOriginalTemp> SeguroVida_RimacOriginalTemp { get; set; }

        public virtual DbSet<Seguro_RimacOriginalTemp> Seguro_RimacOriginalTemp { get; set; }

        //SCTR-------------------------
        public virtual DbSet<SeguroResumen> SeguroResumen { get; set; }

        public virtual DbSet<SeguroDetalle> SeguroDetalle { get; set; }
        public virtual DbSet<VidaChubbDetalle> VidaChubbDetalle { get; set; }
        public virtual DbSet<CrecerDetalle> CrecerDetalle { get; set; }
        public virtual DbSet<LaPositivaDetalle> LaPositivaDetalle { get; set; }

        public virtual DbSet<LaPositivaMineraDetalle> LaPositivaMineraDetalle { get; set; }
        public virtual DbSet<MapfreDetalle> MapfreDetalle { get; set; }
        public virtual DbSet<PacificoDetalle> PacificoDetalle { get; set; }
        public virtual DbSet<Pacifico2Detalle> Pacifico2Detalle { get; set; }
        public virtual DbSet<RimacDetalle> RimacDetalle { get; set; }
        public virtual DbSet<SolicitudCliente> SolicitudCliente { get; set; }
        public virtual DbSet<RimacOriginalDetalle> RimacOriginalDetalle { get; set; }
        public virtual DbSet<SanitasDetalle> SanitasDetalle { get; set; }
        public virtual DbSet<ProtectaDetalle> ProtectaDetalle { get; set; }
        public virtual DbSet<VidaCrecerDetalle> VidaCrecerDetalle { get; set; }
        public virtual DbSet<VidaLaPositivaDetalle> VidaLaPositivaDetalle { get; set; }
        public virtual DbSet<VidaMapfreDetalle> VidaMapfreDetalle { get; set; }
        public virtual DbSet<VidaPacificoDetalle> VidaPacificoDetalle { get; set; }
        public virtual DbSet<VidaProtectaDetalle> VidaProtectaDetalle { get; set; }
        public virtual DbSet<VidaPositivaAdelantadoDetalle> VidaPositivaAdelantadoDetalle { get; set; }
        public virtual DbSet<VidaRimacDetalle> VidaRimacDetalle { get; set; }

        public virtual DbSet<VidaRimacOriginalDetalle> VidaRimacOriginalDetalle { get; set; }

        public virtual DbSet<Historial_CartaNombramiento> Historial_CartaNombramiento { get; set; }

        public virtual DbSet<EstadoPuntuacion> EstadoPuntuacion { get; set; }

        public virtual DbSet<Extorno> Extorno { get; set; }
        public virtual DbSet<PersonalCompaniaSeguro> PersonalCompaniaSeguro { get; set; }

        //-----------------

        public virtual DbSet<Reporte> Reporte { get; set; }

        public virtual DbSet<FirmaElectronica> FirmaElectronica { get; set; }
        public virtual DbSet<ConfiguracionCorreosAutomatizados> ConfiguracionCorreosAutomatizados { get; set; }
        public virtual DbSet<LogCorreosAutomatizados> LogCorreosAutomatizados { get; set; }
        public virtual DbSet<HistorialMensaje> HistorialMensaje { get; set; }

        public virtual DbSet<ClienteXProveedor> ClienteXProveedor { get; set; }

        public virtual DbSet<HistorialClienteXAgente> HistorialClienteXAgente { get; set; }


        public virtual DbSet<HistorialClienteXProveedor> HistorialClienteXProveedor { get; set; }

        public virtual DbSet<ClienteXAgente> ClienteXAgente { get; set; }

        public ApplicationDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }



        //------------END MIGUEL


    }
}
