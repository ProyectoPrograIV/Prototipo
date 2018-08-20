using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Reflection;

namespace AD.ADSolicitudViaticos
{
    public class Cls_Solicitud_AD
    {
        public static Boolean GuardarSolicitud(TBL_SOLICITUDVIATICOS Obj_Solicitud, List<TBL_DETALLESOLICITUDVIATICOS> Obj_DetalleSolicitud)
        {
            EmpresaPK2Entities Entidad = null;
            try
            {
                Entidad = new EmpresaPK2Entities();
                var idsolicitud = Entidad.SP_GUARDAR_SOLICITUDES_FUNCIONARIO(Obj_Solicitud.NOMBREUSUARIO, Obj_Solicitud.FECHACREACION, Obj_Solicitud.FECHASALIDA, Obj_Solicitud.FECHAREGRESO,
                    Obj_Solicitud.JUSTIFICACION, Obj_Solicitud.DESTINO, Obj_Solicitud.HORAREGRESO, Obj_Solicitud.HORASALIDA).FirstOrDefault();
                foreach (TBL_DETALLESOLICITUDVIATICOS Detalle in Obj_DetalleSolicitud)
                {
                    Entidad.SP_GUARDAR_DETALLEVIATICOS(idsolicitud, Detalle.ID_PERSONA, Detalle.CANTIDADVIATICOS, Detalle.CANTIDADDESAYUNO,
                    Detalle.CANTIDADALMUERZO, Detalle.CANTIDADCENA, Detalle.CANTIDADPASAJE, Detalle.MONTODESAYUNO, Detalle.MONTOALMUERZO,
                    Detalle.MONTOCENA, Detalle.MONTOPASAJE, Detalle.MONTOHOSPEDAJE, Detalle.CODIGORUTA, Detalle.LOCALIDADHOSPEDAJE);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if(Entidad != null)
                {
                    Entidad.Dispose();
                }
            }
        }
        public static List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> ListarSolicitudes(String sNombreUsuario)
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> Lista = new List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var templist = entidad.SP_LISTAR_SOLICITUDES_FUNCIONARIO(sNombreUsuario).ToList();
                foreach (var item in templist)
                {
                    Lista.Add(item);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
            return Lista;
        }
        public static List<SP_LISTAR_LOCALIDAD_Result> ListarLocalidad()
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTAR_LOCALIDAD_Result> Lista = new List<SP_LISTAR_LOCALIDAD_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var Resultado = entidad.SP_LISTAR_LOCALIDAD().ToList();
                if (Resultado != null)
                {
                    foreach (var item in Resultado) //Recorre lista
                    {
                        Lista.Add(item); //Agrega cada Linea a la lista que se devovlerá
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
            return Lista;
        }
        public static List<SP_LISTAR_RUTAS_Result> ListarRutas()
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTAR_RUTAS_Result> Lista = new List<SP_LISTAR_RUTAS_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var Resultado = entidad.SP_LISTAR_RUTAS().ToList();
                if (Resultado != null)
                {
                    foreach (var item in Resultado) //Recorre lista
                    {
                        Lista.Add(item); //Agrega cada Linea a la lista que se devovlerá
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
            return Lista;
        }
        public static List<SP_LISTAR_PERSONAS_Result> ListarPersonas()
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTAR_PERSONAS_Result> Lista = new List<SP_LISTAR_PERSONAS_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var Resultado = entidad.SP_LISTAR_PERSONAS().ToList();
                if (Resultado != null)
                {
                    foreach (var item in Resultado) //Recorre lista
                    {
                        Lista.Add(item); //Agrega cada Linea a la lista que se devovlerá
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
            return Lista;
        }
        public static List<SP_LISTAR_SOLICITUDES_UPDATE_Result> ListarSolicitudesActualizar(String sUsuario)
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTAR_SOLICITUDES_UPDATE_Result> Lista = new List<SP_LISTAR_SOLICITUDES_UPDATE_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var Resultado = entidad.SP_LISTAR_SOLICITUDES_UPDATE(sUsuario).ToList();
                if (Resultado != null)
                {
                    foreach (var item in Resultado) //Recorre lista
                    {
                        Lista.Add(item); //Agrega cada Linea a la lista que se devovlerá
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
            return Lista;
        }
        public static List<SP_LISTARMONTORUTA_Result> MontoRuta(string sIdRuta)
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTARMONTORUTA_Result> Lista = new List<SP_LISTARMONTORUTA_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var Resultado = entidad.SP_LISTARMONTORUTA(sIdRuta).ToList();
                if (Resultado != null)
                {
                    foreach (var item in Resultado) //Recorre lista
                    {
                        Lista.Add(item); //Agrega cada Linea a la lista que se devovlerá
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
            return Lista;
        }
        public static List<SP_LISTARMONTOS_Result> Montos(int iIdHospedaje)
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTARMONTOS_Result> Lista = new List<SP_LISTARMONTOS_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var Resultado = entidad.SP_LISTARMONTOS(iIdHospedaje).ToList();
                if (Resultado != null)
                {
                    foreach (var item in Resultado) //Recorre lista
                    {
                        Lista.Add(item); //Agrega cada Linea a la lista que se devovlerá
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
            return Lista;
        }
        public static List<SP_LISTAR_SOLICITUDES_VERIFICAR_Result> ListarSolicitudesVerificar()
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTAR_SOLICITUDES_VERIFICAR_Result> Lista = new List<SP_LISTAR_SOLICITUDES_VERIFICAR_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var Resultado = entidad.SP_LISTAR_SOLICITUDES_VERIFICAR().ToList();
                if (Resultado != null)
                {
                    foreach (var item in Resultado) //Recorre lista
                    {
                        Lista.Add(item); //Agrega cada Linea a la lista que se devovlerá
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
            return Lista;
        }
        public static Boolean VerificarSolicitud(String sIdSolicitud)
        {
            EmpresaPK2Entities Entidad = null;
            try
            {
                Entidad = new EmpresaPK2Entities();
                Entidad.SP_VERIFICAR_SOLICITUDES(sIdSolicitud);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if (Entidad != null)
                {
                    Entidad.Dispose();
                }
            }
        }
    }
}
