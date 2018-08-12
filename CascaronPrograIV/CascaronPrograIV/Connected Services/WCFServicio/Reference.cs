﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Entidades;

namespace CascaronPrograIV.WCFServicio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFServicio.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarRol", ReplyAction="http://tempuri.org/IService1/InsertarRolResponse")]
        void InsertarRol(Entidades.TBL_ROLUSUARIO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarRol", ReplyAction="http://tempuri.org/IService1/InsertarRolResponse")]
        System.Threading.Tasks.Task InsertarRolAsync(Entidades.TBL_ROLUSUARIO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarPersona", ReplyAction="http://tempuri.org/IService1/InsertarPersonaResponse")]
        void InsertarPersona(Entidades.TBL_PERSONA obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarPersona", ReplyAction="http://tempuri.org/IService1/InsertarPersonaResponse")]
        System.Threading.Tasks.Task InsertarPersonaAsync(Entidades.TBL_PERSONA obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarUsuario", ReplyAction="http://tempuri.org/IService1/InsertarUsuarioResponse")]
        void InsertarUsuario(Entidades.TBL_USUARIO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarUsuario", ReplyAction="http://tempuri.org/IService1/InsertarUsuarioResponse")]
        System.Threading.Tasks.Task InsertarUsuarioAsync(Entidades.TBL_USUARIO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InicioSesion", ReplyAction="http://tempuri.org/IService1/InicioSesionResponse")]
        Entidades.SP_INICIO_SESION_Result InicioSesion(Entidades.TBL_USUARIO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InicioSesion", ReplyAction="http://tempuri.org/IService1/InicioSesionResponse")]
        System.Threading.Tasks.Task<Entidades.SP_INICIO_SESION_Result> InicioSesionAsync(Entidades.TBL_USUARIO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaLiquidacion", ReplyAction="http://tempuri.org/IService1/ObtenerListaLiquidacionResponse")]
        System.Collections.Generic.List<Entidades.SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(Entidades.ReporteXFecha obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaLiquidacion", ReplyAction="http://tempuri.org/IService1/ObtenerListaLiquidacionResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_LIQUIDACION_VIATICOS_Result>> ObtenerListaLiquidacionAsync(Entidades.ReporteXFecha obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaOrden", ReplyAction="http://tempuri.org/IService1/ObtenerListaOrdenResponse")]
        System.Collections.Generic.List<Entidades.SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(Entidades.ReporteXFecha obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaOrden", ReplyAction="http://tempuri.org/IService1/ObtenerListaOrdenResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_ORDEN_VIATICOS_Result>> ObtenerListaOrdenAsync(Entidades.ReporteXFecha obj);
        

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaSolicitud", ReplyAction="http://tempuri.org/IService1/ObtenerListaSolicitudResponse")]
        System.Collections.Generic.List<Entidades.SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(Entidades.ReporteXFecha obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerListaSolicitud", ReplyAction="http://tempuri.org/IService1/ObtenerListaSolicitudResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_SOLICITUD_VIATICOS_Result>> ObtenerListaSolicitudAsync(Entidades.ReporteXFecha obj);

        /*SP_OBTENER_ORDEN_VIATICOS_Result ObtenerOrden(OrdenDeViaticos obj)
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerOrden", ReplyAction = "http://tempuri.org/IService1/ObtenerOrdenResponse")]
        System.Collections.Generic.List<Entidades.SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(Entidades.OrdenDeViaticos obj);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/ObtenerListaSolicitud", ReplyAction = "http://tempuri.org/IService1/ObtenerListaSolicitudResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades./SP_OBTENER_ORDEN_VIATICOS_Result>> ObtenerOrdenAsync(Entidades.OrdenDeViaticos obj);
        */

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerRoles", ReplyAction="http://tempuri.org/IService1/ObtenerRolesResponse")]
        System.Collections.Generic.List<Entidades.TBL_ROLUSUARIO> ObtenerRoles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerRoles", ReplyAction="http://tempuri.org/IService1/ObtenerRolesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_ROLUSUARIO>> ObtenerRolesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerEstados", ReplyAction="http://tempuri.org/IService1/ObtenerEstadosResponse")]
        System.Collections.Generic.List<Entidades.TBL_ESTADOS> ObtenerEstados();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerEstados", ReplyAction="http://tempuri.org/IService1/ObtenerEstadosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_ESTADOS>> ObtenerEstadosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CascaronPrograIV.WCFServicio.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CascaronPrograIV.WCFServicio.IService1>, CascaronPrograIV.WCFServicio.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertarRol(Entidades.TBL_ROLUSUARIO obj) {
            base.Channel.InsertarRol(obj);
        }
        
        public System.Threading.Tasks.Task InsertarRolAsync(Entidades.TBL_ROLUSUARIO obj) {
            return base.Channel.InsertarRolAsync(obj);
        }
        
        public void InsertarPersona(Entidades.TBL_PERSONA obj) {
            base.Channel.InsertarPersona(obj);
        }
        
        public System.Threading.Tasks.Task InsertarPersonaAsync(Entidades.TBL_PERSONA obj) {
            return base.Channel.InsertarPersonaAsync(obj);
        }
        
        public void InsertarUsuario(Entidades.TBL_USUARIO obj) {
            base.Channel.InsertarUsuario(obj);
        }
        
        public System.Threading.Tasks.Task InsertarUsuarioAsync(Entidades.TBL_USUARIO obj) {
            return base.Channel.InsertarUsuarioAsync(obj);
        }
        
        public Entidades.SP_INICIO_SESION_Result InicioSesion(Entidades.TBL_USUARIO obj) {
            return base.Channel.InicioSesion(obj);
        }
        
        public System.Threading.Tasks.Task<Entidades.SP_INICIO_SESION_Result> InicioSesionAsync(Entidades.TBL_USUARIO obj) {
            return base.Channel.InicioSesionAsync(obj);
        }
        
        public System.Collections.Generic.List<Entidades.SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(Entidades.ReporteXFecha obj) {
            return base.Channel.ObtenerListaLiquidacion(obj);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_LIQUIDACION_VIATICOS_Result>> ObtenerListaLiquidacionAsync(Entidades.ReporteXFecha obj) {
            return base.Channel.ObtenerListaLiquidacionAsync(obj);
        }
        
        public System.Collections.Generic.List<Entidades.SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(Entidades.ReporteXFecha obj) {
            return base.Channel.ObtenerListaOrden(obj);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_ORDEN_VIATICOS_Result>> ObtenerListaOrdenAsync(Entidades.ReporteXFecha obj) {
            return base.Channel.ObtenerListaOrdenAsync(obj);
        }
        

        public System.Collections.Generic.List<Entidades.SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(Entidades.ReporteXFecha obj) {
            return base.Channel.ObtenerListaSolicitud(obj);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_LISTADO_SOLICITUD_VIATICOS_Result>> ObtenerListaSolicitudAsync(Entidades.ReporteXFecha obj) {
            return base.Channel.ObtenerListaSolicitudAsync(obj);
        }

        /*public System.Collections.Generic.List<Entidades.SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(Entidades.OrdenDeViaticos obj)
        {
            return base.Channel.ObtenerOrden(obj);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.SP_OBTENER_ORDEN_VIATICOS_Result>> ObtenerOrdenAsync(Entidades.OrdenDeViaticos obj)
        {
            return base.Channel.OrdenDeViaticosAsync(obj);
        }*/

        public System.Collections.Generic.List<Entidades.TBL_ROLUSUARIO> ObtenerRoles() {
            return base.Channel.ObtenerRoles();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_ROLUSUARIO>> ObtenerRolesAsync() {
            return base.Channel.ObtenerRolesAsync();
        }
        
        public System.Collections.Generic.List<Entidades.TBL_ESTADOS> ObtenerEstados() {
            return base.Channel.ObtenerEstados();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.TBL_ESTADOS>> ObtenerEstadosAsync() {
            return base.Channel.ObtenerEstadosAsync();
        }
    }
}
