using Car.Rental.Vehicles.Management.Services.Abstract;
using Car.Rental.Vehicles.Management.Services.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.Management.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarkController : ControllerBase
    {
        private readonly ICarModelService _carModelService;
        public MarkController(ICarModelService carModelService)
        {
            _carModelService = carModelService;
        }

        [HttpPost]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> AddModel(CarModel request)
        {
            var result = await _carModelService.AddModel(request);
            if (result.Errors != null)
                return BadRequest(result.Errors);

            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> GetModel(int id)
        {
            var result = await _carModelService.GetModel(id);
            return Ok(result.Data);
        }

        [HttpPut]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> UpdateModel(CarModel request)
        {
            var result = await _carModelService.UpdateModel(request);
            if (result.Errors != null)
                return BadRequest(result.Errors);

            return Ok(result.Data);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> DeleteModel(int id)
        {
            var result = await _carModelService.DeleteModel(id);
            if (result.Errors != null)
                return BadRequest(result.Errors);

            return Ok(result.Data);
        }
    }
}
