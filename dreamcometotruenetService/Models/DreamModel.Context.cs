﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dreamcometotruenetService.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dreambecometrueDBEntities : DbContext
    {
        public dreambecometrueDBEntities()
            : base("name=dreambecometrueDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Dream> Dreams { get; set; }
        public DbSet<DreamCategory> DreamCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDream> UserDreams { get; set; }
        public DbSet<UserFinance> UserFinances { get; set; }
    }
}
