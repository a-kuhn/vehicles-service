using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mitchell_Vehicles.Services;


namespace Mitchell_Vehicles.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {

        private IVehicleService _service;


        public VehicleController(IVehicleService service)
        {
            _service = service;

        }

        [HttpGet("/vehicles")]
        public ActionResult<List<Vehicle>> GetVehicles()
        {
            return _service.GetVehicles();
        }

        [HttpGet("/vehicles/{id:int}")]
        public ActionResult<Vehicle> GetVehicleById(int id)
        {
            return _service.GetVehicleById(id);
        }

        [HttpPost("/vehicles")]
        public ActionResult<Vehicle> AddVehicle(Vehicle vehicle)
        {
            _service.AddVehicle(vehicle);
            return vehicle;
        }

        [HttpPut("/vehicles/{id}")]
        public ActionResult<Vehicle> UpdateVehicle(int id, Vehicle product)
        {
            _service.UpdateVehicle(id, product);
            return product;
        }

        [HttpDelete("/vehicles/{id}")]
        public ActionResult<int> DeleteVehicle(int id)
        {
            _service.DeleteVehicle(id);
            return id;
        }
    }
}