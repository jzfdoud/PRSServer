using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRSServer;
using PRSServer.Models;

namespace PRSServer.Data
{
    public class PRSDBContext : DbContext
    {
        public PRSDBContext (DbContextOptions<PRSDBContext> options)
            : base(options)
        {
        }

        public PRSDBContext()
        {

        }


        public DbSet<PRSServer.User> User { get; set; }

        public DbSet<PRSServer.Models.Product> Product { get; set; }

        public DbSet<PRSServer.Models.Request> Request { get; set; }

        public DbSet<PRSServer.Vendor> Vendor { get; set; }

        public DbSet<PRSServer.Models.RequestLine> RequestLine { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(x => x.HasIndex("UserName").IsUnique()); 
            builder.Entity<Vendor>(v => v.HasIndex("Code").IsUnique()); 
            builder.Entity<Product>(p => p.HasIndex("PartNbr").IsUnique());
        }
    }
}
