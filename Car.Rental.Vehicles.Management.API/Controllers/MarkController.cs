using Car.Rental.Vehicles.Management.Data.Repositories.Abstract;
using Car.Rental.Vehicles.Management.Services.Abstract;
using Car.Rental.Vehicles.Management.Services.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Rental.Vehicles.ManagementVehicles.Management.API.Controllers
{

    [ApiController]    
    [Route("[controller]")]
    public class MarkController : ControllerBase
    {
        private readonly IMarkService _markService;
        public MarkController(IMarkService markService)
        {
            _markService = markService;
        }

        [HttpPost]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> AddMark(MarkModel request)
        {
            var result = await _markService.AddMark(request);
            if (result.Errors != null)
                return BadRequest(result.Errors);

            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> GetMark(int id)
        {
            var result = await _markService.GetMark(id);
            return Ok(result.Data);
        }

        [HttpPut]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> UpdateMark(MarkModel request)
        {
            var result = await _markService.UpdateMark(request);
            if (result.Errors != null)
                return BadRequest(result.Errors);

            return Ok(result.Data);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Operator")]
        public async Task<ActionResult> DeleteMark(int id)
        {
            var result = await _markService.DeleteMark(id);
            if (result.Errors != null)
                return BadRequest(result.Errors);

            return Ok(result.Data);
        }
    }
}