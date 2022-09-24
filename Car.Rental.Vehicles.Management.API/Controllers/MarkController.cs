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
    [Authorize(Roles = "Operator")]
    [Route("[controller]")]
    public class MarkController : ControllerBase
    {

        public MarkController()
        {

        }

        [HttpPost]
        public async Task<ActionResult> AddMark()
        {
            return Ok();
        }
    }
}