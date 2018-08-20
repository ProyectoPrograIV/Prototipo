using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using System.Data;

namespace S
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISolicitud" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISolicitud
    {
        [OperationContract]
        Boolean GuardarSolicitudDetalle(TBL_SOLICITUDVIATICOS Obj_Solicitud, List<TBL_DETALLESOLICITUDVIATICOS> Obj_SolicitudDetalle);

        [OperationContract]
        List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> ListarSolicitudes(String sNombreUsuario);

        [OperationContract]
        List<SP_LISTAR_LOCALIDAD_Result> ListarLocalidad();

        [OperationContract]
        List<SP_LISTAR_RUTAS_Result> ListarRutas();

        [OperationContract]
        List<SP_LISTAR_PERSONAS_Result> ListarPersonas();

        [OperationContract]
        List<SP_LISTARMONTORUTA_Result> MontoRuta(string sIdRuta);

        [OperationContract]
        List<SP_LISTARMONTOS_Result> Montos(int iIdHospedaje);

        [OperationContract]
        List<SP_LISTAR_SOLICITUDES_UPDATE_Result> ListarSolcitudesActualizar(String sUsuario);

        [OperationContract]
        List<SP_LISTAR_SOLICITUDES_VERIFICAR_Result> ListarSolicitudesVerificar();

        [OperationContract]
        Boolean VerificarSolicitud(String sIdSolicitud);
    }
}
