using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;

namespace S
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void InsertarRol(TBL_ROLUSUARIO obj);
        [OperationContract]
        void InsertarPersona(TBL_PERSONA obj);
        [OperationContract]
        void InsertarUsuario(TBL_USUARIO obj);
        [OperationContract]
        SP_INICIO_SESION_Result InicioSesion(TBL_USUARIO obj);

        #region Metodos para reportería.
        [OperationContract]
        List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(ReporteXFecha obj);
        [OperationContract]
        List<SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(ReporteXFecha obj);
        [OperationContract]
        List<SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(ReporteXFecha obj);
        #endregion

        #region Metodos Orden Viaticos
        [OperationContract]
        void GenerarOrden(TBL_CABECERAORDENVIATICO obj);
        [OperationContract]
        List<SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(OrdenDeViaticos obj);

        #endregion


        #region Obtener Valores de Sistema
        [OperationContract]
        List<TBL_ROLUSUARIO> ObtenerRoles();
        [OperationContract]
        List<TBL_ESTADOS> ObtenerEstados();
        #endregion

        #region Metodos de Parametrizaciones
        [OperationContract]
        List<SP_LISTAR_MODTARIFAVIATICO_Result> ObtenerMODTARIFASVIATICOS();

        #endregion

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // [DataContract]

}
