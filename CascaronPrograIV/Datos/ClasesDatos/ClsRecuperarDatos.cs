using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ClasesDatos
{
    public class ClsRecuperarDatos
    {
        #region Variables Privadas
        private string sIdentificacion, sNombreCompleto, sCorreoElectronico;
        #endregion
        #region Variables Publicas
        public string SIdentificacion
        {
            get
            {
                return sIdentificacion;
            }

            set
            {
                sIdentificacion = value;
            }
        }

        public string SCorreoElectronico
        {
            get
            {
                return sCorreoElectronico;
            }

            set
            {
                sCorreoElectronico = value;
            }
        }

        public string SNombreCompleto
        {
            get
            {
                return sNombreCompleto;
            }

            set
            {
                sNombreCompleto = value;
            }
        }
        #endregion
    }
}
