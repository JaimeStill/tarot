using Tarot.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tarot.Api.Controllers;

[Route("api/[controller]")]
public class ZodiacController : Controller
{
    [HttpGet("[action]")]
    public IActionResult Get() =>
        Ok(TarotZodiacs.Zodiacs);

    [HttpGet("[action]/{id:int}")]
    public IActionResult GetById([FromRoute]int id) =>
        Ok(TarotZodiacs.Zodiacs.Get(id));

    [HttpPost("[action]")]
    public IActionResult GetByElement([FromBody]TarotElement element) =>
        Ok(TarotZodiacs.GetByElement(element));

    [HttpPost("[action]")]
    public IActionResult GetByModality([FromBody]TarotModality modality) =>
        Ok(TarotZodiacs.GetByModality(modality));

    [HttpPost("[action]")]
    public IActionResult GetByRuler([FromBody]TarotPlanet ruler) =>
        Ok(TarotZodiacs.GetByRuler(ruler));
}