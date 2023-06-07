using CoreAPI1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var pi = new ParkingInfo();
            var result = pi.GetParkings();
            return Ok(result);
        }
    }
}
