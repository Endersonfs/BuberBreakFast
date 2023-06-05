using BuberBreakFast.Constracts.BreakFast;
using BuberBreakFast.Models;
using BuberBreakFast.Service.BreakFasts;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakFast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BreackFastController : ControllerBase
    {
        private readonly IBreakFastService _breakFastService;

        public BreackFastController(IBreakFastService breakFastService)
        {
            _breakFastService = breakFastService;
        }

        [HttpPost]
        public IActionResult CreateBreakFast(CreateBreakFastReuest request) 
         {
            var breakfast = new Breakfast(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet
                );

            _breakFastService.CreateBreakFast(breakfast);

            //TODO: Save breakfast
            var response = new BreackFastResponse(
                breakfast.Id,
                breakfast.Name,
                breakfast.Description,
                breakfast.StartDateTime,
                breakfast.EndDateTime,
                breakfast.LastModifiedDateTime,
                breakfast.Savory,
                breakfast.Sweet
                );

            return CreatedAtAction(
                actionName: nameof(GetBreakFast),
                routeValues: new {id = breakfast.Id },
                value : response
                );
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetBreakFast(Guid id)
        {
            Breakfast breakfast = _breakFastService.GetBreakfast(id);
            
            var response = new BreackFastResponse(
                breakfast.Id,
                breakfast.Name,
                breakfast.Description,
                breakfast.StartDateTime,
                breakfast.EndDateTime,
                breakfast.LastModifiedDateTime,
                breakfast.Savory,
                breakfast.Sweet
                );

            return Ok(response);
        }
        [HttpPut("{id:guid}")]
        public IActionResult UpsertBreakFast(Guid id, UpsertBrekFastRequest request) 
        {
            return Ok(request);
        }
        [HttpDelete("{id:guid}")]
        public IActionResult DeleteBreakFast(Guid id) 
        {
            return Ok(id);
        }
    }
}
