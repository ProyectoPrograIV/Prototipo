using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AD.ADSolicitudViaticos;
using Entidades;
using System.Data;

namespace LN.LNSolicitudViaticos
{
    public class Cls_Solicitud_LN
    {
        public static Boolean GuardarSolicitud(TBL_SOLICITUDVIATICOS Obj_Solicitud, List<TBL_DETALLESOLICITUDVIATICOS> Obj_SolicitudDetalle)
        {
            if (Cls_Solicitud_AD.GuardarSolicitud(Obj_Solicitud, Obj_SolicitudDetalle) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> ListarSolicitudes(String sNombreUsuario)
        {
            return Cls_Solicitud_AD.ListarSolicitudes(sNombreUsuario);
        }
        public static List<SP_LISTAR_LOCALIDAD_Result> ListarLocalidad()
        {
            return Cls_Solicitud_AD.ListarLocalidad();
        }
        public static List<SP_LISTAR_RUTAS_Result> ListarRutas()
        {
            return Cls_Solicitud_AD.ListarRutas();
        }
        public static List<SP_LISTAR_PERSONAS_Result> ListarPersonas()
        {
            return Cls_Solicitud_AD.ListarPersonas();
        }
        public static List<SP_LISTARMONTORUTA_Result> MontoRuta(string sIdRuta)
        {
            return Cls_Solicitud_AD.MontoRuta(sIdRuta);
        }
        public static List<SP_LISTARMONTOS_Result> Montos(int iIdHospedaje)
        {
            return Cls_Solicitud_AD.Montos(iIdHospedaje);
        }
        public static List<SP_LISTAR_SOLICITUDES_UPDATE_Result> ListarSolicitudesActualizar(String sUsuario)
        {
            return Cls_Solicitud_AD.ListarSolicitudesActualizar(sUsuario);
        }
        public static List<SP_LISTAR_SOLICITUDES_VERIFICAR_Result> ListarSolicitudesVerificar()
        {
            return Cls_Solicitud_AD.ListarSolicitudesVerificar();
        }

    public static Boolean VerificarSolicitud(String sIdSolicitud)
        {
            return Cls_Solicitud_AD.VerificarSolicitud(sIdSolicitud);
        }
    }
}