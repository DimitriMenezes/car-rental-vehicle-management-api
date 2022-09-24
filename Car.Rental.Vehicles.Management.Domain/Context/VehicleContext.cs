using Microsoft.EntityFrameworkCore;

namespace Car.Rental.Vehicles.Management.Domain.Context
{
    public partial class VehicleContext : DbContext
    {     

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
            
        }
    }
}
