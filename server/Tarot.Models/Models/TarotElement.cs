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
}