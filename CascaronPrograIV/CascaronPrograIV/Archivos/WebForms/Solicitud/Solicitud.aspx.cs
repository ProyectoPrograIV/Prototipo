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
            WCFSolicitud.SolicitudClient Cliente = new WCFSolicitud.SolicitudClient();
            TBL_SOLICITUDVIATICOS Obj_Solicitud = new TBL_SOLICITUDVIATICOS();
            Obj_Solicitud.NOMBREUSUARIO = "davidotno";
            List<SP_LISTAR_SOLICITUDES_FUNCIONARIO_Result> lista = Cliente.ObtenerListaSolicitudesFuncionario(Obj_Solicitud);

            this.GvConsultarSolicitud.DataSource = null;
            this.GvConsultarSolicitud.DataBind();
            this.GvConsultarSolicitud.DataSource = lista;
            this.GvConsultarSolicitud.DataBind();

          //  GvConsultarSolicitud.DataSource = CargarDatos();
          //  GvConsultarSolicitud.DataBind();
        }

        protected void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Vacio() == false)
            {
                WCFSolicitud.SolicitudClient Cliente = new WCFSolicitud.SolicitudClient();
                if (Cliente.GuardarSolicitud(AsignarDatos()) == true)
                {
                    string script = "alert(\"Solicitud Guardada Exitosamente\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
                else
                {
                    string script = "alert(\"Error al Guardar su Solicitud\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
            }
        }

        /*
        private DataTable CargarDatos()
        {
            WCFSolicitud.SolicitudClient Cliente = new WCFSolicitud.SolicitudClient();
            TBL_SOLICITUDVIATICOS Obj_Solicitud = new TBL_SOLICITUDVIATICOS();
            Obj_Solicitud.NOMBREUSUARIO = "davidotno";
            DataTable tabla = Cliente.ListarSolicitudes(Obj_Solicitud);
            Cliente.Close();
            return tabla;
        }*/

        private Boolean Vacio()
        {
            if (TbxDestino.Text == "" || TbxFechaCreacion.Text == "" ||
                TbxFechaRegreso.Text == "" || TbxFechaSalida.Text == "" || TbxHoraRegreso.Text == "" ||
                TbxHoraSalida.Text == "" || TbxJustificacion.Text == "" || TbxUsuario.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private TBL_SOLICITUDVIATICOS AsignarDatos()
        {
            TBL_SOLICITUDVIATICOS Obj_Solicitud;
            Obj_Solicitud = new TBL_SOLICITUDVIATICOS();
            Obj_Solicitud.DESTINO = TbxDestino.Text;
            Obj_Solicitud.FECHACREACION = Convert.ToDateTime(TbxFechaCreacion.Text);
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
    }
}