﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CascaronPrograIV.WCFServicio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrdenDeViaticos", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class OrdenDeViaticos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomUsuarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomUsuario {
            get {
                return this.NomUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.NomUsuarioField, value) != true)) {
                    this.NomUsuarioField = value;
                    this.RaisePropertyChanged("NomUsuario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SP_OBTENER_ORDEN_VIATICOS_Result", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class SP_OBTENER_ORDEN_VIATICOS_Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short ESTADOORDENField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FECHAORDENField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_ORDENField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ID_SOLICITUDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NOMBREUSUARIOField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short ESTADOORDEN {
            get {
                return this.ESTADOORDENField;
            }
            set {
                if ((this.ESTADOORDENField.Equals(value) != true)) {
                    this.ESTADOORDENField = value;
                    this.RaisePropertyChanged("ESTADOORDEN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FECHAORDEN {
            get {
                return this.FECHAORDENField;
            }
            set {
                if ((this.FECHAORDENField.Equals(value) != true)) {
                    this.FECHAORDENField = value;
                    this.RaisePropertyChanged("FECHAORDEN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_ORDEN {
            get {
                return this.ID_ORDENField;
            }
            set {
                if ((this.ID_ORDENField.Equals(value) != true)) {
                    this.ID_ORDENField = value;
                    this.RaisePropertyChanged("ID_ORDEN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID_SOLICITUD {
            get {
                return this.ID_SOLICITUDField;
            }
            set {
                if ((object.ReferenceEquals(this.ID_SOLICITUDField, value) != true)) {
                    this.ID_SOLICITUDField = value;
                    this.RaisePropertyChanged("ID_SOLICITUD");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NOMBREUSUARIO {
            get {
                return this.NOMBREUSUARIOField;
            }
            set {
                if ((object.ReferenceEquals(this.NOMBREUSUARIOField, value) != true)) {
                    this.NOMBREUSUARIOField = value;
                    this.RaisePropertyChanged("NOMBREUSUARIO");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerarOrden", ReplyAction="http://tempuri.org/IService1/GenerarOrdenResponse")]
        void GenerarOrden(Entidades.TBL_CABECERAORDENVIATICO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerarOrden", ReplyAction="http://tempuri.org/IService1/GenerarOrdenResponse")]
        System.Threading.Tasks.Task GenerarOrdenAsync(Entidades.TBL_CABECERAORDENVIATICO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerOrden", ReplyAction="http://tempuri.org/IService1/ObtenerOrdenResponse")]
        System.Collections.Generic.List<CascaronPrograIV.WCFServicio.SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(CascaronPrograIV.WCFServicio.OrdenDeViaticos obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ObtenerOrden", ReplyAction="http://tempuri.org/IService1/ObtenerOrdenResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CascaronPrograIV.WCFServicio.SP_OBTENER_ORDEN_VIATICOS_Result>> ObtenerOrdenAsync(CascaronPrograIV.WCFServicio.OrdenDeViaticos obj);
        
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
        
        public void GenerarOrden(Entidades.TBL_CABECERAORDENVIATICO obj) {
            base.Channel.GenerarOrden(obj);
        }
        
        public System.Threading.Tasks.Task GenerarOrdenAsync(Entidades.TBL_CABECERAORDENVIATICO obj) {
            return base.Channel.GenerarOrdenAsync(obj);
        }
        
        public System.Collections.Generic.List<CascaronPrograIV.WCFServicio.SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(CascaronPrograIV.WCFServicio.OrdenDeViaticos obj) {
            return base.Channel.ObtenerOrden(obj);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CascaronPrograIV.WCFServicio.SP_OBTENER_ORDEN_VIATICOS_Result>> ObtenerOrdenAsync(CascaronPrograIV.WCFServicio.OrdenDeViaticos obj) {
            return base.Channel.ObtenerOrdenAsync(obj);
        }
        
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
