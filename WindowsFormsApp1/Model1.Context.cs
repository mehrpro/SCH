﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class schooldbEntities : DbContext
    {
        public schooldbEntities()
            : base("name=schooldbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<academic_year> academic_year { get; set; }
        public virtual DbSet<classroom> classrooms { get; set; }
        public virtual DbSet<registered> registereds { get; set; }
        public virtual DbSet<registered_tag> registered_tag { get; set; }
        public virtual DbSet<school> schools { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<tagid> tagids { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}