using Car.Rental.Vehicles.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Rental.Vehicles.Management.Domain.EntitiesMapping
{
    public class MarkMapping : IEntityTypeConfiguration<Mark>
    {
        public void Configure(EntityTypeBuilder<Mark> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .HasMaxLength(50)
                .IsRequired(true);                
        }
    }
}
