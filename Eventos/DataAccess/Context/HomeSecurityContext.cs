using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Context;

public class HomeSecurityContext : DbContext
{
    public HomeSecurityContext() { }
    public HomeSecurityContext(DbContextOptions options) : base(options) { }
    
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Session> Sessions { get; set; }
    public virtual DbSet<AssociatedDevice> AssociatedDevices { get; set; }
    public virtual DbSet<Authorization> Authorizations { get; set; }
    public virtual DbSet<Business> Businesses { get; set; }
    public virtual DbSet<Device> Devices { get; set; }
    public virtual DbSet<Home> Homes { get; set; }
    public virtual DbSet<Notification> Notifications { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

	}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
          if (!optionsBuilder.IsConfigured)
          {
              string directory = Directory.GetCurrentDirectory();

              IConfigurationRoot configuration = new ConfigurationBuilder()
                  .SetBasePath(directory)
                  .AddJsonFile("appsettings.json")
                  .Build();

              var connectionString = configuration.GetConnectionString(@"homeSecurityDb");

              optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("DataAccess"));
          }
    }
}