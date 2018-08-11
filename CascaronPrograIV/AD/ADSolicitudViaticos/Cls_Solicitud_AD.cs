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
        public static Boolean GuardarSolicitud(TBL_SOLICITUDVIATICOS Obj_Solicitud, TBL_DETALLESOLICITUDVIATICOS Obj_DetalleSolicitud)
        {
            EmpresaPK2Entities Entidad = null;
            try
            {
                Entidad = new EmpresaPK2Entities();
                Entidad.SP_GUARDAR_SOLICITUDES_FUNCIONARIO(Obj_Solicitud.ID_SOLICITUD, Obj_Solicitud.NOMBREUSUARIO, Obj_Solicitud.FECHACREACION, Obj_Solicitud.FECHASALIDA, Obj_Solicitud.FECHAREGRESO,
                    Obj_Solicitud.JUSTIFICACION, Obj_Solicitud.DESTINO, Obj_Solicitud.HORAREGRESO, Obj_Solicitud.HORASALIDA);
                Entidad.SP_GUARDAR_DETALLEVIATICOS(Obj_Solicitud.ID_SOLICITUD, Obj_DetalleSolicitud.ID_PERSONA, Obj_DetalleSolicitud.CANTIDADVIATICOS, Obj_DetalleSolicitud.CANTIDADDESAYUNO, 
                    Obj_DetalleSolicitud.CANTIDADALMUERZO, Obj_DetalleSolicitud.CANTIDADCENA, Obj_DetalleSolicitud.CANTIDADPASAJE, Obj_DetalleSolicitud.MONTODESAYUNO, Obj_DetalleSolicitud.MONTOALMUERZO, 
                    Obj_DetalleSolicitud.MONTOCENA, Obj_DetalleSolicitud.MONTOPASAJE, Obj_DetalleSolicitud.MONTOHOSPEDAJE, Obj_DetalleSolicitud.CODIGORUTA, Obj_DetalleSolicitud.LOCALIDADHOSPEDAJE);
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
        
        public static List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> ListarSolicitudes(TBL_SOLICITUDVIATICOS Obj_Solicitud)
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> Lista = new List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var Resultado = entidad.SP_LISTAR_SOLICITUDES_FUNCIONARIO(Obj_Solicitud.NOMBREUSUARIO).ToList();
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
        public static List<SP_LISTAR_SOLICITUDES_ACTUALIZAR_Result> ListarSolicitudesActualizar(String sUsuario)
        {
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion
            //Se declara una Lista para llevar cada línea con un objeto resultado de la consulta
            List<SP_LISTAR_SOLICITUDES_ACTUALIZAR_Result> Lista = new List<SP_LISTAR_SOLICITUDES_ACTUALIZAR_Result>();
            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                var Resultado = entidad.SP_LISTAR_SOLICITUDES_ACTUALIZAR(sUsuario).ToList();
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
    }
}
