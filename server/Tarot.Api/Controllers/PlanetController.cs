using Tarot.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tarot.Api.Controllers;

[Route("api/[controller]")]
public class PlanetController : Controller
{
    [HttpGet("[action]")]
    public IActionResult Get() =>
        Ok(TarotPlanets.Planets);

    [HttpGet("[action]/{id:int}")]
    public IActionResult GetById([FromRoute]int id) =>
        Ok(TarotPlanets.Planets.Get(id));
}