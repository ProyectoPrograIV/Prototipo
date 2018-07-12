using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascaronPrograIV.Archivos.WebForms.Solicitud
{
    public partial class ActualizacionViaticos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid();
        }

        protected void Btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void Grid()
        {
            if (Gv_Actualizacion.Rows.Count == 0)
            {
                Gv_Actualizacion.DataSource = new string[] { };
                Gv_Actualizacion.DataBind();
            }
        }
    }
}