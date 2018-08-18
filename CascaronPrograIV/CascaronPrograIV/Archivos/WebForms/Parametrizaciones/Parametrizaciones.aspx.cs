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
        //variable para almacenar el resultado de el listado de modtarifaviatico
        static List<SP_LISTAR_MODTARIFAVIATICO_Result> VarSesionresultado = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTarifasHospedaje();
                CargarTarifasAutoBuses();
            }
        }

        private void CargarTarifasHospedaje()//metodo carga el el modelo tarifa viatico en data view
        {
            try
            {
                Entidades.SP_LISTAR_MODTARIFAVIATICO_Result Consulta = new Entidades.SP_LISTAR_MODTARIFAVIATICO_Result();
                WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
                List<Entidades.SP_LISTAR_MODTARIFAVIATICO_Result> resultado = servicio.ObtenerMODTARIFASVIATICOS();
                VarSesionresultado = resultado;
                /*el view state es un tipo de variable de sesion solo funciona cuando se está en la pagina
               se crea variable de sesion para cargar el listado de la tabla MOD TarifaViatico, para 
                poder utilizarlo a la hora de poner los datos en los textbox con seleccione de GV,
                y evitar que se pierda por la paginacion del GV*/
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


        private void CargarTarifasAutoBuses()//metodo carga el el modelo tarifa viatico en data view
        {
            try
            {
                Entidades.SP_LISTAR_TARIFASAUTOBUSES_Result Consulta = new Entidades.SP_LISTAR_TARIFASAUTOBUSES_Result();
                WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();

                List<Entidades.SP_LISTAR_TARIFASAUTOBUSES_Result> resultado = servicio.ObtenerTARIFASAUTOBUSES();

                //carga el DV 
                this.GvTarifaAutobus.DataSource = null;
                this.GvTarifaAutobus.DataBind();
                this.GvTarifaAutobus.DataSource = resultado;
                this.GvTarifaAutobus.DataBind();

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
            CargarTarifasHospedaje();
        }

        protected void GvTarifaViaticos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();

            int IndicePagina = GvTarifaViaticos.PageIndex;
            int index = (IndicePagina * 10) + e.NewSelectedIndex;
            //Asiga lo cargado en la variable de sesion
            List<SP_OBTENER_CANTON_PROVINCIA_Result> listaIDs = new List<SP_OBTENER_CANTON_PROVINCIA_Result>();
            List<SP_LISTAR_MODTARIFAVIATICO_Result> resultado = new List<SP_LISTAR_MODTARIFAVIATICO_Result>();
            //se crea objeto tipos Ids 
            IdCantonIdProvincia IDS = new IdCantonIdProvincia();
            //se crea lista Array donde se almacenaran los IDs de Canton y Provincia
            ArrayList lstIDS = new ArrayList();
            //se carga objeto tipo Ids con los ids de provincia y canton que tiene almacena la variable VarSesionresultado

            IDS.PropIdCanton = VarSesionresultado[index].CODIGOCANTON;
            IDS.PropIdProvincia = VarSesionresultado[index].CODIGOPROVINCIA;
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
            if ((VarSesionresultado[index].ESTADOTARIFA) == 10)
            {
                this.cbEstado.SelectedIndex = 0;
            }
            else if ((VarSesionresultado[index].ESTADOTARIFA) == 9)
            {
                this.cbEstado.SelectedIndex = 1;
            }


            this.TbxFecha.Text = (VarSesionresultado[index].FECHATARIFA).ToShortDateString();
            this.TbxFiltrar.Text = VarSesionresultado[index].ID_MODTARIFA.ToString();
            this.TbxLocalidad.Text = VarSesionresultado[index].LOCALIDAD.ToString();
            this.TbxMonto.Text = VarSesionresultado[index].MONTOTARIFA.ToString();
            this.TbxTipoTarifa.Text = VarSesionresultado[index].TIPOTARIFA.ToString();


        }

        private void Borrar()
        {
            this.TbxFecha.Text = "";
            this.TbxFiltrar.Text = "";
            this.TbxLocalidad.Text = "";
            this.TbxMonto.Text = "";
            this.TbxTipoTarifa.Text = "";
            this.TbxCanton.Text = "";
            this.Tbxprovincia.Text = "";
            this.cbEstado.SelectedIndex = 0;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int respuesta = 0;
                Int16 estado = 0;
                WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
                SP_LISTAR_MODTARIFAVIATICO_Result objModelo = new SP_LISTAR_MODTARIFAVIATICO_Result();
                ArrayList listModelo = new ArrayList();
                if (cbEstado.SelectedIndex == 0)
                {
                    estado = 10;
                }
                else if (cbEstado.SelectedIndex == 1)
                {
                    estado = 9;
                }
                objModelo.ID_MODTARIFA = Convert.ToInt16(TbxFiltrar.Text);
                objModelo.FECHATARIFA = Convert.ToDateTime(TbxFecha.Text);
                objModelo.MONTOTARIFA = Convert.ToDecimal(TbxMonto.Text);
                objModelo.ESTADOTARIFA = estado;

                /*Se crea un objeto de tipo clsUsario del BLL, para encapsular la informacion
                 digitada por el usuario y manipular la misma en la capa de negocios*/

                respuesta = servicio.ActualizarMODTARIFASVIATICOS(objModelo);

                if (respuesta == 0)
                {
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + " NO SE PUDO REALIZAR LA ACTUALIZACION" + "');</script>");
                }

                Borrar();
                CargarTarifasHospedaje();


            }
            catch (Exception)
            {

                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + " NO SE PUDO REALIZAR LA ACTUALIZACION" + "');</script>");
            }

        }

        protected void GvTarifaAutobus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GvTarifaAutobus.PageIndex = e.NewPageIndex;//crea los nuevos indices de pagina
            CargarTarifasAutoBuses();

        }

        protected void Btn_ActualizarBus_Click(object sender, EventArgs e)
        {
            try
            {
                int respuesta = 0;
                Int16 estado = 0;
                WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
                TBL_TARIFAAUTOBUS objAutobus = new TBL_TARIFAAUTOBUS();

                if (dlEstadoBuses.SelectedIndex == 0)
                {
                    estado = 10;
                }
                else if (dlEstadoBuses.SelectedIndex == 1)
                {
                    estado = 9;
                }
                objAutobus.CODIGORUTA = (TbxIdRutaBus.Text);
                objAutobus.FECHAVIGENCIA = Convert.ToDateTime(TbxFechaVigenteBus.Text);
                objAutobus.TARIFAREGISTRADA = Convert.ToDecimal(TbxTarifaBus.Text);
                objAutobus.ESTADORUTA = estado;
                objAutobus.DESCRIPCIONRUTA = TbxDescripcionBus.Text;

                /*Se crea un objeto de tipo clsUsario del BLL, para encapsular la informacion
                 digitada por el usuario y manipular la misma en la capa de negocios*/

                respuesta = servicio.ActualizarTarifaAutobus(objAutobus);

                if (respuesta == 0)
                {
                    this.Page.Response.Write("<script language='JavaScript'>window.alert('" + " NO SE PUDO REALIZAR LA ACTUALIZACION" + "');</script>");
                }

                BorrarAutobuses();
                CargarTarifasAutoBuses();


            }
            catch (Exception)
            {

                this.Page.Response.Write("<script language='JavaScript'>window.alert('" + " NO SE PUDO REALIZAR LA ACTUALIZACION" + "');</script>");
            }

        }

        public void BorrarAutobuses()
        {
            TbxDescripcionBus.Text = "";
            TbxFechaVigenteBus.Text = "";
            TbxIdRutaBus.Text = "";
            TbxTarifaBus.Text = "";
            dlEstadoBuses.SelectedIndex = 0;
            Btn_ActualizarBus.Enabled = false;

        }

        protected void Btn_Buscar_Click(object sender, EventArgs e)
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();

            //Asiga lo cargado en la variable de sesion
            List<SP_BUSCAR_TARIFAAUTOBUS_Result> listRutasBuses = new List<SP_BUSCAR_TARIFAAUTOBUS_Result>();
            //se crea objeto tipos Ids            
            TBL_TARIFAAUTOBUS objAutubus = new TBL_TARIFAAUTOBUS();
            //se crea lista Array donde se almacenaran los IDs de Canton y Provincia
            ArrayList lstIDS = new ArrayList();
            //se carga objeto tipo Ids con los ids de provincia y canton

            objAutubus.CODIGORUTA = (TbxIdRutaBus.Text);

            listRutasBuses = servicio.BuscarTarifaAutobusXId(objAutubus);
            if (listRutasBuses.Count != 0)
            {
                foreach (SP_BUSCAR_TARIFAAUTOBUS_Result item in listRutasBuses)
                {

                    TbxDescripcionBus.Text = item.DESCRIPCIONRUTA;
                    TbxFechaVigenteBus.Text = item.FECHAVIGENCIA.ToShortDateString();
                    TbxTarifaBus.Text = item.TARIFAREGISTRADA.ToString();
                    if (item.ESTADORUTA == 10)
                    {
                        dlEstadoBuses.SelectedIndex = 0;
                    }
                    else if (item.ESTADORUTA == 9)
                    {
                        dlEstadoBuses.SelectedIndex = 1;
                    }
                    Btn_ActualizarBus.Enabled = true;

                }
            }

        }
    }


}
