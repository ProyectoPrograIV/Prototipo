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
            WebFormViewer.Src = IdentificadorPagina(e.Item.Value.ToString());
        }

        private String IdentificadorPagina(string sMenuitemValue)
        {
            if (sMenuitemValue == "Tarifas de Autobus")
            {
                return "~/Archivos/WebForms/Parametrizaciones/ParametroAutobus.aspx";
            }
            else if (sMenuitemValue == "Tarifas de Viaticos")
            {
                return "~/Archivos/WebForms/Parametrizaciones/ParametroViaticos.aspx";
            }
            else if (sMenuitemValue == "CreacionSolicitud")
            {
                return "~/Archivos/WebForms/Solicitud/CreacionViaticos.aspx";
            }
            else if (sMenuitemValue == "ConsultaSolicitud")
            {
                return "~/Archivos/WebForms/Solicitud/ConsultaViaticos.aspx";
            }
            else if (sMenuitemValue == "ActualizacionSolicitud")
            {
                return "~/Archivos/WebForms/Solicitud/ActualizacionViaticos.aspx";
            }
            else if (sMenuitemValue == "VerificacionSolicitud")
            {
                return "~/Archivos/WebForms/Solicitud/VerificacionSolicitud.aspx";
            }
            else if (sMenuitemValue == "GeneracionOrden")
            {
                return "~/Archivos/WebForms/Orden/GenerarOrden.aspx";
            }
            else if (sMenuitemValue == "ConsultaOrden")
            {
                return "~/Archivos/WebForms/Orden/Consulta.aspx";
            }
            else if (sMenuitemValue == "ActualizacionOrden")
            {
                return "~/Archivos/WebForms/Orden/Actulizacion.aspx";
            }
            else if (sMenuitemValue == "CreacionLiquidacion")
            {
                return "~/Archivos/WebForms/Liquidacion/Creacion.aspx";
            }
            else if (sMenuitemValue == "ConsultaLiquidacion")
            {
                return "~/Archivos/WebForms/Liquidacion/Consulta.aspx";
            }
            else if (sMenuitemValue == "ActualizacionLiquidacion")
            {
                return "~/Archivos/WebForms/Liquidacion/Actualizacion.aspx";
            }
            else if (sMenuitemValue == "VerificacionLiquidacion")
            {
                return "~/Archivos/WebForms/Liquidacion/Liquidacion.aspx";
            }
            else if (sMenuitemValue == "Usuarios")
            {
                return "~/Archivos/WebForms/RegistroUsuario.aspx";
            }
            else if (sMenuitemValue == "Reportes")
            {
                return "~/Archivos/WebForms/";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}