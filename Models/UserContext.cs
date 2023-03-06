using Microsoft.EntityFrameworkCore;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }


    public string DbPath { get; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseMySQL("Server=localhost;DataBase=homestead;Uid=root;Pwd=root");
}