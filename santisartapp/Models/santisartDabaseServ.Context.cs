﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace santisartapp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class santisar_Entities : DbContext
    {
        public santisar_Entities()
            : base("name=santisar_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ENROLL_PAID> ENROLL_PAID { get; set; }
        public virtual DbSet<ENROLL_PAY> ENROLL_PAY { get; set; }
        public virtual DbSet<ENROLL_STUDENT_CLASS> ENROLL_STUDENT_CLASS { get; set; }
        public virtual DbSet<FOOD> FOOD { get; set; }
        public virtual DbSet<MONTHLY> MONTHLY { get; set; }
        public virtual DbSet<STUDENTS> STUDENTS { get; set; }
    }
}
