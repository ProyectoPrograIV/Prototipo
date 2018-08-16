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
                /*el view state es un tipo de variable de sesion solo funciona cuando se está en la pagina
               se crea variable de sesion para cargar el listado de la tabla MOD TarifaViatico, para 
                poder utilizarlo a la hora de poner los datos en los textbox con seleccione de GV,
                y evitar que se pierda por la paginacion del GV*/
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

        protected void GvTarifaViaticos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GvTarifaViaticos.PageIndex = e.NewPageIndex;//crea los nuevos indices de pagina
            CargarUsuarios();
        }

        protected void GvTarifaViaticos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int IndicePagina = GvTarifaViaticos.PageIndex;
            int index = (IndicePagina*10)+e.NewSelectedIndex;
            //Asiga lo cargado en la variable de sesion
            List<SP_LISTAR_MODTARIFAVIATICO_Result> resultado=(List<SP_LISTAR_MODTARIFAVIATICO_Result>)ViewState["lstMODTARIFAVIATICO"];
            this.TbxCanton.Text = resultado[index].CODIGOCANTON.ToString();
            this.Tbxprovincia.Text = resultado[index].CODIGOPROVINCIA.ToString();
            this.TbxEstado.Text = resultado[index].ESTADOTARIFA.ToString();
            this.TbxFecha.Text = resultado[index].FECHATARIFA.ToString();
            this.TbxFiltrar.Text = resultado[index].ID_MODTARIFA.ToString();
            this.TbxLocalidad.Text = resultado[index].LOCALIDAD.ToString();
            this.TbxMonto.Text = resultado[index].MONTOTARIFA.ToString();
            this.TbxTipoTarifa.Text = resultado[index].TIPOTARIFA.ToString();


        }
    }
}