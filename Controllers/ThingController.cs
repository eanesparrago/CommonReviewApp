using CommonReviewApp.Interface;
using CommonReviewApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ThingController : Controller
{
    private readonly IThingRepository _thingRepository;

    public ThingController(IThingRepository thingRepository)
    {
        _thingRepository = thingRepository;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Thing>))]
    public IActionResult GetThings()
    {
        var things =  _thingRepository.GetThings();

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(things);
    }
}
