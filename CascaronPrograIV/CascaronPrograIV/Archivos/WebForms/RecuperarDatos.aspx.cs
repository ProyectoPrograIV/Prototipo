using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.ComponentModel;
using System.Net.Mail;

namespace CascaronPrograIV.Archivos.WebForms
{
    public partial class RecuperarDatos : System.Web.UI.Page
    {
              
            static bool mailSent = false;
            private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
            {
                String token = (string)e.UserState;

                if (e.Cancelled)
                {
                    Console.WriteLine("[{0}] Send canceled.", token);
                }
                if (e.Error != null)
                {
                    Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
                }
                else
                {
                    Console.WriteLine("Message sent.");
                }
                mailSent = true;
            }
            public static void Main(string correo,string clave)
            {
                SmtpClient client = new SmtpClient();
                MailAddress from = new MailAddress("jane@contoso.com",
                   "Jane " + (char)0xD8 + " Clayton",
                System.Text.Encoding.UTF8);                
                MailAddress to = new MailAddress(correo);
                MailMessage message = new MailMessage(from, to);
                message.Body = "This is a test e-mail message sent by an application. ";
                string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
                message.Body += Environment.NewLine + someArrows;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = "Clave" + clave +someArrows;
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                client.SendCompleted += new
                SendCompletedEventHandler(SendCompletedCallback);
                string userState = "test message1";
                client.SendAsync(message, userState);
                Console.WriteLine("Sending message... press c to cancel mail. Press any other key to exit.");
                string answer = Console.ReadLine();
                if (answer.StartsWith("c") && mailSent == false)
                {
                    client.SendAsyncCancel();
                }
                message.Dispose();
                Console.WriteLine("Goodbye.");
            }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRecuperar_Click(object sender, EventArgs e)
        {
            
            TBL_USUARIO obj = new TBL_USUARIO();
            obj.NOMBREUSUARIO = this.TbxNombreCompleto.Text;
            obj.EMAIL = this.TbxCorreo.Text;

            WCFServicio.Service1Client serv = new WCFServicio.Service1Client();

            SP_INICIO_SESION_Result sesion = serv.InicioSesion(obj);

            if (sesion == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error al iniciar sesion')", true);
            }

            else
            {

                Main(Convert.ToString(obj.EMAIL), Convert.ToString(obj.CLAVEACCESO));
                
                
            }
        }

        protected void BtnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ingreso.aspx");
        }
    }
}