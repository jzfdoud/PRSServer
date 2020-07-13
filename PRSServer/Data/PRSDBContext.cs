using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
