using Car.Rental.Vehicles.Management.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.Management.Services.Abstract
{
    public interface ICarModelService
    {
        Task<ReturnModel> AddModel(CarModel model);
        Task<ReturnModel> GetModel(int id);
        Task<ReturnModel> UpdateModel(CarModel model);
        Task<ReturnModel> DeleteModel(int id);
    }
}
