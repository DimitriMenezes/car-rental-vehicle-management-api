using Car.Rental.Vehicles.Management.Services.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.ManagementAPI.Controllers
{
    [ApiController]
    [Authorize(Roles = "Operator")]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        
        public VehicleController()
        {
            
        }

        [HttpPost]        
        public async Task<ActionResult> AddVehicle()
        {
            return Ok();
        }        
    }
}
