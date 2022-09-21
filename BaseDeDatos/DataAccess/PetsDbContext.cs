using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos.DataAccess;
public class PetsDbContext : DbContext
{
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Breed> Breeds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Pets");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Breed>()
            .HasData(
                new Breed() { Id = 1, Name = "Beagle" },
                new Breed() { Id = 2, Name = "Pitbull" },
                new Breed() { Id = 3, Name = "Chihuahua" }
                    );

        modelBuilder
            .Entity<Pet>()
            .HasData(
                new Pet() { Id = 1, BreedId = 1, Name = "Gianni", Age = 10 },
                new Pet() { Id = 2, BreedId = 2, Name = "Cati", Age = 8 }
            );
    }
}
