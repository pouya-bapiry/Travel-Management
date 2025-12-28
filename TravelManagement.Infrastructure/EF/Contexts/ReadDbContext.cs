using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Infrastructure.EF.Config;
using TravelManagement.Infrastructure.EF.Models;

namespace TravelManagement.Infrastructure.EF.Contexts
{
    internal sealed class ReadDbContext : DbContext
    {
        public DbSet<TravelerCheckListReadModel> TravelerCheckList { get; set; }



        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TravelerCheckList");

            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<TravelerCheckListReadModel>(configuration);
            modelBuilder.ApplyConfiguration<TravelerItemReadModel>(configuration);
        }
    }
}
