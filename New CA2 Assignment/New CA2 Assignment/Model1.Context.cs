﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace New_CA2_Assignment
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class newsaadDBEntities : DbContext
    {
        public newsaadDBEntities()
            : base("name=newsaadDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<shutdown> shutdowns { get; set; }
        public virtual DbSet<Username> Usernames { get; set; }
        public virtual DbSet<bmaintenance> bmaintenances { get; set; }
        public virtual DbSet<smaintenance> smaintenances { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<Name_of_maintenance_Company> Name_of_maintenance_Company { get; set; }
        public virtual DbSet<Qualified_employees> Qualified_employees { get; set; }
        public virtual DbSet<Services_by_a_Company> Services_by_a_Company { get; set; }
    }
}
