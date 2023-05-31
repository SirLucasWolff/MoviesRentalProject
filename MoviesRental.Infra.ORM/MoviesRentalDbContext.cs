using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesRental.Domain.ClientModule;
using MoviesRental.Domain.EmployeeModule;
using MoviesRental.Domain.MovieModule;
using MoviesRental.Domain.RentModule;
using MoviesRental.Domain.Shared;
using System.Net;

namespace MoviesRental.Infra.ORM
{
    public class MoviesRentalDbContext: DbContext
    {
        private static readonly ILoggerFactory ConsoleLoggerFactory
              = LoggerFactory.Create(builder =>
              {
                  builder
                      .AddFilter((category, level) =>
                          category == DbLoggerCategory.Database.Command.Name
                          && level == LogLevel.Information)
                      .AddDebug();
              });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string? databaseType;

            if (FrameworkConfiguration.FrameworkTypeRead() == "SQLServer")
                databaseType = "DB";
            else
                databaseType = "EF";

            string? host;

            try
            {
                optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory).UseSqlServer($@"Data Source={host = Dns.GetHostName()}\SQLEXPRESS;Initial Catalog=MoviesRental{databaseType};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MoviesRentalDbContext).Assembly);
        }

        public DbSet<Client> ClientDB { set; get; }
        public DbSet<Employee> EmployeeDB { set; get; }
        public DbSet<Movie> MovieDB { set; get; }
        public DbSet<Rent> RentDB { set; get; }
    }
}