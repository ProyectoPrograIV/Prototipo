using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascaronPrograIV.Archivos.WebForms
{
    public partial class Ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void LbtnRecuperar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecuperarDatos.aspx");
        }
    }
}