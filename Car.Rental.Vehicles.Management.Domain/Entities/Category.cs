using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Car.Rental.Vehicles.Management.Domain.Entities
{
    [Table("Category")]
    public class Category : Base
    {        
        public string Name { get; set; }

        public List<Vehicle> Vehicle { get; set; }
    }
    
}
