using BE_Elearing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using MySql.EntityFrameworkCore.Extensions;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Ubiety.Dns.Core;

namespace BE_Elearing.Access
{


public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddEntityFrameworkMySQL();
            new EntityFrameworkRelationalDesignServicesBuilder(serviceCollection)
                .TryAddCoreServices();
        }
    }
    public class Context : DbContext
    {
       
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        
        }

        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("sql");
            optionsBuilder.UseMySQL(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Course>().HasData(new Course
            {
                ID = 1,
                CourseTypeID = 1,

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
