using GamesProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace GamesProject.Data
{
    public class ApplicationDbContextcs : DbContext
    {
        public ApplicationDbContextcs(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Games> Games { get; set; }
        public DbSet<Devices> Devices { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<GamesDevices> GamesDevices{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
           .HasData(new Categories[]
           {
                new Categories { Id = 1, Name = "Sports" },
                new Categories { Id = 2, Name = "Action" },
                new Categories { Id = 3, Name = "Adventure" },
                new Categories  { Id = 4, Name = "Racing" },
                new Categories { Id = 5, Name = "Fighting" },
                new Categories { Id = 6, Name = "Film" }
           });
            modelBuilder.Entity<Devices>()
           .HasData(new Devices[]
           {
                new Devices { Id = 1, Name = "PlayStation", Icon = "bi bi-playstation" },
                new Devices { Id = 2, Name = "xbox", Icon = "bi bi-xbox" },
                new Devices { Id = 3, Name = "Nintendo Switch", Icon = "bi bi-nintendo-switch" },
                new Devices { Id = 4, Name = "PC", Icon = "bi bi-pc-display" }
           });
            modelBuilder.Entity<GamesDevices>().HasKey(e => new { e.GameId, e.DeviceId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
