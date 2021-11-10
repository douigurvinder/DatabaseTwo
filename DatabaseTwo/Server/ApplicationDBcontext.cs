using DatabaseTwo.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTwo.Server
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext>options):base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ofline>().HasKey(x=>new { x.Id});
            modelBuilder.Entity<Online>().HasKey(x => new { x.Id });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Ofline> OflineSet { get; set; }
        public DbSet<Online> OnlineSet { get; set; }
    }
}
