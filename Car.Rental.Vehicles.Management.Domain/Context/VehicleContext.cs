using Car.Rental.Vehicles.Management.Domain.Entities;
using Car.Rental.Vehicles.Management.Domain.EntitiesMapping;
using Microsoft.EntityFrameworkCore;

namespace Car.Rental.Vehicles.Management.Domain.Context
{
    public partial class VehicleContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<FuelType> FuelType { get; set; }
        public DbSet<Mark> Mark { get; set; }
        public DbSet<Model> VehicleModel { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        public VehicleContext()
        {
        }
        public VehicleContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("vehicle");
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new FuelTypeMapping());
            modelBuilder.ApplyConfiguration(new MarkMapping());
            modelBuilder.ApplyConfiguration(new ModelMapping());
            modelBuilder.ApplyConfiguration(new VehicleMapping());
        }
    }
}
