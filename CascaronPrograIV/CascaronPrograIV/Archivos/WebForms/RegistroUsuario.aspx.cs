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
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private string TOK = "SIAC./";
        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx"); 
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
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            #region Metodos
            TBL_USUARIO Obj_Usuario = new TBL_USUARIO();
            TBL_PERSONA Obj_Persona = new TBL_PERSONA();
            WCFServicio.Service1Client Cliente = new WCFServicio.Service1Client();
            #endregion
            #region Relleno de Variables
            Obj_Usuario.NOMBREUSUARIO = Tbx_Usuario.Text;
            Obj_Usuario.CLAVEACCESO = cifrarPass(Tbx_Password.Text);
            Obj_Usuario.ID_ROL = Convert.ToInt16(Tbx_Cod_Rol.Text);
            Obj_Usuario.ESTADOUSARIO = 10;
            Obj_Usuario.EMAIL = Tbx_Email.Text;

            Obj_Persona.NOMBRE = TbxNombre.Text;
            Obj_Persona.APELLIDOS = Tbx_Apellidos.Text;
            Obj_Persona.ID_PERSONA = Tbx_Identificacion.Text;
            Obj_Persona.NOMBREUSUARIO = Tbx_Usuario.Text;
            #endregion
            
            Cliente.InsertarUsuario(Obj_Usuario);
            Cliente.InsertarPersona(Obj_Persona);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Usuario Creado')", true);
        }
    }
}