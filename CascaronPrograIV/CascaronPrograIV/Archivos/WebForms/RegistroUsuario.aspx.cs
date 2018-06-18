using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            Server.Transfer("~/Archivos/WebForms/Menu.aspx", true);
        }
    }
}