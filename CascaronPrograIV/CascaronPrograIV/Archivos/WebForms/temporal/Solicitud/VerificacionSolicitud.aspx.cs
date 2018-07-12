using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascaronPrograIV.Archivos.WebForms.Solicitud
{
    public partial class VerificacionSolicitud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void Grid()
        {
            if (GvVerificacion.Rows.Count == 0 )
            {
                GvVerificacion.DataSource = new string[] { };
                GvVerificacion.DataBind();
            }
        }

        protected void BtnAprobar_Click(object sender, EventArgs e)
        {

        }
    }
}