using CityDigger.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CityDigger.WebApi.Database
{
    public class CitiesDbContext : DbContext
    {

        public DbSet<City> Cities { get; set; }

        public CitiesDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City() { CityID = Guid.Parse("A913776E-BAB2-477D-BD2D-1786C5FA31CA"), CityName = "London" });
            modelBuilder.Entity<City>().HasData(new City() { CityID = Guid.Parse("9B1A1644-EF4A-4B6F-94CF-E9233ABFB5E1"), CityName = "Sacramento" });

        }
    }
}
