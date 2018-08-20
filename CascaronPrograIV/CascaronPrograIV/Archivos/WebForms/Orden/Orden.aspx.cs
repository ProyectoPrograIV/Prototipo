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
                ddlEstadosActualizar.Items.Add("Inactivo");
                ddlEstadosActualizar.Items.Add("Activo");
                CargarGVConsultas();
                CargarGVActualizar();
            }
        }

        #region Metodos Para Cargar Gridviews

        private void CargarOrden()
        {
            try
            {
                TBL_SOLICITUDVIATICOS obj = new TBL_SOLICITUDVIATICOS();

                this.GvConsultarSolicitud.DataSource = null;
                this.GvConsultarSolicitud.DataBind();
                this.GvConsultarSolicitud.DataSource = ObtenerListaOrden(obj);
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

        private void CargarGVConsultas()
        {
            try
            {
                this.GvActualizar.DataSource = null;
                this.GvActualizar.DataBind();
                this.GvActualizar.DataSource = ObtenerOrdenes();
                this.GvActualizar.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void GvActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdOrdenAct.Text = GvActualizar.SelectedRow.Cells[1].Text;
            txtIdSolicitudAct.Text = GvActualizar.SelectedRow.Cells[2].Text;
            if (GvActualizar.SelectedRow.Cells[3].Text == "Activo")
            {
                ddlEstadosActualizar.SelectedIndex = 0;
            }
            //ddlEstadosActualizar.SelectedIndex = Convert.ToInt16(GvActualizar.SelectedRow.Cells[2].Text);
            txtFechaAct.Text = GvActualizar.SelectedRow.Cells[4].Text;
        }
        #endregion

        #region Metodos de WFC 

        private List<TBL_CABECERAORDENVIATICO> ObtenerListaOrden(TBL_SOLICITUDVIATICOS obj)
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
            List<TBL_CABECERAORDENVIATICO> lista = null;
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
        
        public static List<TBL_CABECERAORDENVIATICO> ObtenerOrdenes()
        {
            WCFServicio.Service1Client servicio = null;

            try
            {
                servicio = new WCFServicio.Service1Client();

                return servicio.ObtenerOrdenes();
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

                return servicio.ActualizarOrdenViaticos(orden);
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
            TBL_SOLICITUDVIATICOS obj = new TBL_SOLICITUDVIATICOS();
            obj.NOMBREUSUARIO = txtBuscar.Text.Trim();
            GvConsultarSolicitud.DataSource = ObtenerListaOrden(obj);
        }

        private void ActualizarOrden()
        {
            try
            {
                TBL_CABECERAORDENVIATICO orden = new TBL_CABECERAORDENVIATICO();

                orden.ID_ORDEN = Convert.ToInt32(txtIdOrdenAct.Text.Trim());
                orden.ID_SOLICITUD = txtIdSolicitudAct.Text.Trim();
                if(ddlEstadosActualizar.SelectedValue == "Activo")
                {
                    orden.ESTADOORDEN = 10;
                }
                else
                {
                    orden.ESTADOORDEN = 9;
                }
                orden.FECHAORDEN = Convert.ToDateTime(txtFechaAct.Text.Trim());

                ActualizarOrdenViatico(orden);
                CargarGVActualizar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarOrden();
            CargarGVActualizar();
        }


        #endregion


    }
}