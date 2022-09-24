using AutoMapper;
using Car.Rental.Vehicles.Management.Data.Repositories.Abstract;
using Car.Rental.Vehicles.Management.Domain.Entities;
using Car.Rental.Vehicles.Management.Services.Abstract;
using Car.Rental.Vehicles.Management.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.Management.Services.Concrete
{
    public class MarkService : IMarkService
    {
        private readonly IMarkRepository _markRepository;
        private readonly IMapper _mapper;
        public MarkService(IMarkRepository markRepository, IMapper mapper)
        {
            _markRepository = markRepository;
            _mapper = mapper;
        }

        public async Task<ReturnModel> AddMark(MarkModel model)
        {
            var entity = _mapper.Map<Mark>(model);
            await _markRepository.Insert(entity);
            return new ReturnModel { Data = _mapper.Map<MarkModel>(entity) };
        }

        public async Task<ReturnModel> DeletMark(int id)
        {
            try
            {
                await _markRepository.Delete(id);
            }
            catch (Exception ex)
            {
                return new ReturnModel { Errors = ex.Message };

            }            

            return new ReturnModel { Data = "" };
        }

        public async Task<ReturnModel> GetMark(int id)
        {
            return new ReturnModel { Data = _mapper.Map<MarkModel>(await _markRepository.GetById(id)) };
        }

        public async Task<ReturnModel> UpdateMark(MarkModel model)
        {
            var oldEntity = await _markRepository.GetById(model.Id);
            if(oldEntity == null)
                return new ReturnModel { Errors = "Mark not found" };

            oldEntity.Name = model.Name;
            await _markRepository.Update(oldEntity);

            return new ReturnModel { Data = _mapper.Map<MarkModel>(oldEntity) };
        }
    }
}
