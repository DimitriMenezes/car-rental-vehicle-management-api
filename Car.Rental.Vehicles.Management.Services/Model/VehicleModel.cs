using Car.Rental.Vehicles.Management.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Rental.Vehicles.Management.Services.Model
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public int Year { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TrunkCapacity { get; set; }      
        public int MarkId { get; set; }
        public int ModelId { get; set; }
        public FuelType FuelTypeId { get; set; }
        public Category CategoryId { get; set; }
    }
}
