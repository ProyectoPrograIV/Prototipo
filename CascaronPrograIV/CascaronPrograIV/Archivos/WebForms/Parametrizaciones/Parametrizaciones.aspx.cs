using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace CascaronPrograIV.Archivos.WebForms.Parametrizaciones
{
    public partial class Parametrizaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CargarUsuarios();
        }

        private void CargarUsuarios()//metodo carga el el modelo tarifa viatico en data view
        {
            try
            {
                Entidades.SP_LISTAR_MODTARIFAVIATICO_Result Consulta = new Entidades.SP_LISTAR_MODTARIFAVIATICO_Result();
                WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
                List<Entidades.SP_LISTAR_MODTARIFAVIATICO_Result> resultado = servicio.ObtenerMODTARIFASVIATICOS();
                //el view state es un tipo de variable de sesion solo funciona cuando se está en la pagina
               
                ViewState["lstMODTARIFAVIATICO"] = resultado;
                //carga el DV 
                this.GvTarifaViaticos.DataSource = null;
                this.GvTarifaViaticos.DataBind();
                this.GvTarifaViaticos.DataSource = resultado;
                this.GvTarifaViaticos.DataBind();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<SP_LISTAR_MODTARIFAVIATICO_Result> ObtenerMODTARIFASVIATICOS()
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
            List<SP_LISTAR_MODTARIFAVIATICO_Result> listaObjetos = null;
            listaObjetos = servicio.ObtenerMODTARIFASVIATICOS();
            servicio.Close();
            return listaObjetos;
        }

        protected void GvTarifaViaticos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}