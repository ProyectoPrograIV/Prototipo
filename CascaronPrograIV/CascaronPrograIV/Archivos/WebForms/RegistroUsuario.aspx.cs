using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace CascaronPrograIV.Archivos.WebForms
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Archivos/WebForms/Menu.aspx", true);
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            #region Metodos
            TBL_USUARIO Obj_Usuario = new TBL_USUARIO();
            TBL_PERSONA Obj_Persona = new TBL_PERSONA();
            WCFServicio.Service1Client Cliente = new WCFServicio.Service1Client();
            #endregion
            #region Relleno de Variables
            Obj_Usuario.NOMBREUSUARIO = Tbx_Usuario.Text;
            Obj_Usuario.CLAVEACCESO = Tbx_Password.Text;
            Obj_Usuario.ID_ROL = 10;
            Obj_Usuario.ESTADOUSARIO = 10;
            Obj_Usuario.EMAIL = Tbx_Email.Text;

            Obj_Persona.NOMBRE = TbxNombre.Text;
            Obj_Persona.APELLIDOS = Tbx_Apellidos.Text;
            Obj_Persona.ID_PERSONA = Tbx_Identificacion.Text;
            Obj_Persona.NOMBREUSUARIO = Tbx_Usuario.Text;
            #endregion
            
            Cliente.InsertarUsuario(Obj_Usuario);
            Cliente.InsertarPersona(Obj_Persona);
        }
    }
}