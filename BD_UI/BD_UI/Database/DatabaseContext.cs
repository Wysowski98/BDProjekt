using BD_UI.Database.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

namespace BD_UI.Database
{
    public class DatabaseContext: DbContext
    {
        public DbSet<CarBrands> CarBrands { get; set; }

        public DbSet<Cars> Cars { get; set; }

        public DbSet<CarShowrooms> CarShowrooms { get; set; }

        public DbSet<Clients> Clients { get; set; }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<Jobs> Jobs { get; set; }

        public DbSet<Models> Models { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=BDProject;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarBrands>().HasMany(e => e.Models);
            modelBuilder.Entity<Cars>().HasOne(x => x.Model);
            modelBuilder.Entity<Cars>().HasOne(x => x.CarShowroom);
            modelBuilder.Entity<CarShowrooms>().HasMany(e => e.Employees);
            modelBuilder.Entity<CarShowrooms>().HasMany(e => e.Cars);
            modelBuilder.Entity<Clients>().HasMany(x => x.Orders);
            modelBuilder.Entity<Employees>().HasOne(x => x.CarShowroom);
            modelBuilder.Entity<Employees>().HasOne(x => x.Job);
            modelBuilder.Entity<Employees>().HasMany(x => x.Orders);
            modelBuilder.Entity<Models>().HasOne(x => x.Brand);
            modelBuilder.Entity<Orders>().HasOne(x => x.Employee);
            modelBuilder.Entity<Orders>().HasOne(x => x.Client);
            modelBuilder.Entity<Orders>().HasOne(x => x.Car);
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=BDProject;Trusted_Connection=True;MultipleActiveResultSets=true";
            builder.UseSqlServer(connectionString);
            return new DatabaseContext(builder.Options);
        }

        public DatabaseContext CreateDbContext()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=BDProject;Trusted_Connection=True;MultipleActiveResultSets=true";
            builder.UseSqlServer(connectionString);
            return new DatabaseContext(builder.Options);
        }
    }
}
