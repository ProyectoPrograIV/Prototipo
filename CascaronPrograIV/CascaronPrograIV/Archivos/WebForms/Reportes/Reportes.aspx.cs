using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace CascaronPrograIV.Archivos.WebForms.Reportes
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            SP_INICIO_SESION_Result sesion = (SP_INICIO_SESION_Result)Session["sesion"];
            ReporteXFecha obj = new ReporteXFecha();
            obj.FechaInicio = Convert.ToDateTime( txtFechaInicial.Text);
            obj.FechaFinal = Convert.ToDateTime(txtFechaFinal.Text);
            obj.IDPersona = sesion.ID_PERSONA;
            obj.NomUsuario = sesion.ID_PERSONA;
            obj.Estado = 11;


           
            if (Convert.ToDateTime(txtFechaFinal.Text) > DateTime.Now || Convert.ToDateTime(txtFechaInicial.Text) > DateTime.Now)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('La fecha final no puede ser mayor a hoy.')", true);

            }
            else if(Convert.ToDateTime(txtFechaFinal.Text)< Convert.ToDateTime(txtFechaInicial.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('La fecha final no puede ser mayor a la fecha inicial.')", true);

            }
            else

            {
                gvViaticos.DataSource = null;
                gvViaticos.DataBind();
                gvViaticos.DataSource = this.ObtenerListaOrden(obj);
                if (gvViaticos.DataSource == null)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se han encontrado datos con estos criterios.')", true);

                }
            }


            gvViaticos.DataBind();

            gvViaticos.Visible = true;
            

        }
        
    

        #region Metodos para obtener datos
        private List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(ReporteXFecha obj)
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
            List <SP_LISTADO_LIQUIDACION_VIATICOS_Result> listaObjetos = null;
            listaObjetos = servicio.ObtenerListaLiquidacion(obj);
            servicio.Close();
            return listaObjetos;

        }

        private List<SP_LISTADO_ORDEN_VIATICOS_Result> ObtenerListaOrden(ReporteXFecha obj)
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
            List<SP_LISTADO_ORDEN_VIATICOS_Result> listaObjetos = null;
            listaObjetos = servicio.ObtenerListaOrden(obj);
            servicio.Close();
            return listaObjetos;

        }

        private List<SP_LISTADO_SOLICITUD_VIATICOS_Result> ObtenerListaSolicitud(ReporteXFecha obj)
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
            List<SP_LISTADO_SOLICITUD_VIATICOS_Result> listaObjetos = null;
            listaObjetos = servicio.ObtenerListaSolicitud(obj);
            servicio.Close();
            return listaObjetos;

        }

        #endregion

    }
}