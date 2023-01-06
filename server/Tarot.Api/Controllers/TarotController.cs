using Tarot.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tarot.Api.Controllers;

[Route("api/[controller]")]
public class TarotController : Controller
{
    [HttpGet("[action]")]
    public IActionResult Get() =>
        Ok(TarotCard.Deck);

    [HttpGet("[action]")]
    public IActionResult GetShuffled([FromQuery]uint? shuffles) =>
        Ok(TarotCard.Deck.Shuffle(shuffles ?? 0));

    [HttpGet("[action]")]
    public IActionResult GetMajorArcana() =>
        Ok(MajorArcana.Cards);

    [HttpGet("[action]")]
    public IActionResult GetMinorArcana() =>
        Ok(MinorArcana.Cards);

    [HttpGet("[action]")]
    public IActionResult GetCups() =>
        Ok(Cups.Cards);

    [HttpGet("[action]")]
    public IActionResult GetPentacles() =>
        Ok(Pentacles.Cards);

    [HttpGet("[action]")]
    public IActionResult GetSwords() =>
        Ok(Swords.Cards);

    [HttpGet("[action]")]
    public IActionResult GetWands() =>
        Ok(Wands.Cards);

    [HttpGet("[action]/{id:int}")]
    public ActionResult<MajorTarotCard> GetMajorCard([FromRoute]int id) =>
        Ok(MajorArcana.Cards.Get(id));

    [HttpGet("[action]/{name}")]
    public ActionResult<MajorTarotCard> GetMajorByName([FromRoute]string name) =>
        Ok(MajorArcana.Cards.Get(name));

    [HttpGet("[action]/{id:int}")]
    public ActionResult<MinorTarotCard> GetMinorCard([FromRoute]int id) =>
        Ok(MinorArcana.Cards.Get(id));

    [HttpGet("[action]/{name}")]
    public ActionResult<MinorTarotCard> GetMinorByName([FromRoute]string name) =>
        Ok(MinorArcana.Cards.Get(name));

    [HttpPost("[action]")]
    public IActionResult GetBySuit([FromBody]TarotSuit suit) =>
        Ok(MinorArcana.GetBySuit(suit));
}
