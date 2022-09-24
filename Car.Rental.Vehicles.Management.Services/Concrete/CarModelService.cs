using AutoMapper;
using Car.Rental.Vehicles.Management.Data.Repositories.Abstract;
using Car.Rental.Vehicles.Management.Services.Abstract;
using Car.Rental.Vehicles.Management.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.Management.Services.Concrete
{
    public class CarModelService : ICarModelService
    {
        private readonly ICarModelRepository _carModelRepository;
        private readonly IMapper _mapper;
        public CarModelService(ICarModelRepository carModelRepository, IMapper mapper)
        {
            _carModelRepository = carModelRepository;
            _mapper = mapper;
        }


        public async Task<ReturnModel> AddModel(CarModel model)
        {
            var entity = _mapper.Map<Domain.Entities.Model>(model);
            await _carModelRepository.Insert(entity);
            return new ReturnModel { Data = _mapper.Map<CarModel>(entity) };
        }

        public async Task<ReturnModel> DeleteModel(int id)
        {
            try
            {
                await _carModelRepository.Delete(id);
            }
            catch (Exception ex)
            {
                return new ReturnModel { Errors = ex.Message };

            }

            return new ReturnModel { Data = "" };
        }

        public async Task<ReturnModel> GetModel(int id)
        {
            return new ReturnModel { Data = _mapper.Map<CarModel>(await _carModelRepository.GetById(id)) };
        }

        public async Task<ReturnModel> UpdateModel(CarModel model)
        {
            var oldEntity = await _carModelRepository.GetById(model.Id);
            if (oldEntity == null)
                return new ReturnModel { Errors = "Model not found" };

            oldEntity.Name = model.Name;
            await _carModelRepository.Update(oldEntity);

            return new ReturnModel { Data = _mapper.Map<CarModel>(oldEntity) };
        }
    }
}
