//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Menus
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_MATERIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_MATERIA()
        {
            this.TB_NOTA = new HashSet<TB_NOTA>();
            this.TB_USER_MAT = new HashSet<TB_USER_MAT>();
        }
    
        public int MAT_INT_ID { get; set; }
        public string MAT_STR_NOME { get; set; }
        public int USER_INT_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_NOTA> TB_NOTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USER_MAT> TB_USER_MAT { get; set; }
    }
}
