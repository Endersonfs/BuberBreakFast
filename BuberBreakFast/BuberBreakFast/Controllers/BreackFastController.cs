using BuberBreakFast.Constracts.BreakFast;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakFast.Controllers
{
    [ApiController]
    public class BreackFastController : ControllerBase
    {
        [HttpPost("/brekfasts")]
        public IActionResult CreateBreakFast(CreateBreakFastReuest request) 
        {
            return Ok(request);
        }
        [HttpGet("/breakfasts/{id:guid}")]
        public IActionResult GetBreakFast(Guid id)
        {
            return Ok(id);
        }
    }
}
