using JwtAuthDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDemo.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
