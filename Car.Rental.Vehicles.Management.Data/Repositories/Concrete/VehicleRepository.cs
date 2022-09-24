using Car.Rental.Vehicles.Management.Data.Repositories.Abstract;
using Car.Rental.Vehicles.Management.Domain.Context;
using Car.Rental.Vehicles.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Rental.Vehicles.Management.Data.Repositories.Concrete
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(VehicleContext context) : base(context)
        {

        }
    }
}
