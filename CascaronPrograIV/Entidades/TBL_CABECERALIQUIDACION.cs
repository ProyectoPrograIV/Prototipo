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
    using System.Collections.Generic;
    
    public partial class TBL_CABECERALIQUIDACION
    {
        public int ID_LIQUIDACION { get; set; }
        public int ID_ORDEN { get; set; }
        public short ESTADOLIQUIDACION { get; set; }
        public Nullable<System.DateTime> FECHALIQUIDACION { get; set; }
        public Nullable<decimal> MONTODESAYUNO { get; set; }
        public Nullable<decimal> MONTOALMUERZO { get; set; }
        public Nullable<decimal> MONTOCENA { get; set; }
        public Nullable<decimal> MONTOHOSPEDAJE { get; set; }
        public Nullable<decimal> MONTOPASAJE { get; set; }
    
        public virtual TBL_ESTADOS TBL_ESTADOS { get; set; }
        public virtual TBL_CABECERAORDENVIATICO TBL_CABECERAORDENVIATICO { get; set; }
    }
}
