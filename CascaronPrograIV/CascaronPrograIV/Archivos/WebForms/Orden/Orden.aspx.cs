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
                CargarOrden();
            }
        }

        private List<SP_OBTENER_ORDEN_VIATICOS_Result> ObtenerListaOrden(OrdenDeViaticos obj)
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
            List<SP_OBTENER_ORDEN_VIATICOS_Result> lista = null;
            lista = servicio.ObtenerOrden(obj);
            servicio.Close();
            return lista;

        }
        
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

        protected void Btn_Generar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            OrdenDeViaticos obj = new OrdenDeViaticos();
            obj.NomUsuario = txtBuscar.Text.Trim();
            GvConsultarSolicitud.DataSource = this.ObtenerListaOrden(obj);
            CargarOrden();
        }

        protected void GvActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}