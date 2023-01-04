using Tarot.Models;

List<TarotCard> tarot = TarotCard.Deck.Shuffle(6);
TarotCard past = tarot.Deal();
TarotCard present = tarot.Deal();
TarotCard future = tarot.Deal();

Console.WriteLine("Past:");
PrintTarotResult(past);
Console.WriteLine();

Console.WriteLine("Present:");
PrintTarotResult(present);
Console.WriteLine();

Console.WriteLine("Future:");
PrintTarotResult(future);

static void PrintTarotResult<T>(T card) where T : TarotCard
{
    Console.WriteLine($"Card: {card.Name}");
    Console.WriteLine($"Orientation: {(card.IsUpright ? "Upright" : "Reversed")}");

    if (card is MajorTarotCard major)
    {
        Console.WriteLine($"Element: {major.Element.Name}");
        Console.WriteLine($"{major.AstrologyType}: {major.Astrology.Name}"); 
    }
    else if (card is MinorTarotCard minor)
    {
        Console.WriteLine($"Element: {minor.Suit.Element.Name}");
        Console.WriteLine($"Zodiacs: {string.Join(", ", TarotZodiacs.GetByElement(minor.Suit.Element).Select(x => x.Name))}");
    }

    Console.WriteLine($"Keywords: {card.Keywords}");
    Console.WriteLine($"Image: {card.Image}");
    Console.WriteLine($"Link: {card.Link}");
}