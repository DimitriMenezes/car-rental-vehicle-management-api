using AutoMapper;
using Car.Rental.Vehicles.Management.Services.Abstract;
using Car.Rental.Vehicles.Management.Services.Concrete;
using Car.Rental.Vehicles.Management.Services.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Rental.Vehicles.Management.Services.IoC
{
    public static class ServicesInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ServicesMapperProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<ICarModelService, CarModelService>();
            services.AddScoped<IMarkService, MarkService>();
        }
    }
}
