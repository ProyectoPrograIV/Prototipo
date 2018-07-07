using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascaronPrograIV.Archivos.WebForms.Parametrizaciones
{
    public partial class ParametroAutobus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Gv_TarifaAutobus.Rows.Count == 0)
            {
                Gv_TarifaAutobus.DataSource = new string[] { };
                Gv_TarifaAutobus.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}