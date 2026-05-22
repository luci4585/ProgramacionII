using Microsoft.EntityFrameworkCore;

internal class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public MyDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("PruebasLinqDb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Alice",   Age = 30 },
            new User { Id = 2, Name = "Bob",     Age = 17 },
            new User { Id = 3, Name = "Carlos",  Age = 25 },
            new User { Id = 4, Name = "Diana",   Age = 15 },
            new User { Id = 5, Name = "Eduardo", Age = 40 },
            new User { Id = 6, Name = "Fernanda", Age = 18 },
            new User { Id = 7, Name = "Gabriel", Age = 22 }
        );
    }
}
