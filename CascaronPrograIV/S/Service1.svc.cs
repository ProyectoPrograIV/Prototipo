using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;
using LN;

namespace S
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public void InsertarRol(TBL_ROLUSUARIO obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            Negocios.InsertarRol(obj);
        }


        public void InsertarPersona(TBL_PERSONA obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            Negocios.InsertarPersona(obj);
        }

        public void InsertarUsuario(TBL_USUARIO obj)
        {
            Negocios.InsertarUsuario(obj);
        }


        #region Metodos para reportería.
        public List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(ReporteXFecha obj)
        {
            return LNReportes.ObtenerListaLiquidacion(obj);
        }

        public List<SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(ReporteXFecha obj)
        {
            return LNReportes.ObtenerListaOrden(obj);
        }

        public List<SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(ReporteXFecha obj)
        {
            return LNReportes.ObtenerListaSolicitud(obj);
        }
        #endregion

        #region Obtener Valores de Sistema
        public List<TBL_ROLUSUARIO> ObtenerRoles()
        {

            return Negocios.ObtenerRoles();
        }

        public List<TBL_ESTADOS> ObtenerEstados()
        {
            return Negocios.ObtenerEstados();
        }
        #endregion

        #region Metodos Orden Viaticos

        public List<SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerOrden(OrdenDeViaticos obj)
        {
            return LNOrdenViaticos.ObtenerOrden(obj);
        }

        public List<TBL_CABECERAORDENVIATICO> ListarOrdenes()
        {
            return LNOrdenViaticos.ListarOrdenes();
        }

        public int GenerarOrdenViaticos(TBL_CABECERAORDENVIATICO orden, TBL_SOLICITUDVIATICOS solicitud)
        {
            return LNOrdenViaticos.GenerarOrdenViaticos(orden, solicitud);
        }

        public int ActualizarOrdenViaticos(TBL_CABECERAORDENVIATICO orden)
        {
            return LNOrdenViaticos.ActualizarOrdenViaticos(orden);
        }

        #endregion

        #region Metodos de Parametrizaciones
        public List<SP_LISTAR_MODTARIFAVIATICO_Result> ObtenerMODTARIFASVIATICOS()
        {

           return Negocios.ObtenerMODTARIFASVIATICOS();
        }

        public int ActualizarMODTARIFASVIATICOS(SP_LISTAR_MODTARIFAVIATICO_Result obj)
        {
            return Negocios.ActualizarMODTARIFASVIATICOS(obj);
        }
        public List<SP_OBTENER_CANTON_PROVINCIA_Result> ObtenerIDS_CANTON_PROVINCIA(IdCantonIdProvincia obj)
        {
            return Negocios.ObtenerIDS_CANTON_PROVINCIA(obj);
        }

        //se carga todo lo que tiene la tabla de Tarifas Autobuses
        public  List<SP_LISTAR_TARIFASAUTOBUSES_Result> ObtenerTARIFASAUTOBUSES()
        {
            return Negocios.ObtenerTARIFASAUTOBUSES();
        }
        //se pasa el metodo Buscar Tarifas por ID de tarifa
        public List<SP_BUSCAR_TARIFAAUTOBUS_Result> BuscarTarifaAutobusXId(TBL_TARIFAAUTOBUS obj)
        {
            return Negocios.BuscarTarifaAutobusXId(obj);
        }
        //se pasa hacia las otras capas el metodo para actualizar las Tarifas de Bus
        public int ActualizarTarifaAutobus(TBL_TARIFAAUTOBUS obj)
        {
            return Negocios.ActualizarTarifaAutobus(obj);
        }

        #endregion

        public SP_INICIO_SESION_Result InicioSesion(TBL_USUARIO obj) => Negocios.InicioSesion(obj);
    }
}
