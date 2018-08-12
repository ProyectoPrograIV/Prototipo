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
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadOnlyFields();
            LlenarGridConsulta();
            LlenarGridActualizar();
            CargarLocalidad();
            CargarRutas();
            CargarPersonas();
            sesion = (SP_INICIO_SESION_Result)Session["sesion"];
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

            }
        }
        
        protected void TbxFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (Ddl_PersonasSolicitud.SelectedIndex != 0)
            {
                if (Convert.ToInt16(0) > 0)
                {
                    TbxUsuario.Text = sesion.NOMBREUSUARIO.ToString();
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Inicio()", true);
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

        protected void Btn_SolcitudReg_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Inicio()", true);
        }

        protected void BtnDetalleReg_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Solicitud()", true);
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

        protected void BtnAgregarPersona_Click(object sender, EventArgs e)
        {
            if (Ddl_PersonasSolicitud.SelectedValue != "null")
            {
                Bl_ListaPersonas.Items.Add(Ddl_PersonasSolicitud.SelectedValue + " " + Ddl_PersonasSolicitud.SelectedItem);
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
            }
        }

        protected void Ddl_PersonasSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAgregarPersona_Click(null ,null);
        }
    }
}