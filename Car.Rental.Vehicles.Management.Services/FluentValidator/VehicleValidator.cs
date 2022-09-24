using Car.Rental.Vehicles.Management.Services.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Rental.Vehicles.Management.Services.FluentValidator
{
    public class VehicleValidator : AbstractValidator<VehicleModel>
    {
        public VehicleValidator()
        {
            RuleFor(x => x.HourlyRate)
               .NotNull().WithMessage("HourlyRate is mandatory.");
            RuleFor(x => x.LicensePlate)
                .NotEmpty().WithMessage("License Plate is mandatory.");
            RuleFor(x => x.TrunkCapacity)
                .NotNull().WithMessage("Trunk Capacity is mandatory.");
            RuleFor(x => x.Year)
                .NotNull().WithMessage("Year is mandatory.");
            RuleFor(x => x.FuelTypeId)
                .NotNull().WithMessage("Fuel Type is mandatory.");
            RuleFor(x => x.CategoryId)
                .NotNull().WithMessage("Category is mandatory.");
            RuleFor(x => x.MarkId)
               .NotNull().WithMessage("Mark is mandatory.");
            RuleFor(x => x.ModelId)
               .NotNull().WithMessage("Model is mandatory.");
        }
    }
}
