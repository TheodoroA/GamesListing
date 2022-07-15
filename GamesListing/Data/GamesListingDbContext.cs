using Microsoft.EntityFrameworkCore;

namespace GamesListing.Data
{
    public class GamesListingDbContext : DbContext
    {
        public GamesListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "Bayonetta",
                    Rating = 8.9F
                },
                new Game
                {
                    Id = 2,
                    Name = "Devil May Cry 5: Special Edition",
                    Rating = 8.4F
                },
                new Game
                {
                    Id = 3,
                    Name = "Tales of Arise",
                    Rating = 8.7F
                });
            
            modelBuilder.Entity<Store>().HasData(
                new Store
                {
                    Id = 1,
                    Name = "Steam",
                    Address = "https://store.steampowered.com/",
                },
                new Store
                {
                    Id = 2,
                    Name = "Origin",
                    Address = "https://www.origin.com/en-us/store/",
                },
                new Store
                {
                    Id = 3,
                    Name = "Uplay",
                    Address = "https://www.uplay.com/en-us/",
                },
                new Store
                {
                    Id = 4,
                    Name = "Epic Games Store",
                    Address = "https://store.epicgames.com/en-US/",
                },
                new Store
                {
                    Id = 5,
                    Name = "Xbox",
                    Address = "https://www.xbox.com/pt-BR/games/all-games",
                });
        }
    }
}

