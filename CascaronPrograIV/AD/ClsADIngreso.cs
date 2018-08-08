using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AD
{
    public class ClsADIngreso
    {
        public static bool VerificarUsuario(TBL_USUARIO usuario)
        {
            EmpresaPK2Entities contexto = null;

            try
            {
                contexto = new EmpresaPK2Entities();

                var consulta = (from reg in contexto.TBL_USUARIO
                                where reg.NOMBREUSUARIO.ToUpper().Equals(usuario.NOMBREUSUARIO.ToUpper())
                                && reg.CLAVEACCESO.Equals(usuario.CLAVEACCESO)
                                select reg).FirstOrDefault();

                if (consulta != null)
                    if (consulta.NOMBREUSUARIO != null)
                        return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null) contexto.Dispose();
            }

            return false;

        }

    }
}
