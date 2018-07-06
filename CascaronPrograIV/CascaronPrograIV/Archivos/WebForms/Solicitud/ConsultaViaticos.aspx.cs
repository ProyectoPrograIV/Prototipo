using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascaronPrograIV.Archivos.WebForms.Solicitud
{
    public partial class ConsultaViaticos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void Grid()
        {
            if (Gv_ConsultaSolicitud.Rows.Count == 0)
            {
                Gv_ConsultaSolicitud.DataSource = new string[] { };
                Gv_ConsultaSolicitud.DataBind();
            }
        }
    }
}