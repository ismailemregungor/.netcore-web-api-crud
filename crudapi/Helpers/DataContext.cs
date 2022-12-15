using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace crudapi.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseInMemoryDatabase("TestDb");
        }


        public DbSet<User> Users { get; set; } = null!;
    }

}