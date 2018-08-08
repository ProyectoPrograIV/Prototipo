using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace LN
{
    public class ClsLNIngreso
    {

        public static bool VerificarUsuario(TBL_USUARIO usuario)
        {
            return AD.ClsADIngreso.VerificarUsuario(usuario);
        }
    }
}
