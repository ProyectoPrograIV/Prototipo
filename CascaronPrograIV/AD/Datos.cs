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
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion

            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
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
            EmpresaPK2Entities entidad = null; //Se declara el objeto de entidad para la conexion

            try
            {
                entidad = new EmpresaPK2Entities(); //Se instancia la entidad
                entidad.TBL_PERSONA.Add(obj);     //Se agrega (Este método integrado en LinQ es como hacer un insert)
                entidad.SaveChanges();               //Al usar el método integrado "Add", se debe hacer commit o save changes.

            }
            catch (Exception e)
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
        public static void InsertarUsuario(TBL_USUARIO obj)
        {
            EmpresaPK2Entities entidad = null;
            try
            {
                entidad = new EmpresaPK2Entities();
                entidad.SP_InsertarUsuario(obj.NOMBREUSUARIO, obj.CLAVEACCESO, obj.ID_ROL, obj.ESTADOUSARIO, obj.EMAIL);
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                if (entidad != null)
                {
                    entidad.Dispose();
                }
                entidad = null;
            }
        }

        public static SP_INICIO_SESION_Result InicioSesion(TBL_USUARIO obj)
        {
            EmpresaPK2Entities Entidad = null;
            try
            {
                Entidad = new EmpresaPK2Entities();
                var resultado = Entidad.SP_INICIO_SESION(obj.NOMBREUSUARIO, obj.CLAVEACCESO).FirstOrDefault();
                return resultado;
            }
            catch (Exception x)
            {
                throw x;
                //return null;
            }
            finally
            {
                if (Entidad != null)
                {
                    Entidad.Dispose();
                }
            }
        }

        #region Obtener Valores de Sistema
        public static List<TBL_ROLUSUARIO> ObtenerRoles ()
        {
            EmpresaPK2Entities contexto = null;
            List<TBL_ROLUSUARIO> ListaResultado = null;
            try
            {
                contexto = new EmpresaPK2Entities();

                var consulta = (from reg in contexto.TBL_ROLUSUARIO
                                where reg.ESTADOROL.ToUpper().Equals("Activo")                                
                                select reg).ToList();
                ListaResultado = consulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null) contexto.Dispose();
            }

            return ListaResultado;
        }

        public static List<TBL_ESTADOS> ObtenerEstados()
        {
            EmpresaPK2Entities contexto = null;
            List<TBL_ESTADOS> ListaResultado = null;
            try
            {
                contexto = new EmpresaPK2Entities();

                var consulta = contexto.SP_OBTENER_ESTADOS_ACTIVOS().ToList();
                if (consulta != null)
                {
                    ListaResultado = new List<TBL_ESTADOS>();
                    foreach (var item in consulta)
                    {
                        TBL_ESTADOS obj = new TBL_ESTADOS();
                        obj.DESCODIGO = item.DESCODIGO;
                        obj.ID_CODIGO = item.ID_CODIGO;

                        ListaResultado.Add(obj);
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

            return ListaResultado;
        }
        #endregion

        #region Metodos de Parametrizaciones
         public static List<SP_LISTAR_MODTARIFAVIATICO_Result> ObtenerMODTARIFASVIATICOS()
        {
            //se crea el array list dond se almacenará el resultado
            /*Mediante el contexto de datos se pasan los parametros al procedimiento
            almacenado, y a la vez se convierte el dato que retorna a String, puesto
            que al utilizar Linq To SQL el valor retornado es un IEnumerable u Object*/
            EmpresaPK2Entities Entidad = new EmpresaPK2Entities();
            List<SP_LISTAR_MODTARIFAVIATICO_Result> lstresultado = new List<SP_LISTAR_MODTARIFAVIATICO_Result>();
            /*Se trasladan los datos ingresados por el usuario al objeto "usuario"*/
            try
            {

                var consulta = Entidad.SP_LISTAR_MODTARIFAVIATICO();
                if (consulta != null)//se consulta si no es nula la respuesta
                {
                    foreach (var item in consulta)//recorre el resultado de la consulta
                    {
                        //se instancia un objeto tipo Atencion Odontologica para cargarlo con lo obtenido en BD
                        SP_LISTAR_MODTARIFAVIATICO_Result u = new SP_LISTAR_MODTARIFAVIATICO_Result();
                        u.CODIGOCANTON = item.CODIGOCANTON;
                        u.CODIGOPROVINCIA = item.CODIGOPROVINCIA;
                        u.ESTADOTARIFA = item.ESTADOTARIFA;
                        u.FECHATARIFA = item.FECHATARIFA;
                        u.ID_MODTARIFA = item.ID_MODTARIFA;
                        u.LOCALIDAD = item.LOCALIDAD;
                        u.MONTOTARIFA = item.MONTOTARIFA;
                        u.TIPOTARIFA = item.TIPOTARIFA;

                        //se agregar  el objeto cargado obtenido de BD al array
                        lstresultado.Add(u);
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Entidad != null) Entidad.Dispose();//se cierra la sesion abierta con BD
            }
            //se retorna el objeto cargado obtenido de BD
            return lstresultado;
        }

        public static int ActualizarMODTARIFASVIATICOS(SP_LISTAR_MODTARIFAVIATICO_Result obj)
        {
            //se crea el array list dond se almacenará el resultado
            /*Mediante el contexto de datos se pasan los parametros al procedimiento
            almacenado, y a la vez se convierte el dato que retorna a String, puesto
            que al utilizar Linq To SQL el valor retornado es un IEnumerable u Object*/
            EmpresaPK2Entities Entidad = new EmpresaPK2Entities();

            /*Se trasladan los datos ingresados por el usuario al objeto "usuario"*/
            try
            {
  
            Entidad.SP_ACTUALIZAR_MODTARIFAVIATICO(obj.ID_MODTARIFA,obj.FECHATARIFA,obj.MONTOTARIFA,obj.ESTADOTARIFA);
                return 1;
            }
            catch (Exception )
            {
                return 0;
            }
            finally
            {
                if (Entidad != null) Entidad.Dispose();//se cierra la sesion abierta con BD
            }
            //se retorna el objeto cargado obtenido de BD
          
        }

        public static List<SP_OBTENER_CANTON_PROVINCIA_Result> ObtenerIDS_CANTON_PROVINCIA(IdCantonIdProvincia obj)
        {
            //se crea el array list dond se almacenará el resultado
            /*Mediante el contexto de datos se pasan los parametros al procedimiento
            almacenado, y a la vez se convierte el dato que retorna a String, puesto
            que al utilizar Linq To SQL el valor retornado es un IEnumerable u Object*/
            EmpresaPK2Entities Entidad = new EmpresaPK2Entities();
            List<SP_OBTENER_CANTON_PROVINCIA_Result> lstresultado = new List<SP_OBTENER_CANTON_PROVINCIA_Result>();
            /*Se trasladan los datos ingresados por el usuario al objeto "usuario"*/
            try
            {

                var consulta = Entidad.SP_OBTENER_CANTON_PROVINCIA(obj.PropIdCanton,obj.PropIdProvincia);
                if (consulta != null)//se consulta si no es nula la respuesta
                {
                    foreach (var item in consulta)//recorre el resultado de la consulta
                    {
                        //se instancia un objeto tipo Atencion Odontologica para cargarlo con lo obtenido en BD
                        SP_OBTENER_CANTON_PROVINCIA_Result u = new SP_OBTENER_CANTON_PROVINCIA_Result();
                        u.DESCRIPCIONCANTON = item.DESCRIPCIONCANTON;
                        u.DESCRIPCIONPROVINCIA = item.DESCRIPCIONPROVINCIA;
                        

                        //se agregar  el objeto cargado obtenido de BD al array
                        lstresultado.Add(u);
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Entidad != null) Entidad.Dispose();//se cierra la sesion abierta con BD
            }
            //se retorna el objeto cargado obtenido de BD
            return lstresultado;
        }

        public static List<SP_LISTAR_TARIFASAUTOBUSES_Result> ObtenerTARIFASAUTOBUSES()
        {
            //se crea el array list dond se almacenará el resultado
            /*Mediante el contexto de datos se pasan los parametros al procedimiento
            almacenado, y a la vez se convierte el dato que retorna a String, puesto
            que al utilizar Linq To SQL el valor retornado es un IEnumerable u Object*/
            EmpresaPK2Entities Entidad = new EmpresaPK2Entities();
            List<SP_LISTAR_TARIFASAUTOBUSES_Result> lstresultado = new List<SP_LISTAR_TARIFASAUTOBUSES_Result>();
            /*Se trasladan los datos ingresados por el usuario al objeto "lstresultado"*/
            try
            {

                var consulta = Entidad.SP_LISTAR_TARIFASAUTOBUSES();
                if (consulta != null)//se consulta si no es nula la respuesta
                {
                    foreach (var item in consulta)//recorre el resultado de la consulta
                    {
                        //se instancia un objeto tipo Atencion Odontologica para cargarlo con lo obtenido en BD
                        SP_LISTAR_TARIFASAUTOBUSES_Result u = new SP_LISTAR_TARIFASAUTOBUSES_Result();
                        u.CODIGORUTA = item.CODIGORUTA;
                        u.DESCRIPCIONRUTA = item.DESCRIPCIONRUTA;
                        u.ESTADORUTA = item.ESTADORUTA;
                        u.FECHAVIGENCIA = item.FECHAVIGENCIA;
                        u.TARIFAREGISTRADA = item.TARIFAREGISTRADA;
                    

                        //se agregar  el objeto cargado obtenido de BD al array
                        lstresultado.Add(u);
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Entidad != null) Entidad.Dispose();//se cierra la sesion abierta con BD
            }
            //se retorna el objeto cargado obtenido de BD
            return lstresultado;
        }

        public static List<SP_BUSCAR_TARIFAAUTOBUS_Result> BuscarTarifaAutobusXId(TBL_TARIFAAUTOBUS obj)
        {
            //se instancia contorno de BD
            EmpresaPK2Entities Entidad = new EmpresaPK2Entities();
            List<SP_BUSCAR_TARIFAAUTOBUS_Result> lstresultado = new List<SP_BUSCAR_TARIFAAUTOBUS_Result>();
            /*Se trasladan los datos ingresados por el usuario al objeto "usuario"*/
            try
            {

                var consulta = Entidad.SP_BUSCAR_TARIFAAUTOBUS(obj.CODIGORUTA);
                if (consulta != null)//se consulta si no es nula la respuesta
                {
                    foreach (var item in consulta)//recorre el resultado de la consulta
                    {
                        //se instancia un objeto tipo Atencion Odontologica para cargarlo con lo obtenido en BD
                        SP_BUSCAR_TARIFAAUTOBUS_Result u = new SP_BUSCAR_TARIFAAUTOBUS_Result();
                        u.CODIGORUTA = item.CODIGORUTA;
                        u.DESCRIPCIONRUTA = item.DESCRIPCIONRUTA;
                        u.ESTADORUTA = item.ESTADORUTA;
                        u.FECHAVIGENCIA = item.FECHAVIGENCIA;
                        u.TARIFAREGISTRADA = item.TARIFAREGISTRADA;


                        //se agregar  el objeto cargado obtenido de BD al array
                        lstresultado.Add(u);
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Entidad != null) Entidad.Dispose();//se cierra la sesion abierta con BD
            }
            //se retorna el objeto cargado obtenido de BD
            return lstresultado;
        }

        public static int ActualizarTarifaAutobus(TBL_TARIFAAUTOBUS obj)
        {
           
            /*Mediante el contexto de datos se pasan los parametros al procedimiento
            almacenado, y a la vez se convierte el dato que retorna a String, puesto
            que al utilizar Linq To SQL el valor retornado es un IEnumerable u Object*/
            EmpresaPK2Entities Entidad = new EmpresaPK2Entities();

           
            try
            {
                //se corre el SP desde Entidad y se le manda los paramtros correspondientes
                Entidad.SP_ACTUALIZAR_TARIFASAUTOBUSES(obj.CODIGORUTA, obj.ESTADORUTA, obj.TARIFAREGISTRADA, 
                    obj.DESCRIPCIONRUTA,obj.FECHAVIGENCIA);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                if (Entidad != null) Entidad.Dispose();//se cierra la sesion abierta con BD
            }
            //se retorna el objeto cargado obtenido de BD

        }

        #endregion
    }
}
