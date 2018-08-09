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
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Vacio() == false)
            {
                LblInicio.Text = "El numero de solicitudes esta vacio.";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Solicitud()", true);
            }
            else
            {

            }
        }
        
        private void LlenarGrid()
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

        private TBL_SOLICITUDVIATICOS AsignarDatos()
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

        protected void TbxFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (TbxCantidadSolicitudes.Text != "")
            {
                if (Convert.ToInt16(TbxCantidadSolicitudes.Text) > 0)
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Inicio()", true);
                }
                else
                {
                    LblInicio.Text = "El Numero de Solicitudes debe ser mayor a 0.";
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Hello", "Negado()", true);
                }
            }
            else
            {
                LblInicio.Text = "El numero de solicitudes esta vacio.";
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
    }
}