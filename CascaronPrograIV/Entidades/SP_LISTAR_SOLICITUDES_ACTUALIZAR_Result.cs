//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    
    public partial class SP_LISTAR_SOLICITUDES_ACTUALIZAR_Result
    {
        public System.DateTime FECHASALIDA { get; set; }
        public System.DateTime FECHAREGRESO { get; set; }
        public string JUSTIFICACION { get; set; }
        public string DESTINO { get; set; }
        public System.TimeSpan HORAREGRESO { get; set; }
        public System.TimeSpan HORASALIDA { get; set; }
        public Nullable<short> CANTIDADDESAYUNO { get; set; }
        public Nullable<short> CANTIDADALMUERZO { get; set; }
        public Nullable<short> CANTIDADCENA { get; set; }
        public Nullable<short> CANTIDADPASAJE { get; set; }
        public string CODIGORUTA { get; set; }
        public Nullable<short> LOCALIDADHOSPEDAJE { get; set; }
    }
}