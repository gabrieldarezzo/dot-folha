using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }


    public string DbPath { get; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
           IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        if(bool.Parse(Environment.GetEnvironmentVariable("DOCKER_MODE"))) {
            string connectionString = configuration.GetConnectionString("DockerConnection");
            optionsBuilder.UseMySQL(connectionString);
        } else {
            string connectionString = configuration.GetConnectionString("Default");
            optionsBuilder.UseMySQL(connectionString);            
        }
    }    
}