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

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public short Estado { get => estado; set => estado = value; }
        public string NomUsuario { get => nomUsuario; set => nomUsuario = value; }
        public short IDPersona { get => iDPersona; set => iDPersona = value; }
    }
}
