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

        public static void GenerarOrden(TBL_CABECERAORDENVIATICO obj)
        {
            AD.ADOrdenViaticos.GenerarOrden(obj);
        }


    }
}
