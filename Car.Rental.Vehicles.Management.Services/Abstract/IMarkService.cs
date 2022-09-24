using Car.Rental.Vehicles.Management.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.Management.Services.Abstract
{
    public interface IMarkService
    {
        Task<ReturnModel> AddMark(MarkModel model);
        Task<ReturnModel> GetMark(int id);
        Task<ReturnModel> UpdateMark(MarkModel model);
        Task<ReturnModel> DeleteMark(int id);
    }
}
