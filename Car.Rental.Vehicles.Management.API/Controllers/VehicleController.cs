using Car.Rental.Vehicles.Management.Services.Abstract;
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
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;
        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
     

        [HttpPost]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> AddVehicle(VehicleModel model)
        {
            var result = await _vehicleService.AddVehicle(model);
            if (result.Errors != null)
                return BadRequest(result.Errors);

            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Operator, Client")]
        public async Task<ActionResult> GetVehicle(int id)
        {
            var result = await _vehicleService.GetVehicle(id);
            return Ok(result.Data);
        }

        [HttpPut]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> UpdateVehicle(VehicleModel model)
        {
            var result = await _vehicleService.UpdateVehicle(model);
            if (result.Errors != null)
                return BadRequest(result.Errors);

            return Ok(result.Data);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> DeleteVehicle(int id)
        {
            var result = await _vehicleService.DeleteVehicle(id);
            if (result.Errors != null)
                return BadRequest(result.Errors);

            return Ok(result.Data);
        }
    }
}
