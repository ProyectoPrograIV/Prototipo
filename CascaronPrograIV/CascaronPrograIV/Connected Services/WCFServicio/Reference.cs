﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CascaronPrograIV.WCFServicio
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "WCFServicio.IService1")]
    public interface IService1
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/InsertarRol", ReplyAction = "http://tempuri.org/IService1/InsertarRolResponse")]
        void InsertarRol(Entidades.TBL_ROLUSUARIO obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/InsertarRol", ReplyAction = "http://tempuri.org/IService1/InsertarRolResponse")]
        System.Threading.Tasks.Task InsertarRolAsync(Entidades.TBL_ROLUSUARIO obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/InsertarPersona", ReplyAction = "http://tempuri.org/IService1/InsertarPersonaResponse")]
        void InsertarPersona(Entidades.TBL_PERSONA obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/InsertarPersona", ReplyAction = "http://tempuri.org/IService1/InsertarPersonaResponse")]
        System.Threading.Tasks.Task InsertarPersonaAsync(Entidades.TBL_PERSONA obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/InsertarUsuario", ReplyAction = "http://tempuri.org/IService1/InsertarUsuarioResponse")]
        void InsertarUsuario(Entidades.TBL_USUARIO obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/InsertarUsuario", ReplyAction = "http://tempuri.org/IService1/InsertarUsuarioResponse")]
        System.Threading.Tasks.Task InsertarUsuarioAsync(Entidades.TBL_USUARIO obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/InicioSesion", ReplyAction = "http://tempuri.org/IService1/InicioSesionResponse")]
        Entidades.SP_INICIO_SESION_Result InicioSesion(Entidades.TBL_USUARIO obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/InicioSesion", ReplyAction = "http://tempuri.org/IService1/InicioSesionResponse")]
        System.Threading.Tasks.Task<Entidades.SP_INICIO_SESION_Result> InicioSesionAsync(Entidades.TBL_USUARIO obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerListaLiquidacion", ReplyAction = "http://tempuri.org/IService1/ObtenerListaLiquidacionResponse")]
        System.Collections.Generic.List<Entidades.SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(Entidades.ReporteXFecha obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerListaLiquidacion", ReplyAction = "http://tempuri.org/IService1/ObtenerListaLiquidacionResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_LIQUIDACION_VIATICOS_Result>> ObtenerListaLiquidacionAsync(Entidades.ReporteXFecha obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerListaOrden", ReplyAction = "http://tempuri.org/IService1/ObtenerListaOrdenResponse")]
        System.Collections.Generic.List<Entidades.SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(Entidades.ReporteXFecha obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerListaOrden", ReplyAction = "http://tempuri.org/IService1/ObtenerListaOrdenResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_ORDEN_VIATICOS_Result>> ObtenerListaOrdenAsync(Entidades.ReporteXFecha obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerListaSolicitud", ReplyAction = "http://tempuri.org/IService1/ObtenerListaSolicitudResponse")]
        System.Collections.Generic.List<Entidades.SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(Entidades.ReporteXFecha obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerListaSolicitud", ReplyAction = "http://tempuri.org/IService1/ObtenerListaSolicitudResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_SOLICITUD_VIATICOS_Result>> ObtenerListaSolicitudAsync(Entidades.ReporteXFecha obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GenerarOrdenViaticos", ReplyAction = "http://tempuri.org/IService1/GenerarOrdenViaticosResponse")]
        int GenerarOrdenViaticos(Entidades.TBL_CABECERAORDENVIATICO orden, Entidades.TBL_SOLICITUDVIATICOS solicitud);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GenerarOrdenViaticos", ReplyAction = "http://tempuri.org/IService1/GenerarOrdenViaticosResponse")]
        System.Threading.Tasks.Task<int> GenerarOrdenViaticosAsync(Entidades.TBL_CABECERAORDENVIATICO orden, Entidades.TBL_SOLICITUDVIATICOS solicitud);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerOrden", ReplyAction = "http://tempuri.org/IService1/ObtenerOrdenResponse")]
        System.Collections.Generic.List<Entidades.SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(Entidades.OrdenDeViaticos obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerOrden", ReplyAction = "http://tempuri.org/IService1/ObtenerOrdenResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_OBTENER_ORDEN_VIATICOS_Result>> ObtenerOrdenAsync(Entidades.OrdenDeViaticos obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerRoles", ReplyAction = "http://tempuri.org/IService1/ObtenerRolesResponse")]
        System.Collections.Generic.List<Entidades.TBL_ROLUSUARIO> ObtenerRoles();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerRoles", ReplyAction = "http://tempuri.org/IService1/ObtenerRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_ROLUSUARIO>> ObtenerRolesAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerEstados", ReplyAction = "http://tempuri.org/IService1/ObtenerEstadosResponse")]
        System.Collections.Generic.List<Entidades.TBL_ESTADOS> ObtenerEstados();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerEstados", ReplyAction = "http://tempuri.org/IService1/ObtenerEstadosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_ESTADOS>> ObtenerEstadosAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerMODTARIFASVIATICOS", ReplyAction = "http://tempuri.org/IService1/ObtenerMODTARIFASVIATICOSResponse")]
        System.Collections.Generic.List<Entidades.SP_LISTAR_MODTARIFAVIATICO_Result> ObtenerMODTARIFASVIATICOS();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerMODTARIFASVIATICOS", ReplyAction = "http://tempuri.org/IService1/ObtenerMODTARIFASVIATICOSResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTAR_MODTARIFAVIATICO_Result>> ObtenerMODTARIFASVIATICOSAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ActualizarMODTARIFASVIATICOS", ReplyAction = "http://tempuri.org/IService1/ActualizarMODTARIFASVIATICOSResponse")]
        int ActualizarMODTARIFASVIATICOS(Entidades.SP_LISTAR_MODTARIFAVIATICO_Result obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ActualizarMODTARIFASVIATICOS", ReplyAction = "http://tempuri.org/IService1/ActualizarMODTARIFASVIATICOSResponse")]
        System.Threading.Tasks.Task<int> ActualizarMODTARIFASVIATICOSAsync(Entidades.SP_LISTAR_MODTARIFAVIATICO_Result obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerIDS_CANTON_PROVINCIA", ReplyAction = "http://tempuri.org/IService1/ObtenerIDS_CANTON_PROVINCIAResponse")]
        System.Collections.Generic.List<Entidades.SP_OBTENER_CANTON_PROVINCIA_Result> ObtenerIDS_CANTON_PROVINCIA(Entidades.IdCantonIdProvincia obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerIDS_CANTON_PROVINCIA", ReplyAction = "http://tempuri.org/IService1/ObtenerIDS_CANTON_PROVINCIAResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_OBTENER_CANTON_PROVINCIA_Result>> ObtenerIDS_CANTON_PROVINCIAAsync(Entidades.IdCantonIdProvincia obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerTARIFASAUTOBUSES", ReplyAction = "http://tempuri.org/IService1/ObtenerTARIFASAUTOBUSESResponse")]
        System.Collections.Generic.List<Entidades.SP_LISTAR_TARIFASAUTOBUSES_Result> ObtenerTARIFASAUTOBUSES();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerTARIFASAUTOBUSES", ReplyAction = "http://tempuri.org/IService1/ObtenerTARIFASAUTOBUSESResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTAR_TARIFASAUTOBUSES_Result>> ObtenerTARIFASAUTOBUSESAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/BuscarTarifaAutobusXId", ReplyAction = "http://tempuri.org/IService1/BuscarTarifaAutobusXIdResponse")]
        System.Collections.Generic.List<Entidades.SP_BUSCAR_TARIFAAUTOBUS_Result> BuscarTarifaAutobusXId(Entidades.TBL_TARIFAAUTOBUS obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/BuscarTarifaAutobusXId", ReplyAction = "http://tempuri.org/IService1/BuscarTarifaAutobusXIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_BUSCAR_TARIFAAUTOBUS_Result>> BuscarTarifaAutobusXIdAsync(Entidades.TBL_TARIFAAUTOBUS obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ActualizarTarifaAutobus", ReplyAction = "http://tempuri.org/IService1/ActualizarTarifaAutobusResponse")]
        int ActualizarTarifaAutobus(Entidades.TBL_TARIFAAUTOBUS obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ActualizarTarifaAutobus", ReplyAction = "http://tempuri.org/IService1/ActualizarTarifaAutobusResponse")]
        System.Threading.Tasks.Task<int> ActualizarTarifaAutobusAsync(Entidades.TBL_TARIFAAUTOBUS obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServicios/ListarOrdenes", ReplyAction = "http://tempuri.org/IServicios/ListarOrdenesResponse")]
        System.Collections.Generic.List<Entidades.TBL_CABECERAORDENVIATICO> ListarOrdenes();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServicios/ListarOrdenes", ReplyAction = "http://tempuri.org/IServicios/ListarOrdenesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_CABECERAORDENVIATICO>> ListarOrdenesAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServicios/ActualizarOrdenViatico", ReplyAction = "http://tempuri.org/IServicios/ActualizarOrdenViaticoResponse")]
        int ActualizarOrdenViatico(Entidades.TBL_CABECERAORDENVIATICO obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IServiciosActualizarOrdenViatico", ReplyAction = "http://tempuri.org/IServiciosActualizarOrdenViaticoResponse")]
        System.Threading.Tasks.Task<int> ActualizarOrdenViaticoAsync(Entidades.TBL_CABECERAORDENVIATICO obj);

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CascaronPrograIV.WCFServicio.IService1, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CascaronPrograIV.WCFServicio.IService1>, CascaronPrograIV.WCFServicio.IService1
    {

        public Service1Client()
        {
        }

        public Service1Client(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public Service1Client(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public void InsertarRol(Entidades.TBL_ROLUSUARIO obj)
        {
            base.Channel.InsertarRol(obj);
        }

        public System.Threading.Tasks.Task InsertarRolAsync(Entidades.TBL_ROLUSUARIO obj)
        {
            return base.Channel.InsertarRolAsync(obj);
        }

        public void InsertarPersona(Entidades.TBL_PERSONA obj)
        {
            base.Channel.InsertarPersona(obj);
        }

        public System.Threading.Tasks.Task InsertarPersonaAsync(Entidades.TBL_PERSONA obj)
        {
            return base.Channel.InsertarPersonaAsync(obj);
        }

        public void InsertarUsuario(Entidades.TBL_USUARIO obj)
        {
            base.Channel.InsertarUsuario(obj);
        }

        public System.Threading.Tasks.Task InsertarUsuarioAsync(Entidades.TBL_USUARIO obj)
        {
            return base.Channel.InsertarUsuarioAsync(obj);
        }

        public Entidades.SP_INICIO_SESION_Result InicioSesion(Entidades.TBL_USUARIO obj)
        {
            return base.Channel.InicioSesion(obj);
        }

        public System.Threading.Tasks.Task<Entidades.SP_INICIO_SESION_Result> InicioSesionAsync(Entidades.TBL_USUARIO obj)
        {
            return base.Channel.InicioSesionAsync(obj);
        }

        public System.Collections.Generic.List<Entidades.SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(Entidades.ReporteXFecha obj)
        {
            return base.Channel.ObtenerListaLiquidacion(obj);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_LIQUIDACION_VIATICOS_Result>> ObtenerListaLiquidacionAsync(Entidades.ReporteXFecha obj)
        {
            return base.Channel.ObtenerListaLiquidacionAsync(obj);
        }

        public System.Collections.Generic.List<Entidades.SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(Entidades.ReporteXFecha obj)
        {
            return base.Channel.ObtenerListaOrden(obj);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_ORDEN_VIATICOS_Result>> ObtenerListaOrdenAsync(Entidades.ReporteXFecha obj)
        {
            return base.Channel.ObtenerListaOrdenAsync(obj);
        }

        public System.Collections.Generic.List<Entidades.SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(Entidades.ReporteXFecha obj)
        {
            return base.Channel.ObtenerListaSolicitud(obj);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_SOLICITUD_VIATICOS_Result>> ObtenerListaSolicitudAsync(Entidades.ReporteXFecha obj)
        {
            return base.Channel.ObtenerListaSolicitudAsync(obj);
        }

        public int GenerarOrdenViaticos(Entidades.TBL_CABECERAORDENVIATICO orden, Entidades.TBL_SOLICITUDVIATICOS solicitud)
        {
            return base.Channel.GenerarOrdenViaticos(orden, solicitud);
        }

        public System.Threading.Tasks.Task<int> GenerarOrdenViaticosAsync(Entidades.TBL_CABECERAORDENVIATICO orden, Entidades.TBL_SOLICITUDVIATICOS solicitud)
        {
            return base.Channel.GenerarOrdenViaticosAsync(orden, solicitud);
        }

        public System.Collections.Generic.List<Entidades.SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(Entidades.OrdenDeViaticos obj)
        {
            return base.Channel.ObtenerOrden(obj);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_OBTENER_ORDEN_VIATICOS_Result>> ObtenerOrdenAsync(Entidades.OrdenDeViaticos obj)
        {
            return base.Channel.ObtenerOrdenAsync(obj);
        }

        public System.Collections.Generic.List<Entidades.TBL_ROLUSUARIO> ObtenerRoles()
        {
            return base.Channel.ObtenerRoles();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_ROLUSUARIO>> ObtenerRolesAsync()
        {
            return base.Channel.ObtenerRolesAsync();
        }

        public System.Collections.Generic.List<Entidades.TBL_ESTADOS> ObtenerEstados()
        {
            return base.Channel.ObtenerEstados();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_ESTADOS>> ObtenerEstadosAsync()
        {
            return base.Channel.ObtenerEstadosAsync();
        }

        public System.Collections.Generic.List<Entidades.SP_LISTAR_MODTARIFAVIATICO_Result> ObtenerMODTARIFASVIATICOS()
        {
            return base.Channel.ObtenerMODTARIFASVIATICOS();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTAR_MODTARIFAVIATICO_Result>> ObtenerMODTARIFASVIATICOSAsync()
        {
            return base.Channel.ObtenerMODTARIFASVIATICOSAsync();
        }

        public int ActualizarMODTARIFASVIATICOS(Entidades.SP_LISTAR_MODTARIFAVIATICO_Result obj)
        {
            return base.Channel.ActualizarMODTARIFASVIATICOS(obj);
        }

        public System.Threading.Tasks.Task<int> ActualizarMODTARIFASVIATICOSAsync(Entidades.SP_LISTAR_MODTARIFAVIATICO_Result obj)
        {
            return base.Channel.ActualizarMODTARIFASVIATICOSAsync(obj);
        }

        public System.Collections.Generic.List<Entidades.SP_OBTENER_CANTON_PROVINCIA_Result> ObtenerIDS_CANTON_PROVINCIA(Entidades.IdCantonIdProvincia obj)
        {
            return base.Channel.ObtenerIDS_CANTON_PROVINCIA(obj);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_OBTENER_CANTON_PROVINCIA_Result>> ObtenerIDS_CANTON_PROVINCIAAsync(Entidades.IdCantonIdProvincia obj)
        {
            return base.Channel.ObtenerIDS_CANTON_PROVINCIAAsync(obj);
        }

        public System.Collections.Generic.List<Entidades.SP_LISTAR_TARIFASAUTOBUSES_Result> ObtenerTARIFASAUTOBUSES()
        {
            return base.Channel.ObtenerTARIFASAUTOBUSES();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTAR_TARIFASAUTOBUSES_Result>> ObtenerTARIFASAUTOBUSESAsync()
        {
            return base.Channel.ObtenerTARIFASAUTOBUSESAsync();
        }

        public System.Collections.Generic.List<Entidades.SP_BUSCAR_TARIFAAUTOBUS_Result> BuscarTarifaAutobusXId(Entidades.TBL_TARIFAAUTOBUS obj)
        {
            return base.Channel.BuscarTarifaAutobusXId(obj);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_BUSCAR_TARIFAAUTOBUS_Result>> BuscarTarifaAutobusXIdAsync(Entidades.TBL_TARIFAAUTOBUS obj)
        {
            return base.Channel.BuscarTarifaAutobusXIdAsync(obj);
        }

        public int ActualizarTarifaAutobus(Entidades.TBL_TARIFAAUTOBUS obj)
        {
            return base.Channel.ActualizarTarifaAutobus(obj);
        }

        public System.Threading.Tasks.Task<int> ActualizarTarifaAutobusAsync(Entidades.TBL_TARIFAAUTOBUS obj)
        {
            return base.Channel.ActualizarTarifaAutobusAsync(obj);
        }

        public System.Collections.Generic.List<Entidades.TBL_CABECERAORDENVIATICO> ListarOrdenes()
        {
            return base.Channel.ListarOrdenes();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_CABECERAORDENVIATICO>> ListarOrdenesAsync()
        {
            return base.Channel.ListarOrdenesAsync();

        }

        public int ActualizarOrdenViatico(Entidades.TBL_CABECERAORDENVIATICO obj)
        {
            return base.Channel.ActualizarOrdenViatico(obj);
        }

        public System.Threading.Tasks.Task<int> ActualizarOrdenViaticoAsync(Entidades.TBL_CABECERAORDENVIATICO obj)
        {
            return base.Channel.ActualizarOrdenViaticoAsync(obj);
        }
    }
}