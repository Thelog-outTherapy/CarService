using Microsoft.EntityFrameworkCore;
using Models.DAL.Models;

namespace DataBase;

public class DatabaseConnectionContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=Users.db");
    }
}