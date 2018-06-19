using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Datos.ClasesDatos;

namespace Procesos.ClasesProcesos
{
    public class ClsRecuperarProcesos
    {
        public void Mensaje(ClsRecuperarDatos ObjRecuperarDatos)
        {
            string to = ObjRecuperarDatos.SCorreoElectronico;
            string from = "empresa.pk2@gmail.com";
            string subject = "PK2 Recuperar datos de inicio";
            string body = @"Informacion........";
            MailMessage Mensaje = new MailMessage(from, to, subject, body);
            EnviarCorreo(Mensaje);
        }

        private void EnviarCorreo(MailMessage Mensaje)
        {
            SmtpClient Cliente = new SmtpClient("smtp.gmail.com", 587);
            Cliente.Credentials = new System.Net.NetworkCredential("empresa.pk2@gmail.com", "Gijn5rebxr");
            Cliente.EnableSsl = true;
            try
            {
                Cliente.Send(Mensaje);
            }
            catch (SmtpException e)
            {

            }
        }

    }
}
