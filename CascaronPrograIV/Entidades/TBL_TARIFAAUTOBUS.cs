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
    
    public partial class TBL_TARIFAAUTOBUS
    {
        public TBL_TARIFAAUTOBUS()
        {
            this.TBL_DETALLESOLICITUDVIATICOS = new HashSet<TBL_DETALLESOLICITUDVIATICOS>();
        }
    
        public string CODIGORUTA { get; set; }
        public short ESTADORUTA { get; set; }
        public decimal TARIFAREGISTRADA { get; set; }
        public string DESCRIPCIONRUTA { get; set; }
        public System.DateTime FECHAVIGENCIA { get; set; }
    
        public virtual ICollection<TBL_DETALLESOLICITUDVIATICOS> TBL_DETALLESOLICITUDVIATICOS { get; set; }
        public virtual TBL_ESTADOS TBL_ESTADOS { get; set; }
    }
}
