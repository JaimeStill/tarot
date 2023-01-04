using Tarot.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tarot.Api.Controllers;

[Route("api/[controller]")]
public class SuitController : Controller
{
    [HttpGet("[action]")]
    public IActionResult Get() =>
        Ok(TarotSuits.Suits);

    [HttpGet("[action]/{id:int}")]
    public IActionResult GetById([FromRoute]int id) =>
        Ok(TarotSuits.Suits.Get(id));

    [HttpPost("[action]")]
    public IActionResult GetByElement([FromBody]TarotElement element) =>
        Ok(TarotSuits.GetByElement(element));
}