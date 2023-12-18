using CardService.api.v1.models;

namespace CardService.api.v1.Database;

using Microsoft.EntityFrameworkCore;

public class CardContext : DbContext
{
    public DbSet<card> Cards { get; set; }
    public CardContext(DbContextOptions<CardContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
                "SERVER = 127.0.0.1; PORT = 3306; DATABASE = card_service; USER = root;",
                new MySqlServerVersion(new Version(8,0,25))
            );
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<card>().HasKey(x => x.id);
        modelBuilder.Entity<card>().ToTable("Cards");
    }
    // это потом
}