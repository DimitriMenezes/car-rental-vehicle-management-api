using Car.Rental.Vehicles.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car.Rental.Vehicles.Management.Domain.EntitiesMapping
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(i => i.Name)
                .HasMaxLength(20)
                .IsRequired(true);
        }
    }
}
