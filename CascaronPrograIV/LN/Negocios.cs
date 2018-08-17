using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AD;

namespace LN
{
    public class Negocios
    {

        public static void InsertarRol(TBL_ROLUSUARIO obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            AD.Datos.InsertarRol(obj);
        }


        public static void InsertarPersona(TBL_PERSONA obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            AD.Datos.InsertarPersona(obj);
        }

        public static void InsertarUsuario(TBL_USUARIO obj)
        {
            AD.Datos.InsertarUsuario(obj);
        }

        public static SP_INICIO_SESION_Result InicioSesion(TBL_USUARIO obj)
        {
           return Datos.InicioSesion(obj);
        }

        #region Obtener Valores de Sistema
        public static List<TBL_ROLUSUARIO> ObtenerRoles()
        {
           
            return Datos.ObtenerRoles();
        }

        public static List<TBL_ESTADOS> ObtenerEstados()
        {
            return Datos.ObtenerEstados();
        }
        #endregion

        #region Metodos Parametrizaciones
        //se obtine de BD la lista de las tarifas de Viaticos y Hospedaje
        public static List<SP_LISTAR_MODTARIFAVIATICO_Result> ObtenerMODTARIFASVIATICOS()
        {          
            return Datos.ObtenerMODTARIFASVIATICOS();
        }
        //se actualiza desde la aplicacion la lista de las tarifas de Viaticos y Hospedaje
        public static int ActualizarMODTARIFASVIATICOS(SP_LISTAR_MODTARIFAVIATICO_Result obj)
        {
            return Datos.ActualizarMODTARIFASVIATICOS(obj);
        }
        //se otiene el canton crrepondiente al Id
        public static List<SP_OBTENER_CANTON_PROVINCIA_Result> ObtenerIDS_CANTON_PROVINCIA(IdCantonIdProvincia obj)
        {      
            return Datos.ObtenerIDS_CANTON_PROVINCIA(obj);
        }
        //se carga todo lo que tiene la tabla de Tarifas Autobuses
        public static List<SP_LISTAR_TARIFASAUTOBUSES_Result> ObtenerTARIFASAUTOBUSES()
        {
            return Datos.ObtenerTARIFASAUTOBUSES();
        }
        //se pasa el metodo Buscar Tarifas por ID de tarifa
        public static List<SP_BUSCAR_TARIFAAUTOBUS_Result> BuscarTarifaAutobusXId(TBL_TARIFAAUTOBUS obj)
        {
            return Datos.BuscarTarifaAutobusXId(obj);
        }
        //se pasa hacia las otras capas el metodo para actualizar las Tarifas de Bus
        public static int ActualizarTarifaAutobus(TBL_TARIFAAUTOBUS obj)
        {
            
            return Datos.ActualizarTarifaAutobus(obj);
        }


        #endregion
    }
}
