using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Survivor.Models;

namespace Survivor.Data
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Competitiors> Competitiors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Competitiors) // Her kategori birden fazla yarışmacıya sahip olabilir.
                .WithOne(c => c.Category) // Yarışmacılar sadece bir kategoriye ait olabilir.
                .HasForeignKey(c => c.CategoryId); // Yarışmacılar kategoriye ait olmalıdır.

            modelBuilder.Entity<Category>().HasData(
     new Category { Id = 1, Name = "Ünlüler" },
     new Category { Id = 2, Name = "Gönüllüler" }
 );


            modelBuilder.Entity<Competitiors>().HasData(
        new Competitiors { Id = 1, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 1 },
        new Competitiors { Id = 2, FirstName = "Ayşe", LastName = "Kaya", CategoryId = 2 },
        new Competitiors { Id = 3, FirstName = "Mehmet", LastName = "Demir", CategoryId = 1 },
        new Competitiors { Id = 4, FirstName = "Fatma", LastName = "Çelik", CategoryId = 2 }
    );
            base.OnModelCreating(modelBuilder);
        }

    }
}

