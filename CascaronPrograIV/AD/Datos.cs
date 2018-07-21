using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AD
{
    public class Datos
    {

        //Metodo estático para insertar un nuevo Rol de usuario
        public static void InsertarRol(TBL_ROLUSUARIO obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            EMPRESA_PK2Entities entidad = null; //Se declara el objeto de entidad para la conexion

            try
            {
                entidad = new EMPRESA_PK2Entities(); //Se instancia la entidad
                entidad.TBL_ROLUSUARIO.Add(obj);     //Se agrega (Este método integrado en LinQ es como hacer un insert)
                entidad.SaveChanges();               //Al usar el método integrado "Add", se debe hacer commit o save changes.
                
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (entidad !=null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
        }

        //Metodo estático para insertar un nuevo Rol de usuario
        public static void InsertarPersona(TBL_PERSONA obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            EMPRESA_PK2Entities entidad = null; //Se declara el objeto de entidad para la conexion

            try
            {
                entidad = new EMPRESA_PK2Entities(); //Se instancia la entidad
                entidad.TBL_PERSONA.Add(obj);     //Se agrega (Este método integrado en LinQ es como hacer un insert)
                entidad.SaveChanges();               //Al usar el método integrado "Add", se debe hacer commit o save changes.

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose(); //En caso de que se haya inicializado la entidad pero falló la operación, cierra la conexion a la entidad.
                }
            }
        }

    }
}
