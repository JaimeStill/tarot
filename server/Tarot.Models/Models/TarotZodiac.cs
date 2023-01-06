namespace Tarot.Models;

public class TarotZodiac : TarotAstrology
{
    private readonly DateOnly StartDate;
    private readonly DateOnly EndDate;
    public int ElementId { get; }
    public int ModalityId { get; }
    public int RulerId { get; }
    public override string Name { get; }
    public string Dates => $"{StartDate:MMM dd} - {EndDate:MMM dd}";
    public string[] PositiveTraits { get; set; }
    public string[] NegativeTraits { get; set; }

    public TarotZodiac(
        int id,
        string name,
        DateOnly startDate,
        DateOnly endDate,
        TarotElement element,
        TarotModality modality,
        TarotPlanet ruler,
        string[] positiveTraits,
        string[] negativeTraits
    ) : base(id, "Zodiac")
    {
        Name = name;
        StartDate = startDate;
        EndDate = endDate;
        ElementId = element.Id;
        ModalityId = modality.Id;
        RulerId = ruler.Id;
        PositiveTraits = positiveTraits;
        NegativeTraits = negativeTraits;
    }

    public TarotElement Element => TarotElements.Elements.Get(ElementId);
    public TarotModality Modality => TarotModalities.Modalities.Get(ModalityId);
    public TarotPlanet Ruler => TarotPlanets.Planets.Get(RulerId);

    public override string[] Keywords =>
        PositiveTraits
            .Concat(NegativeTraits)
            .ToArray();
}
