using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConsumerWebApp.Controllers
{
    [ApiController]
    [Route("Status")]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}