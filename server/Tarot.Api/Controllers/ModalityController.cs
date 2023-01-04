using Tarot.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tarot.Api.Controllers;

[Route("api/[controller]")]
public class ModalityController : Controller
{
    [HttpGet("[action]")]
    public IActionResult Get() =>
        Ok(TarotModalities.Modalities);

    [HttpGet("[action]/{id:int}")]
    public IActionResult GetById([FromRoute]int id) =>
        Ok(TarotModalities.Modalities.Get(id));
}