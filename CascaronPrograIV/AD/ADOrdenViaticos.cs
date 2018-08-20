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

        public static List<TBL_CABECERAORDENVIATICO> ObtenerOrden(TBL_SOLICITUDVIATICOS obj)
        {
            List<TBL_CABECERAORDENVIATICO> lista = null;
            try
            {
                lista = new List<TBL_CABECERAORDENVIATICO>();
                contexto = new EmpresaPK2Entities();

                var consulta = contexto.SP_OBTENER_ORDEN_VIATICOS(obj.NOMBREUSUARIO).ToList();

                if (consulta != null)
                {
                    foreach (var item in consulta)
                    {
                        TBL_CABECERAORDENVIATICO ov = new TBL_CABECERAORDENVIATICO();
                        TBL_SOLICITUDVIATICOS sv = new TBL_SOLICITUDVIATICOS();

                        ov.FECHAORDEN = item.FECHAORDEN;
                        ov.ID_ORDEN = item.ID_ORDEN;
                        ov.ID_SOLICITUD = item.ID_SOLICITUD;
                        sv.NOMBREUSUARIO = item.NOMBREUSUARIO;
                        ov.ESTADOORDEN = item.ESTADOORDEN;
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
       
        public static List<TBL_CABECERAORDENVIATICO> ListarOrdenes()
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

        public static List<TBL_CABECERAORDENVIATICO> ObtenerOrdenes()
        {
            List<TBL_CABECERAORDENVIATICO> lista = new List<TBL_CABECERAORDENVIATICO>();
            try
            {
                contexto = new EmpresaPK2Entities();

                var consulta = contexto.SP_OBTENER_ORDENES().ToList();

                if (consulta != null)
                {
                    foreach (var item in consulta)
                    {
                        TBL_CABECERAORDENVIATICO ov = new TBL_CABECERAORDENVIATICO();
                        TBL_SOLICITUDVIATICOS sv = new TBL_SOLICITUDVIATICOS();

                        ov.FECHAORDEN = item.FECHAORDEN;
                        ov.ID_ORDEN = item.ID_ORDEN;
                        ov.ID_SOLICITUD = item.ID_SOLICITUD;
                        ov.ESTADOORDEN = item.ESTADOORDEN;

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
                contexto.SP_ACTUALIZAR_ORDEN_VIATICO(orden.ID_ORDEN, orden.ID_SOLICITUD,
                                                    orden.ESTADOORDEN, orden.FECHAORDEN);
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
