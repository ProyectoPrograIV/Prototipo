using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CascaronPrograIV.Archivos.WebForms
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Opciones_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (e.Item.Value.ToString() == "Tarifas de Autobus")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/Parametrizaciones/ParametroAutobus.aspx";
            }
            else if (e.Item.Value.ToString() == "Tarifas de Viaticos")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/Parametrizaciones/ParametroViaticos.apsx";
            }
            else if (e.Item.Value.ToString() == "")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/";
            }
            else if (e.Item.Value.ToString() == "")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/";
            }
            else if (e.Item.Value.ToString() == "")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/";
            }
            else if (e.Item.Value.ToString() == "")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/";
            }
            else if (e.Item.Value.ToString() == "")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/";
            }
            else if (e.Item.Value.ToString() == "")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/";
            }
            else if (e.Item.Value.ToString() == "")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/";
            }
            else if (e.Item.Value.ToString() == "Usuarios")
            {
                WebFormViewer.Src = "~/Archivos/WebForms/RegistroUsuario.aspx";
            }
            
        }
    }
}