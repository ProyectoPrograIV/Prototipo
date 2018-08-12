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
                //GvConsultarSolicitud
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                //List<TBL_CABECERAORDENVIATICO> lista = ConexxServicios.ConexxServicios.ObtenerUsuarios();
                //ViewState["lstUsuarios"] = lista;

                this.GvConsultarSolicitud.DataSource = null;
                this.GvConsultarSolicitud.DataBind();
                //this.GvConsultarSolicitud.DataSource = lista;
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
    }
}