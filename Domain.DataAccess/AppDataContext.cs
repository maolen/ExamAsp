using Domain.Model;

using Microsoft.EntityFrameworkCore;

using System;

namespace Domain.DataAccess
{
    public class AppDataContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }

        public AppDataContext()
        {
        }

        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=ExamAppDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
