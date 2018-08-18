using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AD;

namespace LN
{
    public class LNOrdenViaticos
    {
        public static List<SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(OrdenDeViaticos obj)
        {
            return ADOrdenViaticos.ObtenerOrden(obj);
        }

        public static List<TBL_CABECERAORDENVIATICO> ListarOrdenes()
        {
            return ADOrdenViaticos.ListarOrdenes();
        }

        public static int GenerarOrdenViaticos(TBL_CABECERAORDENVIATICO orden, TBL_SOLICITUDVIATICOS solicitud)
        {
            return AD.ADOrdenViaticos.GenerarOrdenViaticos(orden, solicitud);
        }

        public static int ActualizarOrdenViaticos(TBL_CABECERAORDENVIATICO orden)
        {
            return AD.ADOrdenViaticos.ActualizarOrdenViaticos(orden);
        }
    }
}
