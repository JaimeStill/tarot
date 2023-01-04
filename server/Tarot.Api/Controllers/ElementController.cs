using Tarot.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tarot.Api.Controllers;

[Route("api/[controller]")]
public class ElementController : Controller
{
    [HttpGet("[action]")]
    public IActionResult Get() =>
        Ok(TarotElements.Elements);

    [HttpGet("[action]/{id:int}")]
    public IActionResult GetById([FromRoute]int id) =>
        Ok(TarotElements.Elements.Get(id));
}