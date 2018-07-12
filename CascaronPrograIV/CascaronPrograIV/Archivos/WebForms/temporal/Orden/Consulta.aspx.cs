using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascaronPrograIV.Archivos.WebForms.Orden
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void Grid()
        {
            if (GvConsultaOrden.Rows.Count == 0)
            {
                GvConsultaOrden.DataSource = new string[] { };
                GvConsultaOrden.DataBind();
            }
        }
    }
}