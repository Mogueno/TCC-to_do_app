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
    
    public partial class TB_FACULDADE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_FACULDADE()
        {
            this.TB_NOTA = new HashSet<TB_NOTA>();
            this.TB_USER_FAC = new HashSet<TB_USER_FAC>();
        }
    
        public int FAC_INT_ID { get; set; }
        public string FAC_STR_NOME { get; set; }
        public int USER_INT_ID { get; set; }
    
        public virtual TB_USER TB_USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_NOTA> TB_NOTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USER_FAC> TB_USER_FAC { get; set; }
    }
}
