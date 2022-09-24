using AutoMapper;
using Car.Rental.Vehicles.Management.Data.Repositories.Abstract;
using Car.Rental.Vehicles.Management.Domain.Entities;
using Car.Rental.Vehicles.Management.Services.Abstract;
using Car.Rental.Vehicles.Management.Services.FluentValidator;
using Car.Rental.Vehicles.Management.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.Management.Services.Concrete
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMarkRepository _markRepository;
        private readonly ICarModelRepository _carModelRepository;
        private readonly IMapper _mapper;
        public VehicleService(IVehicleRepository vehicleRepository, IMarkRepository markRepository, ICarModelRepository carModelRepository, IMapper mapper)
        {
            _mapper = mapper;
            _markRepository = markRepository;
            _carModelRepository = carModelRepository;
            _vehicleRepository = vehicleRepository;
        }

        public async Task<ReturnModel> AddVehicle(VehicleModel model)
        {
            var validator = new VehicleValidator().Validate(model);
            if (!validator.IsValid)
                return new ReturnModel { Errors = validator.Errors };

            var carModelExists = await _carModelRepository.GetById(model.ModelId);
            if(carModelExists == null)
                return new ReturnModel { Errors = "Car Model not found." };

            var markExists = await _markRepository.GetById(model.MarkId);
            if (markExists == null)
                return new ReturnModel { Errors = "Mark not found." };

            var vehicleExists = await _vehicleRepository.GetByPlate(model.LicensePlate);
            if(vehicleExists != null)
                return new ReturnModel { Errors = "License Plate is already used." };

            var entity = _mapper.Map<Vehicle>(model);

            await _vehicleRepository.Insert(entity);
            return new ReturnModel { Data = _mapper.Map<VehicleModel>(entity) };
        }

     

        public async Task<ReturnModel> GetVehicle(int id)
        {
            return new ReturnModel { Data = _mapper.Map<VehicleModel>(await _vehicleRepository.GetById(id)) };
        }

        public async Task<ReturnModel> UpdateVehicle(VehicleModel model)
        {
            var validator = new VehicleValidator().Validate(model);
            if (!validator.IsValid)
                return new ReturnModel { Errors = validator.Errors };

            var vehicleExists = await _vehicleRepository.GetById(model.Id);
            if (vehicleExists == null)
                return new ReturnModel { Errors = "Vehicle not found." };

            var carModelExists = await _carModelRepository.GetById(model.ModelId);
            if (carModelExists == null)
                return new ReturnModel { Errors = "Car Model not found." };

            var markExists = await _markRepository.GetById(model.MarkId);
            if (markExists == null)
                return new ReturnModel { Errors = "Mark not found." };

            var entity = _mapper.Map<Vehicle>(model);

            await _vehicleRepository.Update(entity);
            return new ReturnModel { Data = _mapper.Map<VehicleModel>(entity) };
        }

        public async Task<ReturnModel> DeleteVehicle(int id)
        {
            try
            {
                await _vehicleRepository.Delete(id);
            }
            catch (Exception ex)
            {

                return new ReturnModel { Errors = ex.Message };
            }

            return new ReturnModel { Data = "" };
        }
    }
}
