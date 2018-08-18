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
            //Cuando no es postback, carga todos los valores iniciales de los dropdownlist y cajas de texto.
           if (!this.Page.IsPostBack)
            {
                List<TBL_ESTADOS> ListaEstados = ObtenerEstados();
                this.ddlEstados.DataSource = null;
                ddlEstados.DataBind();
                ddlEstados.DataSource = ListaEstados;
                ddlEstados.DataTextField = "DESCODIGO";
                ddlEstados.DataValueField = "ID_CODIGO";
                ddlEstados.DataBind();
             
                ddlTipoReporte.Items.Insert(0, new ListItem("Viaticos", "1"));
                ddlTipoReporte.Items.Insert(0, new ListItem("Solicitudes", "2"));
                ddlTipoReporte.Items.Insert(0, new ListItem("Liquidaciones", "3"));

                txtFechaFinal.Text = DateTime.Today.ToString("yyyy-MM-dd");
                txtFechaInicial.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {            
            //Obtiene el valor actual del combobox de tipo de reporte seleccionado y luego lo envía para ejecutar la consulta
            int x = Convert.ToInt32( ddlTipoReporte.SelectedValue);
            CompletarConsulta(x);

        }

        private void CompletarConsulta(int consulta)
        {
            //Obtiene la instancia de la sesion, para utilizarla en el reporte
            SP_INICIO_SESION_Result sesion = (SP_INICIO_SESION_Result)Session["sesion"];
            //Se crea un objeto que se llena para indicar los filtros de busqueda de la consulta
            ReporteXFecha obj = new ReporteXFecha();
            obj.FechaInicio = Convert.ToDateTime(txtFechaInicial.Text);
            obj.FechaFinal = Convert.ToDateTime(txtFechaFinal.Text);
            
            obj.Estado = Convert.ToInt16(ddlEstados.SelectedValue);
            


            if (sesion.ID_ROL == 9)
            {   //Si se trata de funcionario, entonces solo podran ser accesibles los reportes con su identificacion
                obj.IDPersona = sesion.ID_PERSONA;
                obj.NomUsuario = sesion.NOMBREUSUARIO;
            }
            else
            {
                //Sin identificacion para jefatura o administracion, revisa solicitudes de todos los funcionarios.
                obj.NomUsuario = "";
                obj.IDPersona = "";
            }
            //Verifica el inicio y fin de las fechas, y muestra un mensaje en caso de ser incorrectas
            if (Convert.ToDateTime(txtFechaFinal.Text) > DateTime.Now || Convert.ToDateTime(txtFechaInicial.Text) > DateTime.Now)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('La fecha final no puede ser mayor a hoy.')", true);

            }
            else if (Convert.ToDateTime(txtFechaFinal.Text) < Convert.ToDateTime(txtFechaInicial.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('La fecha final no puede ser mayor a la fecha inicial.')", true);

            }
            else

            {   //Limpia el origen de datos del gridview
                gvViaticos.DataSource = null;
                gvViaticos.DataBind();

                //asigna a la fuente de datos del gridview la lista corrrespondiente a la consulta que se está realizando.
                switch (consulta)
                {
                    case 1:
                        gvViaticos.DataSource = this.ObtenerListaOrden(obj);
                        break;

                    case 2:

                        gvViaticos.DataSource = this.ObtenerListaSolicitud(obj);
                        break;

                    case 3:
                        gvViaticos.DataSource = this.ObtenerListaLiquidacion(obj);
                        break;

                    default:

                        gvViaticos.DataSource = null;
                        break;
                }
                if (gvViaticos.DataSource == null)
                {
                    //Muestra un mensaje en caso de que la consulta no traiga valores.
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se han encontrado datos con estos criterios.')", true);

                }
            }


            gvViaticos.DataBind();

            gvViaticos.Visible = true;
        }


        #region Metodos para obtener datos
        //Estos metodos se encargan de consumir los servicios realizados en la capa de servicios, Se inicializan para luego ser utilizados para llenar una lista. Luego se cierra el servicio.

        private List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> ObtenerListaLiquidacion(ReporteXFecha obj)
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
            List<SP_LISTADO_LIQUIDACION_VIATICOS_Result> listaObjetos = null;
            listaObjetos = servicio.ObtenerListaLiquidacion(obj);
            servicio.Close();
            return listaObjetos;

        }

        private List<TBL_ESTADOS> ObtenerEstados()
        {
            WCFServicio.Service1Client servicio = new WCFServicio.Service1Client();
            List<TBL_ESTADOS> listaObjetos = null;
            listaObjetos = servicio.ObtenerEstados();
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

        protected void ddlEstados_TextChanged(object sender, EventArgs e)
        {
           // string x = ddlEstados.SelectedItem.ToString();
           // ViewState["SelectedItem"] = x;

        }

        protected void ddlTipoReporte_TextChanged(object sender, EventArgs e)
        {
            h1TituloDiv.InnerText = "Reporte de " + ddlTipoReporte.SelectedItem;
        }
    }
}