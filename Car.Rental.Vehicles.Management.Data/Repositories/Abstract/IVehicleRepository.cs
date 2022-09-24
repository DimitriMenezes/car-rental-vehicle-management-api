using Car.Rental.Vehicles.Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.Management.Data.Repositories.Abstract
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {
        Task<Vehicle> GetByPlate(string plate);
    }
}
