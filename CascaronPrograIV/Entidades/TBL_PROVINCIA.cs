//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_PROVINCIA
    {
        public TBL_PROVINCIA()
        {
            this.TBL_CANTON = new HashSet<TBL_CANTON>();
            this.TBL_MODTARIFARIOVIATICO = new HashSet<TBL_MODTARIFARIOVIATICO>();
            this.TBL_TARIFAAUTOBUS = new HashSet<TBL_TARIFAAUTOBUS>();
        }
    
        public byte CODIGOPROVINCIA { get; set; }
        public string DESCRIPCIONPROVINCIA { get; set; }
    
        public virtual ICollection<TBL_CANTON> TBL_CANTON { get; set; }
        public virtual ICollection<TBL_MODTARIFARIOVIATICO> TBL_MODTARIFARIOVIATICO { get; set; }
        public virtual ICollection<TBL_TARIFAAUTOBUS> TBL_TARIFAAUTOBUS { get; set; }
    }
}
