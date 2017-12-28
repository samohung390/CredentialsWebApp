using CredentialsWebApp.Models;
using CredentialsWebApp.Models.StartPoint;
//using CredentialsWebApp.Models.StartPoint;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CredentialsWebApp.Data
{
    public class StartPointContext : DbContext
    {
        public StartPointContext(DbContextOptions<StartPointContext> options) : base(options)
        {
        }

        public DbSet<CredAdmin> CredAdmins { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<CredAdminLink> CredAdminLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CredAdmin>().ToTable("CredAdmin");
            modelBuilder.Entity<Credential>().ToTable("Credential");
          

            modelBuilder.Entity<CredAdmin>().HasIndex(
                  e => new { e.CredAdminName }).IsUnique(true);

            modelBuilder.Entity<CredAdmin>().HasIndex(
                  e => new { e.CredAdminUN }).IsUnique(true);

            modelBuilder.Entity<Credential>().HasIndex(
                  e => new { e.CredentialAddress }).IsUnique(true);

        }

    }
}
