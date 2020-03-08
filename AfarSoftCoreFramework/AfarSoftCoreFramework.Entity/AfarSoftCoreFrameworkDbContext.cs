using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AfarSoftCoreFramework.Entity
{
    public class AfarSoftCoreFrameworkDbContext : DbContext
    {
        public AfarSoftCoreFrameworkDbContext(DbContextOptions<AfarSoftCoreFrameworkDbContext> options) : base(options)
        {

        }
        public DbSet<Class1> UserExtend { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
