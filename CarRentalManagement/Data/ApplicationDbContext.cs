using CarRentalManagement.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CarRentalManagement.Data.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<CarRentalManagement.Data.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement.Data.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement.Data.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement.Data.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement.Data.Domain.Make> Make { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
