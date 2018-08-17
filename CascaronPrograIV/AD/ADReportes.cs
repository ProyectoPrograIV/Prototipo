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
            //Se instancia una lista para guardar los resultados de la consulta.
            List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> ListaResultados = null;
            try
            {
                //Se inicializa el contexto, para abrir la comunicacion a la base de datos.
                contexto = new EmpresaPK2Entities();
                //Se inicializa la lista de resultados para que se reconozca el tipo de objeto
                ListaResultados = new List<SP_LISTADO_LIQUIDACION_VIATICOS_Result>();

                //Se realiza la copnsulta de datos para la consulta realizada.
                var resultado = contexto.SP_LISTADO_LIQUIDACION_VIATICOS(obj.FechaInicio, obj.FechaFinal, obj.NomUsuario, obj.Estado).ToList();

                //para cada objeto o item en la lista obtenida, se agregará a la lista de reusltados
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
            {   //Al finalizar, ya sea que ejecute correctamente todas las instrucciones o que entre en el catch, Cerrara el objeto de entidad.
                if (contexto != null)
                {
                    contexto.Dispose();
                }
            }
            //Devuelve la lista de resultados.
            return ListaResultados;
        }

        public static List<SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(ReporteXFecha obj)
        {
            List<SP_LISTADO_ORDEN_VIATICOS_Result> ListaResultados = null;
            try
            {
                contexto = new EmpresaPK2Entities();
                ListaResultados = new List<SP_LISTADO_ORDEN_VIATICOS_Result>();

                var resultado = contexto.SP_LISTADO_ORDEN_VIATICOS(obj.FechaInicio, obj.FechaFinal, obj.NomUsuario, obj.Estado).ToList();

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

                var resultado = contexto.SP_LISTADO_SOLICITUD_VIATICOS(obj.FechaInicio, obj.FechaFinal,obj.IDPersona, obj.Estado).ToList();

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
