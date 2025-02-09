using Microsoft.EntityFrameworkCore;
using Narrateo.Models;

namespace Narrateo.Data;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Blog> Blogs {get; set;}
    public DbSet<Users> Users {get; set;}
    public DbSet<Roles> Roles {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Db"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
    }
}

