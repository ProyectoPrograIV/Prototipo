using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LN.LNSolicitudViaticos;
using Entidades;
using System.Data;

namespace S
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Solicitud" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Solicitud.svc o Solicitud.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Solicitud : ISolicitud
    {
        public Boolean GuardarSolicitudDetalle(TBL_SOLICITUDVIATICOS Obj_Solicitud, List<TBL_DETALLESOLICITUDVIATICOS> Obj_SolicitudDetalle)
        {
            if (Cls_Solicitud_LN.GuardarSolicitud(Obj_Solicitud, Obj_SolicitudDetalle) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> ListarSolicitudes(TBL_SOLICITUDVIATICOS Obj_Solicitud)
        {
            return Cls_Solicitud_LN.ListarSolicitudes(Obj_Solicitud);
        }

        public List<SP_LISTAR_LOCALIDAD_Result> ListarLocalidad()
        {
            return Cls_Solicitud_LN.ListarLocalidad();
        }

        public List<SP_LISTAR_RUTAS_Result> ListarRutas()
        {
            return Cls_Solicitud_LN.ListarRutas();
        }

        public List<SP_LISTAR_PERSONAS_Result> ListarPersonas()
        {
            return Cls_Solicitud_LN.ListarPersonas();
        }

        public List<SP_LISTARMONTORUTA_Result> MontoRuta(string sIdRuta)
        {
            return Cls_Solicitud_LN.MontoRuta(sIdRuta);
        }

        public List<SP_LISTARMONTOS_Result> Montos(int iIdHospedaje)
        {
            return Cls_Solicitud_LN.Montos(iIdHospedaje);
        }
    }
}
