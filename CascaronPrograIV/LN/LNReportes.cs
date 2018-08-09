using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AD;

namespace LN
{
    public class LNReportes
    {

        #region Metodos para reportería.
        public static List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(ReporteXFecha obj)
        {           
            return ADReportes.ObtenerListaLiquidacion(obj);
        }

        public static List<SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(ReporteXFecha obj)
        {
            return ADReportes.ObtenerListaOrden(obj);
        }

        public static List<SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(ReporteXFecha obj)
        {
            return ADReportes.ObtenerListaSolicitud(obj);
        }
        #endregion
    }
}
