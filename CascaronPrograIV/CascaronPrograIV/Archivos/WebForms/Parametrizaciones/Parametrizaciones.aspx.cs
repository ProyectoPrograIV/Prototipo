using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.Collections;


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
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
           
            int IndicePagina = GvTarifaViaticos.PageIndex;
            int index = (IndicePagina*10)+e.NewSelectedIndex;
            //Asiga lo cargado en la variable de sesion
            List<SP_OBTENER_CANTON_PROVINCIA_Result> listaIDs = new List<SP_OBTENER_CANTON_PROVINCIA_Result>();
            List<SP_LISTAR_MODTARIFAVIATICO_Result> resultado=(List<SP_LISTAR_MODTARIFAVIATICO_Result>)ViewState["lstMODTARIFAVIATICO"];
            //se crea objeto tipos Ids 
            IdCantonIdProvincia IDS = new IdCantonIdProvincia();
            //se crea lista Array donde se almacenaran los IDs de Canton y Provincia
            ArrayList lstIDS = new ArrayList();
            //se carga objeto tipo Ids con los ids de provincia y canton
            
            IDS.PropIdCanton= resultado[index].CODIGOCANTON;
            IDS.PropIdProvincia= resultado[index].CODIGOPROVINCIA;
            lstIDS.Add(IDS);//se agrega objeto a la lista
            ViewState["lstIdCantonIdProvincia"] = lstIDS;//se almacena lista en variable de sesion         
            listaIDs = servicio.ObtenerIDS_CANTON_PROVINCIA(IDS);
            if (listaIDs.Count != 0)
            {
                foreach (SP_OBTENER_CANTON_PROVINCIA_Result item in listaIDs)
                {
                    Tbxprovincia.Text = item.DESCRIPCIONPROVINCIA;
                    TbxCanton.Text = item.DESCRIPCIONCANTON;
               
                }
            }
            if((resultado[index].ESTADOTARIFA)==10)
            {
                this.cbEstado.SelectedIndex= 0;
            }else if ((resultado[index].ESTADOTARIFA) == 9)
                {
                this.cbEstado.SelectedIndex = 1;
                }


            this.TbxFecha.Text = (resultado[index].FECHATARIFA).ToShortDateString();
            this.TbxFiltrar.Text = resultado[index].ID_MODTARIFA.ToString();
            this.TbxLocalidad.Text = resultado[index].LOCALIDAD.ToString();
            this.TbxMonto.Text = resultado[index].MONTOTARIFA.ToString();
            this.TbxTipoTarifa.Text = resultado[index].TIPOTARIFA.ToString();


        }

        private void Borrar()
        {
            this.TbxFecha.Text = "";
            this.TbxFiltrar.Text = "";
            this.TbxLocalidad.Text = "";
            this.TbxMonto.Text = "";
            this.TbxTipoTarifa.Text = "";
            this.TbxCanton.Text= "";
            this.Tbxprovincia.Text= "";
            this.cbEstado.SelectedIndex= 0;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int respuesta = 0;
                Int16 estado=0;
                WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
                SP_LISTAR_MODTARIFAVIATICO_Result objModelo = new SP_LISTAR_MODTARIFAVIATICO_Result();
                ArrayList listModelo = new ArrayList();
                if (cbEstado.SelectedIndex==0)
                {
                    estado = 10;
                }else if (cbEstado.SelectedIndex==1)
                {
                    estado = 9;
                }
                objModelo.ID_MODTARIFA = Convert.ToInt16(TbxFiltrar.Text);
                objModelo.FECHATARIFA = Convert.ToDateTime(TbxFecha.Text);
                objModelo.MONTOTARIFA = Convert.ToDecimal(TbxMonto.Text);
                objModelo.ESTADOTARIFA= estado;

                /*Se crea un objeto de tipo clsUsario del BLL, para encapsular la informacion
                 digitada por el usuario y manipular la misma en la capa de negocios*/

                respuesta = servicio.ActualizarMODTARIFASVIATICOS(objModelo);

                if (respuesta == 0)
                {
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + " NO SE PUDO REALIZAR LA ACTUALIZACION" + "');</script>");
                }

                Borrar();
                CargarUsuarios();


            }
            catch (Exception)
            {

                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + " NO SE PUDO REALIZAR LA ACTUALIZACION" + "');</script>");
            }
            
        }
    }
    }
