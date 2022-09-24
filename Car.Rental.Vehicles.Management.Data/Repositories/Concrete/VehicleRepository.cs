using Car.Rental.Vehicles.Management.Data.Repositories.Abstract;
using Car.Rental.Vehicles.Management.Domain.Context;
using Car.Rental.Vehicles.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.Management.Data.Repositories.Concrete
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(VehicleContext context) : base(context)
        {

        }

        public async Task<Vehicle> GetByPlate(string plate)
        {
            return await _dbSet.FirstOrDefaultAsync(i => i.LicensePlate == plate);
        }
    }
}
