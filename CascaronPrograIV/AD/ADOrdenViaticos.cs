using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AD
{
    public class ADOrdenViaticos
    {
        private static EmpresaPK2Entities contexto = null;

        public static List<SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(OrdenDeViaticos obj)
        {
            List<SP_OBTENER_ORDEN_VIATICOS_Result> lista = null;
            try
            {
                lista = new List<SP_OBTENER_ORDEN_VIATICOS_Result>();
                contexto = new EmpresaPK2Entities();

                var consulta = contexto.SP_OBTENER_ORDEN_VIATICOS(obj.NomUsuario).ToList();

                if (consulta != null)
                {
                    foreach (var item in consulta)
                    {

                        lista.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null) contexto.Dispose();
            }

            return lista;
        }
       
        public static List<TBL_CABECERAORDENVIATICO> ListarOrdenes(TBL_CABECERAORDENVIATICO orden)
        {
            List<TBL_CABECERAORDENVIATICO> lista = new List<TBL_CABECERAORDENVIATICO>();
            try
            {
                contexto = new EmpresaPK2Entities();

                var consulta = contexto.SP_LISTAR_ORDEN().ToList();

                if (consulta != null)
                {
                    foreach (var item in consulta)
                    {
                        TBL_CABECERAORDENVIATICO ov = new TBL_CABECERAORDENVIATICO();

                        ov.ID_ORDEN = item.ID_ORDEN;
                        ov.ID_SOLICITUD = item.ID_SOLICITUD;
                        ov.ESTADOORDEN = item.ESTADOORDEN;
                        ov.FECHAORDEN = item.FECHAORDEN;

                        lista.Add(ov); 
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null) contexto.Dispose();
            }

            return lista;
        }

        public static int GenerarOrdenViaticos(TBL_CABECERAORDENVIATICO orden, TBL_SOLICITUDVIATICOS solicitud)
        {
            try
            {
                contexto = new EmpresaPK2Entities();

                contexto.SP_GENERAR_ORDEN_VIATICOS(orden.ID_SOLICITUD, solicitud.NOMBREUSUARIO,
                                solicitud.ESTADOSOLICITUD, orden.FECHAORDEN, orden.ESTADOORDEN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                {
                    contexto.Dispose();
                }
                contexto = null;
            }

            return 1;

        }

        public static int ActualizarOrdenViaticos(TBL_CABECERAORDENVIATICO orden)
        {
            try
            {
                contexto = new EmpresaPK2Entities();
                //contexto.sp_ModificarUsuario(usuario.nomUsuario, usuario.pass, usuario.activo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null) contexto.Dispose();
            }

            return 1;
        }

    }
}
