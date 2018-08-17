﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EmpresaPK2Entities : DbContext
    {
        public EmpresaPK2Entities()
            : base("name=EmpresaPK2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TBL_CANTON> TBL_CANTON { get; set; }
        public DbSet<TBL_MODTARIFARIOVIATICO> TBL_MODTARIFARIOVIATICO { get; set; }
        public DbSet<TBL_PROVINCIA> TBL_PROVINCIA { get; set; }
        public DbSet<TBL_TARIFAAUTOBUS> TBL_TARIFAAUTOBUS { get; set; }
        public DbSet<TBL_ESTADOS> TBL_ESTADOS { get; set; }
        public DbSet<TBL_PERSONA> TBL_PERSONA { get; set; }
        public DbSet<TBL_ROLUSUARIO> TBL_ROLUSUARIO { get; set; }
        public DbSet<TBL_USUARIO> TBL_USUARIO { get; set; }
        public DbSet<TBL_CABECERALIQUIDACION> TBL_CABECERALIQUIDACION { get; set; }
        public DbSet<TBL_CABECERAORDENVIATICO> TBL_CABECERAORDENVIATICO { get; set; }
        public DbSet<TBL_DETALLESOLICITUDVIATICOS> TBL_DETALLESOLICITUDVIATICOS { get; set; }
        public DbSet<TBL_SOLICITUDVIATICOS> TBL_SOLICITUDVIATICOS { get; set; }
    
        public virtual int SP_InsertarUsuario(string nOMBREUSUARIO, string cLAVEACCESO, Nullable<short> iD_Rol, Nullable<short> estadoUsuario, string email)
        {
            var nOMBREUSUARIOParameter = nOMBREUSUARIO != null ?
                new ObjectParameter("NOMBREUSUARIO", nOMBREUSUARIO) :
                new ObjectParameter("NOMBREUSUARIO", typeof(string));
    
            var cLAVEACCESOParameter = cLAVEACCESO != null ?
                new ObjectParameter("CLAVEACCESO", cLAVEACCESO) :
                new ObjectParameter("CLAVEACCESO", typeof(string));
    
            var iD_RolParameter = iD_Rol.HasValue ?
                new ObjectParameter("ID_Rol", iD_Rol) :
                new ObjectParameter("ID_Rol", typeof(short));
    
            var estadoUsuarioParameter = estadoUsuario.HasValue ?
                new ObjectParameter("EstadoUsuario", estadoUsuario) :
                new ObjectParameter("EstadoUsuario", typeof(short));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertarUsuario", nOMBREUSUARIOParameter, cLAVEACCESOParameter, iD_RolParameter, estadoUsuarioParameter, emailParameter);
        }
    
        public virtual int SP_ACTUALIZAR_SOLICITUDES_FUNCIONARIO(Nullable<int> iDSOLICITUD, string nOMBREUSUARIO, Nullable<System.DateTime> fECHASALIDA, Nullable<System.DateTime> fECHAREGRESO, Nullable<short> eSTADOSOLICITUD, string jUSTIFICACION, string dESTINO, Nullable<System.TimeSpan> hORAREGRESO, Nullable<System.TimeSpan> hORASALIDA)
        {
            var iDSOLICITUDParameter = iDSOLICITUD.HasValue ?
                new ObjectParameter("IDSOLICITUD", iDSOLICITUD) :
                new ObjectParameter("IDSOLICITUD", typeof(int));
    
            var nOMBREUSUARIOParameter = nOMBREUSUARIO != null ?
                new ObjectParameter("NOMBREUSUARIO", nOMBREUSUARIO) :
                new ObjectParameter("NOMBREUSUARIO", typeof(string));
    
            var fECHASALIDAParameter = fECHASALIDA.HasValue ?
                new ObjectParameter("FECHASALIDA", fECHASALIDA) :
                new ObjectParameter("FECHASALIDA", typeof(System.DateTime));
    
            var fECHAREGRESOParameter = fECHAREGRESO.HasValue ?
                new ObjectParameter("FECHAREGRESO", fECHAREGRESO) :
                new ObjectParameter("FECHAREGRESO", typeof(System.DateTime));
    
            var eSTADOSOLICITUDParameter = eSTADOSOLICITUD.HasValue ?
                new ObjectParameter("ESTADOSOLICITUD", eSTADOSOLICITUD) :
                new ObjectParameter("ESTADOSOLICITUD", typeof(short));
    
            var jUSTIFICACIONParameter = jUSTIFICACION != null ?
                new ObjectParameter("JUSTIFICACION", jUSTIFICACION) :
                new ObjectParameter("JUSTIFICACION", typeof(string));
    
            var dESTINOParameter = dESTINO != null ?
                new ObjectParameter("DESTINO", dESTINO) :
                new ObjectParameter("DESTINO", typeof(string));
    
            var hORAREGRESOParameter = hORAREGRESO.HasValue ?
                new ObjectParameter("HORAREGRESO", hORAREGRESO) :
                new ObjectParameter("HORAREGRESO", typeof(System.TimeSpan));
    
            var hORASALIDAParameter = hORASALIDA.HasValue ?
                new ObjectParameter("HORASALIDA", hORASALIDA) :
                new ObjectParameter("HORASALIDA", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ACTUALIZAR_SOLICITUDES_FUNCIONARIO", iDSOLICITUDParameter, nOMBREUSUARIOParameter, fECHASALIDAParameter, fECHAREGRESOParameter, eSTADOSOLICITUDParameter, jUSTIFICACIONParameter, dESTINOParameter, hORAREGRESOParameter, hORASALIDAParameter);
        }
    
        public virtual int SP_ELIMINAR_SOLICITUDES(Nullable<int> iDSOLICITUD)
        {
            var iDSOLICITUDParameter = iDSOLICITUD.HasValue ?
                new ObjectParameter("IDSOLICITUD", iDSOLICITUD) :
                new ObjectParameter("IDSOLICITUD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_SOLICITUDES", iDSOLICITUDParameter);
        }
    
        public virtual ObjectResult<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> SP_LISTAR_SOLICITUDES_FUNCIONARIO(string uSUARIO)
        {
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result>("SP_LISTAR_SOLICITUDES_FUNCIONARIO", uSUARIOParameter);
        }
    
        public virtual ObjectResult<SP_LISTADO_SOLICITUD_VIATICOS_Result> SP_LISTADO_SOLICITUD_VIATICOS(Nullable<System.DateTime> fECHAINICIO, Nullable<System.DateTime> fECHAFINAL, string iD_PERSONA, Nullable<short> eSTADOS_SOLICITUD)
        {
            var fECHAINICIOParameter = fECHAINICIO.HasValue ?
                new ObjectParameter("FECHAINICIO", fECHAINICIO) :
                new ObjectParameter("FECHAINICIO", typeof(System.DateTime));
    
            var fECHAFINALParameter = fECHAFINAL.HasValue ?
                new ObjectParameter("FECHAFINAL", fECHAFINAL) :
                new ObjectParameter("FECHAFINAL", typeof(System.DateTime));
    
            var iD_PERSONAParameter = iD_PERSONA != null ?
                new ObjectParameter("ID_PERSONA", iD_PERSONA) :
                new ObjectParameter("ID_PERSONA", typeof(string));
    
            var eSTADOS_SOLICITUDParameter = eSTADOS_SOLICITUD.HasValue ?
                new ObjectParameter("ESTADOS_SOLICITUD", eSTADOS_SOLICITUD) :
                new ObjectParameter("ESTADOS_SOLICITUD", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTADO_SOLICITUD_VIATICOS_Result>("SP_LISTADO_SOLICITUD_VIATICOS", fECHAINICIOParameter, fECHAFINALParameter, iD_PERSONAParameter, eSTADOS_SOLICITUDParameter);
        }
    
        public virtual ObjectResult<SP_INICIO_SESION_Result> SP_INICIO_SESION(string nombreUsuario, string claveAcceso)
        {
            var nombreUsuarioParameter = nombreUsuario != null ?
                new ObjectParameter("NombreUsuario", nombreUsuario) :
                new ObjectParameter("NombreUsuario", typeof(string));
    
            var claveAccesoParameter = claveAcceso != null ?
                new ObjectParameter("ClaveAcceso", claveAcceso) :
                new ObjectParameter("ClaveAcceso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_INICIO_SESION_Result>("SP_INICIO_SESION", nombreUsuarioParameter, claveAccesoParameter);
        }
    
        public virtual ObjectResult<SP_LISTADO_LIQUIDACION_VIATICOS_Result> SP_LISTADO_LIQUIDACION_VIATICOS(Nullable<System.DateTime> fECHAINICIO, Nullable<System.DateTime> fECHAFINAL, string nOMBREUSUARIO, Nullable<short> eSTADOS_SOLICITUD)
        {
            var fECHAINICIOParameter = fECHAINICIO.HasValue ?
                new ObjectParameter("FECHAINICIO", fECHAINICIO) :
                new ObjectParameter("FECHAINICIO", typeof(System.DateTime));
    
            var fECHAFINALParameter = fECHAFINAL.HasValue ?
                new ObjectParameter("FECHAFINAL", fECHAFINAL) :
                new ObjectParameter("FECHAFINAL", typeof(System.DateTime));
    
            var nOMBREUSUARIOParameter = nOMBREUSUARIO != null ?
                new ObjectParameter("NOMBREUSUARIO", nOMBREUSUARIO) :
                new ObjectParameter("NOMBREUSUARIO", typeof(string));
    
            var eSTADOS_SOLICITUDParameter = eSTADOS_SOLICITUD.HasValue ?
                new ObjectParameter("ESTADOS_SOLICITUD", eSTADOS_SOLICITUD) :
                new ObjectParameter("ESTADOS_SOLICITUD", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTADO_LIQUIDACION_VIATICOS_Result>("SP_LISTADO_LIQUIDACION_VIATICOS", fECHAINICIOParameter, fECHAFINALParameter, nOMBREUSUARIOParameter, eSTADOS_SOLICITUDParameter);
        }
    
        public virtual ObjectResult<SP_LISTADO_ORDEN_VIATICOS_Result> SP_LISTADO_ORDEN_VIATICOS(Nullable<System.DateTime> fECHAINICIO, Nullable<System.DateTime> fECHAFINAL, string nOMBREUSUARIO, Nullable<short> eSTADOS_SOLICITUD)
        {
            var fECHAINICIOParameter = fECHAINICIO.HasValue ?
                new ObjectParameter("FECHAINICIO", fECHAINICIO) :
                new ObjectParameter("FECHAINICIO", typeof(System.DateTime));
    
            var fECHAFINALParameter = fECHAFINAL.HasValue ?
                new ObjectParameter("FECHAFINAL", fECHAFINAL) :
                new ObjectParameter("FECHAFINAL", typeof(System.DateTime));
    
            var nOMBREUSUARIOParameter = nOMBREUSUARIO != null ?
                new ObjectParameter("NOMBREUSUARIO", nOMBREUSUARIO) :
                new ObjectParameter("NOMBREUSUARIO", typeof(string));
    
            var eSTADOS_SOLICITUDParameter = eSTADOS_SOLICITUD.HasValue ?
                new ObjectParameter("ESTADOS_SOLICITUD", eSTADOS_SOLICITUD) :
                new ObjectParameter("ESTADOS_SOLICITUD", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTADO_ORDEN_VIATICOS_Result>("SP_LISTADO_ORDEN_VIATICOS", fECHAINICIOParameter, fECHAFINALParameter, nOMBREUSUARIOParameter, eSTADOS_SOLICITUDParameter);
        }
    
        public virtual ObjectResult<SP_LISTAR_LOCALIDAD_Result> SP_LISTAR_LOCALIDAD()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTAR_LOCALIDAD_Result>("SP_LISTAR_LOCALIDAD");
        }
    
        public virtual ObjectResult<SP_LISTAR_RUTAS_Result> SP_LISTAR_RUTAS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTAR_RUTAS_Result>("SP_LISTAR_RUTAS");
        }
    
        public virtual int SP_GUARDAR_DETALLEVIATICOS(string iD_SOLICITUD, string iD_PERSONA, Nullable<short> cANTIDADVIATICOS, Nullable<short> cANTIDADDESAYUNOS, Nullable<short> cANTIDADALMUERZOS, Nullable<short> cANTIDADCENAS, Nullable<short> cANTIDADPASAJE, Nullable<decimal> mONTODESAYUNO, Nullable<decimal> mONTOALMUERZO, Nullable<decimal> mONTOCENA, Nullable<decimal> mONTOPASAJE, Nullable<decimal> mONTOHOSPEDAJE, string cODIGORUTA, Nullable<short> lOCALIDADHOSPEDAJE)
        {
            var iD_SOLICITUDParameter = iD_SOLICITUD != null ?
                new ObjectParameter("ID_SOLICITUD", iD_SOLICITUD) :
                new ObjectParameter("ID_SOLICITUD", typeof(string));
    
            var iD_PERSONAParameter = iD_PERSONA != null ?
                new ObjectParameter("ID_PERSONA", iD_PERSONA) :
                new ObjectParameter("ID_PERSONA", typeof(string));
    
            var cANTIDADVIATICOSParameter = cANTIDADVIATICOS.HasValue ?
                new ObjectParameter("CANTIDADVIATICOS", cANTIDADVIATICOS) :
                new ObjectParameter("CANTIDADVIATICOS", typeof(short));
    
            var cANTIDADDESAYUNOSParameter = cANTIDADDESAYUNOS.HasValue ?
                new ObjectParameter("CANTIDADDESAYUNOS", cANTIDADDESAYUNOS) :
                new ObjectParameter("CANTIDADDESAYUNOS", typeof(short));
    
            var cANTIDADALMUERZOSParameter = cANTIDADALMUERZOS.HasValue ?
                new ObjectParameter("CANTIDADALMUERZOS", cANTIDADALMUERZOS) :
                new ObjectParameter("CANTIDADALMUERZOS", typeof(short));
    
            var cANTIDADCENASParameter = cANTIDADCENAS.HasValue ?
                new ObjectParameter("CANTIDADCENAS", cANTIDADCENAS) :
                new ObjectParameter("CANTIDADCENAS", typeof(short));
    
            var cANTIDADPASAJEParameter = cANTIDADPASAJE.HasValue ?
                new ObjectParameter("CANTIDADPASAJE", cANTIDADPASAJE) :
                new ObjectParameter("CANTIDADPASAJE", typeof(short));
    
            var mONTODESAYUNOParameter = mONTODESAYUNO.HasValue ?
                new ObjectParameter("MONTODESAYUNO", mONTODESAYUNO) :
                new ObjectParameter("MONTODESAYUNO", typeof(decimal));
    
            var mONTOALMUERZOParameter = mONTOALMUERZO.HasValue ?
                new ObjectParameter("MONTOALMUERZO", mONTOALMUERZO) :
                new ObjectParameter("MONTOALMUERZO", typeof(decimal));
    
            var mONTOCENAParameter = mONTOCENA.HasValue ?
                new ObjectParameter("MONTOCENA", mONTOCENA) :
                new ObjectParameter("MONTOCENA", typeof(decimal));
    
            var mONTOPASAJEParameter = mONTOPASAJE.HasValue ?
                new ObjectParameter("MONTOPASAJE", mONTOPASAJE) :
                new ObjectParameter("MONTOPASAJE", typeof(decimal));
    
            var mONTOHOSPEDAJEParameter = mONTOHOSPEDAJE.HasValue ?
                new ObjectParameter("MONTOHOSPEDAJE", mONTOHOSPEDAJE) :
                new ObjectParameter("MONTOHOSPEDAJE", typeof(decimal));
    
            var cODIGORUTAParameter = cODIGORUTA != null ?
                new ObjectParameter("CODIGORUTA", cODIGORUTA) :
                new ObjectParameter("CODIGORUTA", typeof(string));
    
            var lOCALIDADHOSPEDAJEParameter = lOCALIDADHOSPEDAJE.HasValue ?
                new ObjectParameter("LOCALIDADHOSPEDAJE", lOCALIDADHOSPEDAJE) :
                new ObjectParameter("LOCALIDADHOSPEDAJE", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_GUARDAR_DETALLEVIATICOS", iD_SOLICITUDParameter, iD_PERSONAParameter, cANTIDADVIATICOSParameter, cANTIDADDESAYUNOSParameter, cANTIDADALMUERZOSParameter, cANTIDADCENASParameter, cANTIDADPASAJEParameter, mONTODESAYUNOParameter, mONTOALMUERZOParameter, mONTOCENAParameter, mONTOPASAJEParameter, mONTOHOSPEDAJEParameter, cODIGORUTAParameter, lOCALIDADHOSPEDAJEParameter);
        }
    
        public virtual ObjectResult<SP_LISTAR_SOLICITUDES_ACTUALIZAR_Result> SP_LISTAR_SOLICITUDES_ACTUALIZAR(string nOMBREUSUARIO)
        {
            var nOMBREUSUARIOParameter = nOMBREUSUARIO != null ?
                new ObjectParameter("NOMBREUSUARIO", nOMBREUSUARIO) :
                new ObjectParameter("NOMBREUSUARIO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTAR_SOLICITUDES_ACTUALIZAR_Result>("SP_LISTAR_SOLICITUDES_ACTUALIZAR", nOMBREUSUARIOParameter);
        }
    
        public virtual ObjectResult<SP_LISTAR_PERSONAS_Result> SP_LISTAR_PERSONAS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTAR_PERSONAS_Result>("SP_LISTAR_PERSONAS");
        }
    
        public virtual ObjectResult<SP_OBTENER_ORDEN_VIATICOS_Result> SP_OBTENER_ORDEN_VIATICOS(string nOMBREUSUARIO)
        {
            var nOMBREUSUARIOParameter = nOMBREUSUARIO != null ?
                new ObjectParameter("NOMBREUSUARIO", nOMBREUSUARIO) :
                new ObjectParameter("NOMBREUSUARIO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_ORDEN_VIATICOS_Result>("SP_OBTENER_ORDEN_VIATICOS", nOMBREUSUARIOParameter);
        }
    
        public virtual ObjectResult<SP_LISTARMONTORUTA_Result> SP_LISTARMONTORUTA(string iDRUTA)
        {
            var iDRUTAParameter = iDRUTA != null ?
                new ObjectParameter("IDRUTA", iDRUTA) :
                new ObjectParameter("IDRUTA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTARMONTORUTA_Result>("SP_LISTARMONTORUTA", iDRUTAParameter);
        }
    
        public virtual ObjectResult<SP_LISTARMONTOS_Result> SP_LISTARMONTOS(Nullable<int> iDHOSPEDAJE)
        {
            var iDHOSPEDAJEParameter = iDHOSPEDAJE.HasValue ?
                new ObjectParameter("IDHOSPEDAJE", iDHOSPEDAJE) :
                new ObjectParameter("IDHOSPEDAJE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTARMONTOS_Result>("SP_LISTARMONTOS", iDHOSPEDAJEParameter);
        }
    
        public virtual ObjectResult<string> SP_GUARDAR_SOLICITUDES_FUNCIONARIO(string nOMBREUSUARIO, Nullable<System.DateTime> fECHACREACION, Nullable<System.DateTime> fECHASALIDA, Nullable<System.DateTime> fECHAREGRESO, string jUSTIFICACION, string dESTINO, Nullable<System.TimeSpan> hORAREGRESO, Nullable<System.TimeSpan> hORASALIDA)
        {
            var nOMBREUSUARIOParameter = nOMBREUSUARIO != null ?
                new ObjectParameter("NOMBREUSUARIO", nOMBREUSUARIO) :
                new ObjectParameter("NOMBREUSUARIO", typeof(string));
    
            var fECHACREACIONParameter = fECHACREACION.HasValue ?
                new ObjectParameter("FECHACREACION", fECHACREACION) :
                new ObjectParameter("FECHACREACION", typeof(System.DateTime));
    
            var fECHASALIDAParameter = fECHASALIDA.HasValue ?
                new ObjectParameter("FECHASALIDA", fECHASALIDA) :
                new ObjectParameter("FECHASALIDA", typeof(System.DateTime));
    
            var fECHAREGRESOParameter = fECHAREGRESO.HasValue ?
                new ObjectParameter("FECHAREGRESO", fECHAREGRESO) :
                new ObjectParameter("FECHAREGRESO", typeof(System.DateTime));
    
            var jUSTIFICACIONParameter = jUSTIFICACION != null ?
                new ObjectParameter("JUSTIFICACION", jUSTIFICACION) :
                new ObjectParameter("JUSTIFICACION", typeof(string));
    
            var dESTINOParameter = dESTINO != null ?
                new ObjectParameter("DESTINO", dESTINO) :
                new ObjectParameter("DESTINO", typeof(string));
    
            var hORAREGRESOParameter = hORAREGRESO.HasValue ?
                new ObjectParameter("HORAREGRESO", hORAREGRESO) :
                new ObjectParameter("HORAREGRESO", typeof(System.TimeSpan));
    
            var hORASALIDAParameter = hORASALIDA.HasValue ?
                new ObjectParameter("HORASALIDA", hORASALIDA) :
                new ObjectParameter("HORASALIDA", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_GUARDAR_SOLICITUDES_FUNCIONARIO", nOMBREUSUARIOParameter, fECHACREACIONParameter, fECHASALIDAParameter, fECHAREGRESOParameter, jUSTIFICACIONParameter, dESTINOParameter, hORAREGRESOParameter, hORASALIDAParameter);
        }
    
        public virtual ObjectResult<SP_OBTENER_ESTADOS_ACTIVOS_Result> SP_OBTENER_ESTADOS_ACTIVOS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_ESTADOS_ACTIVOS_Result>("SP_OBTENER_ESTADOS_ACTIVOS");
        }
    
        public virtual int SP_ACTUALIZAR_MODTARIFAVIATICO(Nullable<short> iD_MODTARIFA, Nullable<System.DateTime> fECHATARIFA, Nullable<decimal> mONTOTARIFA, Nullable<short> eSTADOTARIFA)
        {
            var iD_MODTARIFAParameter = iD_MODTARIFA.HasValue ?
                new ObjectParameter("ID_MODTARIFA", iD_MODTARIFA) :
                new ObjectParameter("ID_MODTARIFA", typeof(short));
    
            var fECHATARIFAParameter = fECHATARIFA.HasValue ?
                new ObjectParameter("FECHATARIFA", fECHATARIFA) :
                new ObjectParameter("FECHATARIFA", typeof(System.DateTime));
    
            var mONTOTARIFAParameter = mONTOTARIFA.HasValue ?
                new ObjectParameter("MONTOTARIFA", mONTOTARIFA) :
                new ObjectParameter("MONTOTARIFA", typeof(decimal));
    
            var eSTADOTARIFAParameter = eSTADOTARIFA.HasValue ?
                new ObjectParameter("ESTADOTARIFA", eSTADOTARIFA) :
                new ObjectParameter("ESTADOTARIFA", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ACTUALIZAR_MODTARIFAVIATICO", iD_MODTARIFAParameter, fECHATARIFAParameter, mONTOTARIFAParameter, eSTADOTARIFAParameter);
        }
    
        public virtual ObjectResult<SP_LISTAR_MODTARIFAVIATICO_Result> SP_LISTAR_MODTARIFAVIATICO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LISTAR_MODTARIFAVIATICO_Result>("SP_LISTAR_MODTARIFAVIATICO");
        }
    
        public virtual ObjectResult<SP_OBTENER_CANTON_PROVINCIA_Result> SP_OBTENER_CANTON_PROVINCIA(Nullable<int> cODIGOCANTON, Nullable<int> cODIGOPROVINCIA)
        {
            var cODIGOCANTONParameter = cODIGOCANTON.HasValue ?
                new ObjectParameter("CODIGOCANTON", cODIGOCANTON) :
                new ObjectParameter("CODIGOCANTON", typeof(int));
    
            var cODIGOPROVINCIAParameter = cODIGOPROVINCIA.HasValue ?
                new ObjectParameter("CODIGOPROVINCIA", cODIGOPROVINCIA) :
                new ObjectParameter("CODIGOPROVINCIA", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_OBTENER_CANTON_PROVINCIA_Result>("SP_OBTENER_CANTON_PROVINCIA", cODIGOCANTONParameter, cODIGOPROVINCIAParameter);
        }
    
        public virtual int SP_GENERAR_ORDEN_VIATICOS(string iDSOLICITUD, Nullable<System.DateTime> fECHAORDEN, Nullable<short> eSTADOORDEN)
        {
            var iDSOLICITUDParameter = iDSOLICITUD != null ?
                new ObjectParameter("IDSOLICITUD", iDSOLICITUD) :
                new ObjectParameter("IDSOLICITUD", typeof(string));
    
            var fECHAORDENParameter = fECHAORDEN.HasValue ?
                new ObjectParameter("FECHAORDEN", fECHAORDEN) :
                new ObjectParameter("FECHAORDEN", typeof(System.DateTime));
    
            var eSTADOORDENParameter = eSTADOORDEN.HasValue ?
                new ObjectParameter("ESTADOORDEN", eSTADOORDEN) :
                new ObjectParameter("ESTADOORDEN", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_GENERAR_ORDEN_VIATICOS", iDSOLICITUDParameter, fECHAORDENParameter, eSTADOORDENParameter);
        }
    }
}
