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
    
    public partial class TBL_USUARIO
    {
        public TBL_USUARIO()
        {
            this.TBL_PERSONA = new HashSet<TBL_PERSONA>();
            this.TBL_SOLICITUDVIATICOS = new HashSet<TBL_SOLICITUDVIATICOS>();
        }
    
        public string NOMBREUSUARIO { get; set; }
        public string CLAVEACCESO { get; set; }
        public short ID_ROL { get; set; }
        public short ESTADOUSARIO { get; set; }
        public string EMAIL { get; set; }
    
        public virtual TBL_ESTADOS TBL_ESTADOS { get; set; }
        public virtual ICollection<TBL_PERSONA> TBL_PERSONA { get; set; }
        public virtual TBL_ROLUSUARIO TBL_ROLUSUARIO { get; set; }
        public virtual ICollection<TBL_SOLICITUDVIATICOS> TBL_SOLICITUDVIATICOS { get; set; }
    }
}
