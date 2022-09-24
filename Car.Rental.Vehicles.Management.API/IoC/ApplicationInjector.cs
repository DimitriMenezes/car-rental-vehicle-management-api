﻿using Car.Rental.Vehicles.Management.Data.IoC;
using Car.Rental.Vehicles.Management.Services.IoC;
using Car.Rental.Vehicles.Management.Services.Settings;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Car.Rental.Vehicles.Management.API.IoC
{
    public static class ApplicationInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {           
            RepositoriesInjector.RegisterServices(services);
            ServicesInjector.RegisterServices(services);


            var key = Encoding.ASCII.GetBytes(SecuritySettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

        }
    }
}
