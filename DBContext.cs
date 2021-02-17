using System;
using System.Collections.Generic;
using System.Data.Entity;
using _11_02_21_prb.DBEntities;

namespace _11_02_21_prb
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Service> Services { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasIndex(p => p.Guid).IsUnique();
        }
    }
}
