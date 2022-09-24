using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Car.Rental.Vehicles.Management.Domain.Entities
{
    [Table("Vehicle")]
    public class Vehicle : Base
    {        
        public string LicensePlate { get; set; }            
        public int Year { get; set; }
        public decimal HourlyRate { get; set; }        
        public decimal TrunkCapacity { get; set; }
        public int MarkId { get; set; }
        public int ModelId { get; set; }
        public int FuelTypeId { get; set; }
        public int CategoryId { get; set; }
        public virtual Mark Mark { get; set; }        
        public virtual Model Model { get; set; }
        public virtual FuelType FuelType { get; set; }
        public virtual Category Category { get; set; }        
    }
}
