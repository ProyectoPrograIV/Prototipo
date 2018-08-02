using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace CascaronPrograIV.Archivos.WebForms
{
    public partial class Ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            TBL_USUARIO obj = new TBL_USUARIO();
            obj.NOMBREUSUARIO = this.TbxUsuario.Text;
            obj.CLAVEACCESO = this.TbxPassword.Text;

           WCFServicio.Service1Client serv = new WCFServicio.Service1Client();

            SP_INICIO_SESION_Result sesion = serv.InicioSesion(obj);

            if (sesion == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al iniciar sesion')", true);

            }

            else
            {
                Session["sesion"] = sesion;
                Response.Redirect("Default.aspx");
            }
        }

        protected void LbtnRecuperar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecuperarDatos.aspx");
        }
    }
}