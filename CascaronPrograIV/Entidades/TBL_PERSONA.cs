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
    
    public partial class TBL_PERSONA
    {
        public TBL_PERSONA()
        {
            this.TBL_DETALLESOLICITUDVIATICOS = new HashSet<TBL_DETALLESOLICITUDVIATICOS>();
        }
    
        public string ID_PERSONA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string NOMBREUSUARIO { get; set; }
    
        public virtual ICollection<TBL_DETALLESOLICITUDVIATICOS> TBL_DETALLESOLICITUDVIATICOS { get; set; }
        public virtual TBL_USUARIO TBL_USUARIO { get; set; }
    }
}
