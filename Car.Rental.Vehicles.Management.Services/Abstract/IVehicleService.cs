using Car.Rental.Vehicles.Management.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.Management.Services.Abstract
{
    public interface IVehicleService
    {
        Task<ReturnModel> AddVehicle(VehicleModel model);
        Task<ReturnModel> GetVehicle(int id);
        Task<ReturnModel> UpdateVehicle(VehicleModel model);
        Task<ReturnModel> DeleteVehicle(int id);
    }
}
