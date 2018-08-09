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
        public static Boolean GuardarSolicitud(TBL_SOLICITUDVIATICOS Obj_Solicitud)
        {
            if (Cls_Solicitud_AD.GuardarSolicitud(Obj_Solicitud) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> ListarSolicitudes(TBL_SOLICITUDVIATICOS Obj_Solicitud)
        {
            return Cls_Solicitud_AD.ListarSolicitudes(Obj_Solicitud);
        }
        public static List<SP_LISTAR_LOCALIDAD_Result> ListarLocalidad()
        {
            return Cls_Solicitud_AD.ListarLocalidad();
        }
        public static List<SP_LISTAR_RUTAS_Result> ListarRutas()
        {
            return Cls_Solicitud_AD.ListarRutas();
        }
    }
}