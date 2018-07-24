using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AD;

namespace LN
{
    public class Negocios
    {

        public static void InsertarRol(TBL_ROLUSUARIO obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            AD.Datos.InsertarRol(obj);
        }


        public static void InsertarPersona(TBL_PERSONA obj) //Se recibe desde la aplicacion un objeto ya lleno para ingresar a la base de datos

        {
            AD.Datos.InsertarPersona(obj);
        }

        public static void InsertarUsuario(TBL_USUARIO obj)
        {
            AD.Datos.InsertarUsuario(obj);
        }
    }
}
