using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace S
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SIngreso" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SIngreso.svc o SIngreso.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SIngreso : ISIngreso
    {
        public void DoWork()
        {
        }
        public bool VerificarUsuario(TBL_USUARIO usuario)
        {
            return LN.ClsLNIngreso.VerificarUsuario(usuario);
        }
    }
}
