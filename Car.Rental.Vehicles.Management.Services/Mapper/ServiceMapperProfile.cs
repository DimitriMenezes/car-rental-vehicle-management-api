using AutoMapper;
using Car.Rental.Vehicles.Management.Domain.Entities;
using Car.Rental.Vehicles.Management.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Rental.Vehicles.Management.Services.Mapper
{
    public class ServicesMapperProfile : Profile
    {
        public ServicesMapperProfile()
        {
            CreateMap<MarkModel, Mark>()
                .ReverseMap();
            CreateMap<CarModel, Domain.Entities.Model>()
               .ReverseMap();
            CreateMap<VehicleModel, Vehicle>()
               .ReverseMap();
        }
    }
}
