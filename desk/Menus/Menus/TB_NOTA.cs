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
    
    public partial class TB_NOTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_NOTA()
        {
            this.TB_NOTA_DES = new HashSet<TB_NOTA_DES>();
            this.TB_NOTA_IMG = new HashSet<TB_NOTA_IMG>();
            this.TB_NOTA_STR1 = new HashSet<TB_NOTA_STR>();
        }
    
        public int NOTA_INT_ID { get; set; }
        public int FAC_INT_ID { get; set; }
        public int CUR_INT_ID { get; set; }
        public int MAT_INT_ID { get; set; }
        public int USER_INT_ID { get; set; }
        public Nullable<int> STR_INT_ID { get; set; }
    
        public virtual TB_CURSO TB_CURSO { get; set; }
        public virtual TB_FACULDADE TB_FACULDADE { get; set; }
        public virtual TB_MATERIA TB_MATERIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_NOTA_DES> TB_NOTA_DES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_NOTA_IMG> TB_NOTA_IMG { get; set; }
        public virtual TB_USER TB_USER { get; set; }
        public virtual TB_NOTA_STR TB_NOTA_STR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_NOTA_STR> TB_NOTA_STR1 { get; set; }
    }
}
