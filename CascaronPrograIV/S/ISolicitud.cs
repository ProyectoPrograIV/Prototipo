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
        Boolean GuardarSolicitud(TBL_SOLICITUDVIATICOS Obj_Solicitud);

        [OperationContract]
        List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> ListarSolicitudes(TBL_SOLICITUDVIATICOS Obj_Solicitud);

        [OperationContract]
        List<SP_LISTAR_LOCALIDAD_Result> ListarLocalidad();

        [OperationContract]
        List<SP_LISTAR_RUTAS_Result> ListarRutas();
    }
}
