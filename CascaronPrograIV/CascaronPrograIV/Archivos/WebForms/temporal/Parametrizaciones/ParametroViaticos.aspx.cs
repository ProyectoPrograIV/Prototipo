using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascaronPrograIV.Archivos.WebForms.Parametrizaciones
{
    public partial class ParametroViaticos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Gv_ModViaticos.Rows.Count == 0)
            {
                Gv_ModViaticos.DataSource = new string[] { };
                Gv_ModViaticos.DataBind();
            }
        }

        protected void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }
    }
}