using System;
using EcommerceData.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceData
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            :base(options)
        {
                
        }
        //entities
        public DbSet<User> Users { get; set; }
        public DbSet<Security> Securities { get; set; }

        public DbSet<Cars> Cars { get; set; }

        public DbSet<Role> Roles { get; set; }

        
    }
}
