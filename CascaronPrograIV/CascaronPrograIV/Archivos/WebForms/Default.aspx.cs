using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

namespace CascaronPrograIV.Archivos.WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           SP_INICIO_SESION_Result sesion = (SP_INICIO_SESION_Result) Session["sesion"];
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Sesion Iniciada: " + sesion.NOMBRE +"')", true);

        }
    }
}