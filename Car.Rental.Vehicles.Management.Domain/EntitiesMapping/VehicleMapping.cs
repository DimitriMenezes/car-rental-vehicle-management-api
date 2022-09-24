using Car.Rental.Vehicles.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Rental.Vehicles.Management.Domain.EntitiesMapping
{
    public class VehicleMapping : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.LicensePlate)
               .HasMaxLength(12)
               .IsRequired(true);
            builder.Property(i => i.HourlyRate)               
               .IsRequired(true);
            builder.Property(i => i.TrunkCapacity)               
               .IsRequired(true);
            builder.Property(i => i.Year)               
               .IsRequired(true);

            builder.HasOne(i => i.Model);
            builder.HasOne(i => i.Mark);
            builder.HasOne(i => i.Category);
            builder.HasOne(i => i.FuelType);
        }
    }
}
