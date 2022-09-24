using Car.Rental.Vehicles.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Rental.Vehicles.Management.Domain.EntitiesMapping
{
    public class FuelTypeMapping : IEntityTypeConfiguration<FuelType>
    {
        public void Configure(EntityTypeBuilder<FuelType> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .IsRequired(true)
                .HasMaxLength(20);                         
        }
    }
}
