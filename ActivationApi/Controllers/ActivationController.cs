using ActivationApi.Models;
using ActivationApi.Models.Repos;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ActivationApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivationController : Controller
    {
        DeviceRepo repo;
        public ActivationController()
        {
            repo = new DeviceRepo();
        }
        [HttpPost]
        public IActionResult AddDevice(Device device)
        {
            var context = new ValidationContext(device);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(device, context, results, true))
                return StatusCode(400,  context.Items.First().Value); ;
            repo.Add(device);
            return StatusCode(200);
        }
        [HttpGet]
        public IEnumerable<Device> Get() => repo.Get();
    }
}
