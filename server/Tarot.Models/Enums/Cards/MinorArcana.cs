namespace Tarot.Models;

public static class MinorArcana
{
    public static List<MinorTarotCard> Cards => Cups.Cards
        .Concat(Pentacles.Cards)
        .Concat(Swords.Cards)
        .Concat(Wands.Cards)
        .ToList();

    public static IEnumerable<MinorTarotCard> GetBySuit(TarotSuit suit) =>
        Cards.Where(x => x.Suit.Id == suit.Id);
}