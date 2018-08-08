using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.Text;
using System.Security.Cryptography;

namespace CascaronPrograIV.Archivos.WebForms
{
    public partial class Ingreso : System.Web.UI.Page
    {
        private string TOK = "SIAC./";
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["sesion"] = null;
        }
        private string cifrarPass(string cadena)
        {

            byte[] llave; //Arreglo donde guardaremos la llave para el cifrado 3DES.
            byte[] arreglo = UTF8Encoding.UTF8.GetBytes(cadena); //Arreglo donde guardaremos la cadena descifrada.

            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(TOK));
            md5.Clear();

            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateEncryptor(); // Iniciamos la conversión de la cadena
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length); //Arreglo de bytes donde guardaremos la cadena cifrada.
            tripledes.Clear();

            return Convert.ToBase64String(resultado, 0, resultado.Length); // Convertimos la cadena y la regresamos.
        }
        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
           
            TBL_USUARIO obj = new TBL_USUARIO();
            obj.NOMBREUSUARIO = this.TbxUsuario.Text;
            obj.CLAVEACCESO =cifrarPass(this.TbxPassword.Text);

           WCFServicio.Service1Client serv = new WCFServicio.Service1Client();

            SP_INICIO_SESION_Result sesion = serv.InicioSesion(obj);

            if (sesion == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al iniciar sesion')", true);
                            }

            else
            {
                Session["sesion"] = sesion;
                
                Response.Redirect("Default.aspx");
            }
        }

        protected void LbtnRecuperar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecuperarDatos.aspx");
        }
    }
}