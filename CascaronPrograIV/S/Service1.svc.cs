using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;
using LN;

namespace S
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public void InsertarRol(TBL_ROLUSUARIO obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            Negocios.InsertarRol(obj);
        }


        public void InsertarPersona(TBL_PERSONA obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            Negocios.InsertarPersona(obj);
        }

        public void InsertarUsuario(TBL_USUARIO obj)
        {
            Negocios.InsertarUsuario(obj);
        }


        #region Metodos para reportería.
        public  List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(ReporteXFecha obj)
        {
            return LNReportes.ObtenerListaLiquidacion(obj);
        }

        public  List<SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(ReporteXFecha obj)
        {
            return LNReportes.ObtenerListaOrden(obj);
        }

        public  List<SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(ReporteXFecha obj)
        {
            return LNReportes.ObtenerListaSolicitud(obj);
        }
        #endregion

        public SP_INICIO_SESION_Result InicioSesion(TBL_USUARIO obj) => Negocios.InicioSesion(obj);
    }
}
