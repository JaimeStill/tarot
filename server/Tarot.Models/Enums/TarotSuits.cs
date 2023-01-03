namespace Tarot.Models;

public static class TarotSuits
{
    public static List<TarotSuit> Suits => new()
    {
        Cups,
        Pentacles,
        Swords,
        Wands
    };

    public static TarotSuit GetByElement(TarotElement element) =>
        Suits.First(x => x.ElementId == element.Id);

    public static TarotSuit Cups => new(
        1,
        "Cups",
        TarotElements.Water
    );
    
    public static TarotSuit Pentacles => new(
        2,
        "Pentacles",
        TarotElements.Earth
    );

    public static TarotSuit Swords => new(
        3,
        "Swords",
        TarotElements.Air
    );

    public static TarotSuit Wands => new(
        4,
        "Wands",
        TarotElements.Fire
    );
}