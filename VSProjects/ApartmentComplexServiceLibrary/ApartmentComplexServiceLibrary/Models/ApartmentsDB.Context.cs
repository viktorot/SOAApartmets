﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApartmentComplexServiceLibraryV1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class apartma2Entities : DbContext
    {
        public apartma2Entities()
            : base("name=apartma2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<apartment> apartments { get; set; }
        public DbSet<arrangement_package> arrangement_package { get; set; }
        public DbSet<booking> bookings { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<discount> discounts { get; set; }
        public DbSet<payment_method> payment_method { get; set; }
        public DbSet<review> reviews { get; set; }
    }
}
