using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.ClasesDatos;
using Procesos.ClasesProcesos;

namespace CascaronPrograIV.Archivos.WebForms
{
    public partial class RecuperarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRecuperar_Click(object sender, EventArgs e)
        {
            if (TbxCorreo.Text != "" && TbxNombreCompleto.Text != "" && TbxNumeroIdentificacion.Text != "")
            {
                ClsRecuperarDatos ObjRecuperarDatos = new ClsRecuperarDatos();
                ClsRecuperarProcesos ObjRecuperarProcesos = new ClsRecuperarProcesos();
                ObjRecuperarDatos.SNombreCompleto = TbxNombreCompleto.Text;
                ObjRecuperarDatos.SIdentificacion = TbxNumeroIdentificacion.Text;
                ObjRecuperarDatos.SCorreoElectronico = TbxCorreo.Text;
                ObjRecuperarProcesos.Mensaje(ObjRecuperarDatos);
                Response.Redirect("Ingreso.aspx");
            }
        }
    }
}