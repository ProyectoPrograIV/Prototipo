using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.Data;

namespace CascaronPrograIV.Archivos.WebForms.Solicitud
{
    public partial class Solicitud : System.Web.UI.Page
    {
        SP_INICIO_SESION_Result sesion;
        static DataTable dt;
        string idSolicitud = "2";
        protected void Page_Load(object sender, EventArgs e)
        {
            sesion = (SP_INICIO_SESION_Result)Session["sesion"];
            if (!IsPostBack)
            {
                ReadOnlyFields();
                LlenarGridConsulta();
                LlenarGridActualizar();
                CargarLocalidad();
                CargarRutas();
                CargarPersonas();
            }
        }

        private void ReadOnlyFields()
        {
            TbxUsuario.ReadOnly = true;
            Tbx_MontAlm.ReadOnly = true;
            Tbx_MontCenas.ReadOnly = true;
            Tbx_MontDes.ReadOnly = true;
            Tbx_MontPasaj.ReadOnly = true;
        }

        protected void Btn_SolicitudSig_Click(object sender, EventArgs e)
        {
            if (Vacio() == false)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Solicitud()", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Inicio()", true);
            }
        }
        
        protected void TbxFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            TbxUsuario.Text = sesion.NOMBREUSUARIO.ToString();
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Inicio()", true);
        }

        protected void Btn_SolcitudReg_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
        }

        protected void BtnDetalleReg_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Inicio()", true);
        }

        #region Metodos Crear
        private Boolean Vacio()
        {
            if (TbxDestino.Text == "" ||
                TbxFechaRegreso.Text == "" || TbxFechaSalida.Text == "" || TbxHoraRegreso.Text == "" ||
                TbxHoraSalida.Text == "" || TbxJustificacion.Text == "" || TbxUsuario.Text == "")
            {
                Validaciones.Text = "Complete los Campos Vacios";
                return true;
            }
            else
            {
                Validaciones.Text = "";
                return false;
            }
        }

        private TBL_SOLICITUDVIATICOS AsignarDatosSolicitud()
        {
            TBL_SOLICITUDVIATICOS Obj_Solicitud;
            Obj_Solicitud = new TBL_SOLICITUDVIATICOS();
            Obj_Solicitud.ID_SOLICITUD = idSolicitud;
            Obj_Solicitud.DESTINO = TbxDestino.Text;
            Obj_Solicitud.FECHACREACION = DateTime.Now;
            Obj_Solicitud.FECHAREGRESO = Convert.ToDateTime(TbxFechaRegreso.Text);
            Obj_Solicitud.FECHASALIDA = Convert.ToDateTime(TbxFechaSalida.Text);
            Obj_Solicitud.HORAREGRESO = TimeSpan.Parse(TbxHoraRegreso.Text, System.Globalization.CultureInfo.InvariantCulture);
            Obj_Solicitud.HORASALIDA = TimeSpan.Parse(TbxHoraSalida.Text, System.Globalization.CultureInfo.InvariantCulture);
            Obj_Solicitud.JUSTIFICACION = TbxJustificacion.Text;
            Obj_Solicitud.NOMBREUSUARIO = TbxUsuario.Text;
            return Obj_Solicitud;
        }
        private List<TBL_DETALLESOLICITUDVIATICOS> AsignarDetalles()
        {
            int i = 0;
            List<TBL_DETALLESOLICITUDVIATICOS> Array_DetalleViaticos = new List<TBL_DETALLESOLICITUDVIATICOS>();
            TBL_DETALLESOLICITUDVIATICOS Obj_DetalleViaticos = new TBL_DETALLESOLICITUDVIATICOS();
            foreach (DataRow Persona in dt.Rows)
            {
                Obj_DetalleViaticos.CANTIDADDESAYUNO = Convert.ToInt16(Tbx_CantDes.Text);
                Obj_DetalleViaticos.CANTIDADALMUERZO = Convert.ToInt16(Tbx_CantAlm.Text);
                Obj_DetalleViaticos.CANTIDADCENA = Convert.ToInt16(Tbx_CantCenas.Text);
                Obj_DetalleViaticos.CANTIDADPASAJE = Convert.ToInt16(Tbx_CantPasaj.Text);
                Obj_DetalleViaticos.CANTIDADVIATICOS = Convert.ToInt16(Obj_DetalleViaticos.CANTIDADDESAYUNO + Obj_DetalleViaticos.CANTIDADALMUERZO + Obj_DetalleViaticos.CANTIDADCENA + Obj_DetalleViaticos.CANTIDADPASAJE); 
                Obj_DetalleViaticos.MONTODESAYUNO = ObtenerMontos("Desayuno", Convert.ToInt32(Obj_DetalleViaticos.CANTIDADDESAYUNO), 0);
                Obj_DetalleViaticos.MONTOALMUERZO = ObtenerMontos("Almuerzo", Convert.ToInt32(Obj_DetalleViaticos.CANTIDADALMUERZO), 0);
                Obj_DetalleViaticos.MONTOCENA = ObtenerMontos("Cena", Convert.ToInt32(Obj_DetalleViaticos.CANTIDADCENA), 0);
                Obj_DetalleViaticos.MONTOPASAJE = ObtenerMontos("Ruta", Convert.ToInt32(Obj_DetalleViaticos.CANTIDADPASAJE), Convert.ToInt32(Ddl_Ruta.SelectedValue));
                Obj_DetalleViaticos.MONTOHOSPEDAJE = ObtenerMontos("Hospedaje", 
                    Convert.ToInt32((Convert.ToDateTime(TbxFechaRegreso.Text)-Convert.ToDateTime(TbxFechaSalida.Text)).TotalDays), 
                    Convert.ToInt32(Ddl_Hospedaje.SelectedValue));
                Obj_DetalleViaticos.CODIGORUTA = Ddl_Ruta.SelectedValue.ToString();
                Obj_DetalleViaticos.ID_PERSONA = Persona[0].ToString();
                Obj_DetalleViaticos.ID_SOLICITUD = idSolicitud;
                Obj_DetalleViaticos.LOCALIDADHOSPEDAJE = Convert.ToInt16(Ddl_Hospedaje.SelectedValue.ToString());
                Array_DetalleViaticos.Add(Obj_DetalleViaticos);
                i++;
            }
            return Array_DetalleViaticos;
        }
        private Decimal ObtenerMontos(String sTipo, int iCantidad, int iIdRuta_Hosppedaje)
        {
            Decimal total = 0;
            Decimal Cena;
            Decimal Almuerzo;
            Decimal Desayuno;
            Decimal Ruta;
            Decimal Hospedaje;
            WCFSolicitud.SolicitudClient Cliente = new WCFSolicitud.SolicitudClient();
            if (sTipo == "Ruta")
            {
                List<SP_LISTARMONTORUTA_Result> MontoRuta = Cliente.MontoRuta(iIdRuta_Hosppedaje.ToString());
                Ruta = MontoRuta[0].TARIFAREGISTRADA;
                total = iCantidad * Ruta;
                return total;
            }
            else
            {
                List<SP_LISTARMONTOS_Result> Montos = Cliente.Montos(iIdRuta_Hosppedaje);
                foreach (SP_LISTARMONTOS_Result Monto in Montos)
                {
                    if (Monto.TIPOTARIFA.ToString().ToUpper().Trim() == sTipo.ToUpper().Trim())
                    {
                        Desayuno = Monto.MONTOTARIFA;
                        total = iCantidad * Desayuno;
                    }
                    else if (Monto.TIPOTARIFA.ToString().ToUpper().Trim() == sTipo.ToUpper().Trim())
                    {
                        Almuerzo = Monto.MONTOTARIFA;
                        total = iCantidad * Almuerzo;
                    }
                    else if (Monto.TIPOTARIFA.ToString().ToUpper().Trim() == sTipo.ToUpper().Trim())
                    {
                        Cena = Monto.MONTOTARIFA;
                        total = iCantidad * Cena;
                    }
                    else if (Monto.TIPOTARIFA.ToString().ToUpper().Trim() == sTipo.ToUpper().Trim()) 
                    {
                        Hospedaje = Monto.MONTOTARIFA;
                        total = iCantidad * Hospedaje;
                    }
                }
                return total;
            }
        }
        private void CargarPersonas()
        {
            WCFSolicitud.SolicitudClient Cliente = new WCFSolicitud.SolicitudClient();
            var ListaPersonas = Cliente.ListarPersonas();

            Ddl_PersonasSolicitud.DataSource = ListaPersonas;
            Ddl_PersonasSolicitud.DataValueField = "ID_PERSONA";
            Ddl_PersonasSolicitud.DataTextField = "NOMBRECOMPLETO";
            DataBind();
            Ddl_PersonasSolicitud.Items.Insert(0, new ListItem("Añadir personas adicionales a la solicitud", "null"));

        }
        private void CargarLocalidad()
        {
            WCFSolicitud.SolicitudClient Cliente = new WCFSolicitud.SolicitudClient();
            List<SP_LISTAR_LOCALIDAD_Result> ListaLocalidad = Cliente.ListarLocalidad();
            Ddl_Hospedaje.DataSource = ListaLocalidad;
            Ddl_Hospedaje.DataValueField = "ID_MODTARIFA";
            Ddl_Hospedaje.DataTextField = "LOCALIDAD";
            Ddl_Hospedaje.DataBind();
            Ddl_Hospedaje.Items.Insert(0, new ListItem("Seleccione una localidad", "null"));
        }
        private void CargarRutas()
        {
            WCFSolicitud.SolicitudClient Cliente = new WCFSolicitud.SolicitudClient();
            List<SP_LISTAR_RUTAS_Result> ListaRutas = Cliente.ListarRutas();
            Ddl_Ruta.DataSource = ListaRutas;
            Ddl_Ruta.DataValueField = "CODIGORUTA";
            Ddl_Ruta.DataTextField = "DESCRIPCIONRUTA";
            Ddl_Ruta.DataBind();
            Ddl_Ruta.Items.Insert(0, new ListItem("Seleccione una ruta", "null"));
        }
        protected void BtnAgregarPersona_Click(object sender, EventArgs e)//Evento para boton agregar que agrega una persona que este seleccionada en el combobox
        {
            if (Ddl_PersonasSolicitud.SelectedValue != "null")
            {
                if (ComprobarListaPersonas() == false)
                {
                    if (dt != null)
                    {
                        DataTable dt1 = dt;
                        DataRow Row = dt1.NewRow();
                        Row[0] = Ddl_PersonasSolicitud.SelectedValue.ToString();
                        Row[1] = Ddl_PersonasSolicitud.SelectedItem.ToString();
                        dt.Rows.Add(Row);
                        GvPersonas.DataSource = dt1;
                        GvPersonas.DataBind();
                        ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
                    }
                    else
                    {
                        dt = new DataTable();
                        dt.Columns.Add(new DataColumn("Idetificacion", typeof(string)));
                        dt.Columns.Add(new DataColumn("Nombre Completo", typeof(string)));
                        DataRow Row = dt.NewRow();
                        Row[0] = Ddl_PersonasSolicitud.SelectedValue.ToString();
                        Row[1] = Ddl_PersonasSolicitud.SelectedItem.ToString();
                        dt.Rows.Add(Row);
                        GvPersonas.DataSource = dt;
                        GvPersonas.DataBind();
                        ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
            }

        }
        private Boolean ComprobarListaPersonas()//Comprueba que la ppersona no este agregada.
        {
            Boolean Respuesta = false;
            if (dt != null)
            {
                foreach (DataRow Persona in dt.Rows)
                {
                    if (Persona[0].ToString() == Ddl_PersonasSolicitud.SelectedValue.ToString())
                    {
                        Respuesta = true;
                        return Respuesta;
                    }
                    else
                    {
                        Respuesta = false;
                    }
                }
                return Respuesta;
            }
            else
            {
                return Respuesta;
            }
        }
        protected void GvPersonas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                dt.Rows.RemoveAt(index);
                GvPersonas.DeleteRow(index);
                GvPersonas.DataSource = dt;
                GvPersonas.DataBind();
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
            }
        }
        protected void GvPersonas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
        }
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            WCFSolicitud.SolicitudClient Cliente = new WCFSolicitud.SolicitudClient();
            if(Cliente.GuardarSolicitudDetalle(AsignarDatosSolicitud(), AsignarDetalles()) == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Solicitud Guardada')", true);
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Solicitud No Guardada')", true);
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Solicitud()", true);
            }
        }
        #endregion

        #region Metodos Consulta
        private void LlenarGridConsulta()
        {
            GvConsultarSolicitud.DataSource = CargarDatos();
            GvConsultarSolicitud.DataBind();
            if (GvConsultarSolicitud.Columns.Count != 0)
            {
                GvConsultarSolicitud.HeaderRow.Cells[0].Visible = false;
                GvConsultarSolicitud.HeaderRow.Cells[5].Visible = false;
                for (int i = 0; i < GvConsultarSolicitud.Rows.Count; i++)
                {
                    GvConsultarSolicitud.Rows[i].Cells[0].Visible = false;
                    GvConsultarSolicitud.Rows[i].Cells[5].Visible = false;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Informacion", typeof(string));
                DataRow row = dt.NewRow();
                row[0] = "No se encontraron solicitudes";
                dt.Rows.Add(row);
                GvConsultarSolicitud.DataSource = dt;
                GvConsultarSolicitud.DataBind();
            }
        }
        private List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> CargarDatos()
        {
            WCFSolicitud.SolicitudClient Cliente = new WCFSolicitud.SolicitudClient();
            TBL_SOLICITUDVIATICOS Obj_Solicitud = new TBL_SOLICITUDVIATICOS();
            Obj_Solicitud.NOMBREUSUARIO = "davidotno";
            List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> ListaSolicitudes = Cliente.ListarSolicitudes(Obj_Solicitud);
            return ListaSolicitudes;
        }
        
        #endregion

        #region Metodos Actualizar
        private void LlenarGridActualizar()
        {
            GvActualizar.DataSource = CargarDatos();
            GvActualizar.DataBind();
            if (GvActualizar.Columns.Count != 0)
            {
                GvActualizar.HeaderRow.Cells[0].Visible = false;
                GvActualizar.HeaderRow.Cells[5].Visible = false;
                for (int i = 0; i < GvActualizar.Rows.Count; i++)
                {
                    GvActualizar.Rows[i].Cells[0].Visible = false;
                    GvActualizar.Rows[i].Cells[5].Visible = false;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Informacion", typeof(string));
                DataRow row = dt.NewRow();
                row[0] = "No se encontraron solicitudes";
                dt.Rows.Add(row);
                GvActualizar.DataSource = dt;
                GvActualizar.DataBind();
            }
        }
        protected void GvActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbxActuFechaSalida.Text = GvActualizar.SelectedRow.Cells[0].Text;
            TbxActuFechaRegreso.Text = GvActualizar.SelectedRow.Cells[1].Text;
            TbxActuJustificacion.Text = GvActualizar.SelectedRow.Cells[2].Text;
            TbxActuDestino.Text = GvActualizar.SelectedRow.Cells[3].Text;
            TbxActuHoraRegreso.Text = GvActualizar.SelectedRow.Cells[4].Text;
            TbxActuHoraSalida.Text = GvActualizar.SelectedRow.Cells[5].Text;
            TbxActuCantDesayunos.Text = GvActualizar.SelectedRow.Cells[6].Text;
            TbxActuCantAlmuerzos.Text = GvActualizar.SelectedRow.Cells[7].Text;
            TbxActuCantCenas.Text = GvActualizar.SelectedRow.Cells[8].Text;
            TbxActuCantPasajes.Text = GvActualizar.SelectedRow.Cells[9].Text;
            Ddl_ActuRutas.SelectedIndex = Convert.ToInt32(GvActualizar.SelectedRow.Cells[10].Text);
            Ddl_ActuLocalidad.SelectedIndex = Convert.ToInt32(GvActualizar.SelectedRow.Cells[11].Text);
        }

        #endregion

        #region Metodos Verificar

        #endregion
        
    }
}