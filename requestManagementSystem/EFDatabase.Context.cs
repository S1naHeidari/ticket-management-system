﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RequestManagementEntities : DbContext
    {
        public RequestManagementEntities()
            : base("name=RequestManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<attendant> attendants { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<transfer> transfers { get; set; }
        public virtual DbSet<studyingLiecense> studyingLiecenses { get; set; }
    }
}