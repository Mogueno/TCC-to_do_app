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
    
    public partial class TB_USER_MAT
    {
        public int USER_MAT_ID { get; set; }
        public int MAT_INT_ID { get; set; }
        public int USER_INT_ID { get; set; }
    
        public virtual TB_MATERIA TB_MATERIA { get; set; }
        public virtual TB_USER TB_USER { get; set; }
    }
}
