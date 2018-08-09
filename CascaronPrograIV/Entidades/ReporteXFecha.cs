using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteXFecha
    {
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private short estado;
        private string nomUsuario;
        private short iDPersona;

        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public DateTime FechaFinal
        {
            get
            {
                return fechaFinal;
            }

            set
            {
                fechaFinal = value;
            }
        }

        public short Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string NomUsuario
        {
            get
            {
                return nomUsuario;
            }

            set
            {
                nomUsuario = value;
            }
        }

        public short IDPersona
        {
            get
            {
                return iDPersona;
            }

            set
            {
                iDPersona = value;
            }
        }
    }
}
