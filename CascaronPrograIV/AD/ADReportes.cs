using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AD
{
    public class ADReportes
    {
        //Elemento utilizado para manejar la conexion a la BD - Se inicializa y cierra dentro de cada metodo
        private static EmpresaPK2Entities contexto = null;


        #region Metodos para reportería.
        public static List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(ReporteXFecha obj)
        {
            List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> ListaResultados = null;
            try
            {
                contexto = new EmpresaPK2Entities();
                ListaResultados = new List<SP_LISTADO_LIQUIDACION_VIATICOS_Result>();

                var resultado = contexto.SP_LISTADO_LIQUIDACION_VIATICOS(obj.FechaInicio, obj.FechaFinal, obj.NomUsuario, obj.IDPersona).ToList();

                foreach (var item in resultado)
                {
                    ListaResultados.Add(item);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (contexto != null)
                {
                    contexto.Dispose();
                }
            }
            return ListaResultados;
        }

        public static List<SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(ReporteXFecha obj)
        {
            List<SP_LISTADO_ORDEN_VIATICOS_Result> ListaResultados = null;
            try
            {
                contexto = new EmpresaPK2Entities();
                ListaResultados = new List<SP_LISTADO_ORDEN_VIATICOS_Result>();

                var resultado = contexto.SP_LISTADO_ORDEN_VIATICOS(obj.FechaInicio, obj.FechaFinal, obj.NomUsuario, obj.IDPersona).ToList();

                foreach (var item in resultado)
                {
                    ListaResultados.Add(item);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (contexto != null)
                {
                    contexto.Dispose();
                }
            }
            return ListaResultados;
        }

        public static List<SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(ReporteXFecha obj)
        {
            List<SP_LISTADO_SOLICITUD_VIATICOS_Result> ListaResultados = null;
            try
            {
                contexto = new EmpresaPK2Entities();
                ListaResultados = new List<SP_LISTADO_SOLICITUD_VIATICOS_Result>();

                var resultado = contexto.SP_LISTADO_SOLICITUD_VIATICOS(obj.FechaInicio, obj.FechaFinal, obj.NomUsuario, obj.IDPersona).ToList();

                foreach (var item in resultado)
                {
                    ListaResultados.Add(item);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (contexto != null)
                {
                    contexto.Dispose();
                }
            }
            return ListaResultados;
        }
        #endregion

    }
}
