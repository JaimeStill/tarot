namespace Tarot.Models;

public class TarotElement : TarotBase
{
    public string Name { get; set; }
    public TarotPolarity Polarity { get; }
    public string[] Keywords { get; }

    public TarotElement(
        int id,
        string name,
        TarotPolarity polarity,
        params string[] keywords
    ) : base(id)
    {
        Name = name;
        Polarity = polarity;
        Keywords = keywords;
    }

    public TarotSuit Suit => TarotSuits.GetByElement(this);

    public IEnumerable<MajorTarotCard> Cards => MajorArcana.GetByElement(this);
    public IEnumerable<TarotZodiac> Zodiacs => TarotZodiacs.GetByElement(this);
}