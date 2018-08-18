using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.Data;

namespace CascaronPrograIV.Archivos.WebForms.Orden
{
    public partial class Orden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlEstado.Items.Add("Inactivo");
                ddlEstado.Items.Add("Activo");
                ddlEstadosActualizar.Items.Add("Inactivo");
                ddlEstadosActualizar.Items.Add("Activo");

                CargarOrden();
                CargarGVActualizar();
            }
        }
        #region Metodos Para Cargar Gridviews

        private void CargarOrden()
        {
            try
            {
                OrdenDeViaticos obj = new OrdenDeViaticos();

                this.GvConsultarSolicitud.DataSource = null;
                this.GvConsultarSolicitud.DataBind();
                this.GvConsultarSolicitud.DataSource = this.ObtenerListaOrden(obj);
                this.GvConsultarSolicitud.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarGVActualizar()
        {
            try
            {
                this.GvActualizar.DataSource = null;
                this.GvActualizar.DataBind();
                this.GvActualizar.DataSource = ListarOrdenes();
                this.GvActualizar.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos de WFC 

        private List<SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerListaOrden(OrdenDeViaticos obj)
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
            List<SP_OBTENER_ORDEN_VIATICOS_Result> lista = null;
            lista = servicio.ObtenerOrden(obj);
            servicio.Close();
            return lista;
        }

        public static List<TBL_CABECERAORDENVIATICO> ListarOrdenes()
        {
            WCFServicio.Service1Client servicio = null;

            try
            {
                servicio = new WCFServicio.Service1Client();

                return servicio.ListarOrdenes();
            }
            finally
            {
                if (servicio != null)
                    servicio.Close();
            }
        }

        public static int GenerarOrdenViaticos(TBL_CABECERAORDENVIATICO orden, TBL_SOLICITUDVIATICOS solicitud)
        {
            WCFServicio.Service1Client servicio = null;

            try
            {
                servicio = new WCFServicio.Service1Client();

                return servicio.GenerarOrdenViaticos(orden, solicitud);
            }
            finally
            {
                if (servicio != null)
                    servicio.Close();
            }
        }

        public static int ActualizarOrdenViatico(TBL_CABECERAORDENVIATICO orden)
        {
            WCFServicio.Service1Client servicio = null;

            try
            {
                servicio = new WCFServicio.Service1Client();

                return servicio.ActualizarOrdenViatico(orden);
            }
            finally
            {
                if (servicio != null)
                    servicio.Close();
            }
        }

        #endregion

        #region Metodos para Funciones

        private void GenerarOrden()
        {
            try
            {
                TBL_CABECERAORDENVIATICO orden = new TBL_CABECERAORDENVIATICO();
                TBL_SOLICITUDVIATICOS solicitudv = new TBL_SOLICITUDVIATICOS();

                orden.ID_SOLICITUD = txtID.Text.Trim();
                solicitudv.NOMBREUSUARIO = txtUsuario.Text.Trim();
                solicitudv.ESTADOSOLICITUD = Convert.ToInt16(ddlEstado.SelectedValue.ToString());
                orden.ESTADOORDEN = Convert.ToInt16(ddlEstado.SelectedValue.ToString());
                orden.FECHAORDEN = Convert.ToDateTime(txtFecha.Text.Trim());

                GenerarOrdenViaticos(orden, solicitudv);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void Btn_Generar_Click(object sender, EventArgs e)
        {
            GenerarOrden();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            OrdenDeViaticos obj = new OrdenDeViaticos();
            obj.NomUsuario = txtBuscar.Text.Trim();
            GvConsultarSolicitud.DataSource = this.ObtenerListaOrden(obj);
        }

        protected void GvActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            CargarGVActualizar();
        }


        #endregion


    }
}