﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bancoMainEntities1 : DbContext
    {
        public bancoMainEntities1()
            : base("name=bancoMainEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_CURSO> TB_CURSO { get; set; }
        public virtual DbSet<TB_FACULDADE> TB_FACULDADE { get; set; }
        public virtual DbSet<TB_MATERIA> TB_MATERIA { get; set; }
        public virtual DbSet<TB_NOTA> TB_NOTA { get; set; }
        public virtual DbSet<TB_NOTA_STR> TB_NOTA_STR { get; set; }
        public virtual DbSet<TB_PICTURES> TB_PICTURES { get; set; }
        public virtual DbSet<TB_SHARE> TB_SHARE { get; set; }
        public virtual DbSet<TB_USER> TB_USER { get; set; }
        public virtual DbSet<TB_USER_CUR> TB_USER_CUR { get; set; }
        public virtual DbSet<TB_USER_FAC> TB_USER_FAC { get; set; }
        public virtual DbSet<TB_USER_MAT> TB_USER_MAT { get; set; }
    }
}
