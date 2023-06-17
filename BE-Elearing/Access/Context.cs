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
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<CourseMix> CourseMixs { get; set; }
        public DbSet<ErrorReviewModel> ErrorReviewModels { get; set; }
        public DbSet<Learning> Learnings { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<MainType> MainTypes { get; set; }
        public DbSet<User> Users { get; set; }
    
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
            modelBuilder.Entity<Approval>().HasKey(m=> m.Id);
            modelBuilder.Entity<Chapter>().HasKey(m => m.Id);
            modelBuilder.Entity<Course>().HasKey(m => m.Id);
            modelBuilder.Entity<CourseMix>().HasKey(m => m.Id);
            modelBuilder.Entity<ErrorReviewModel>().HasKey(m => m.Id);
            modelBuilder.Entity<Learning>().HasKey(m => m.Id);
            modelBuilder.Entity<Lesson>().HasKey(m => m.Id);
            modelBuilder.Entity<MainType>().HasKey(m => m.Id);
            modelBuilder.Entity<Payment>().HasKey(m => m.Id);
            modelBuilder.Entity<Review>().HasKey(m => m.Id);
            modelBuilder.Entity<Role>().HasKey(m => m.Id);
            modelBuilder.Entity<Tag>().HasKey(m => m.Id);
            modelBuilder.Entity<User>().HasKey(m => m.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
