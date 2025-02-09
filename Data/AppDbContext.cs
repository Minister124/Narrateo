using Microsoft.AspNetCore.Connections;
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

    // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    // {
        //Another way to initialize Db.
        //The middleware would be different though
        //builder.Services.AddDbContext<AppDbContext>(options =>
        //options.UseNpgsql(builder.configuration.GetConnectionString()));
    // }

    // private readonly string connectionBuilder;
    // public AppDbContext(string connection)
    // {
    //     connectionBuilder = connection;
    //      Another way to initialize Db.
    //      Middleware might look like
    //      string connection = builder.Services.GetConnectionString();
    //      builder.Services.AddDbContext<AppDbContext>(options =>
    //      options.UseNpgsql(connection)));
    //      DbContext is just like the implemented one. just a little bit different.
    // }

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

