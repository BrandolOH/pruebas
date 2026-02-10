using Microsoft.EntityFrameworkCore;

namespace HelloWorldApiv2.Models;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
