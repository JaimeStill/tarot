namespace Tarot.Models;

public abstract class TarotCard : TarotBase, ICard
{
    public abstract string Name { get; }
    public string Type { get; }
    public string Image { get; }
    public string Link { get; }
    public string[] Upright { get; }
    public string[] Reversed { get; }
    public bool IsUpright { get; }

    public TarotCard(
        int id,
        string type,
        string image,
        string link,
        string[] upright,
        string[] reversed
    ) : base(id)
    {
        Upright = upright;
        Reversed = reversed;
        Type = type;
        Image = image;
        Link = link;

        IsUpright = new Random().Next() % 2 == 0;
    }

    public string Keywords => IsUpright
        ? string.Join(", ", Upright)
        : string.Join(", ", Reversed);

    public static List<TarotCard> Deck =>
        MajorArcana
            .Cards
            .Cast<TarotCard>()
            .Concat(
                MinorArcana
                    .Cards
                    .Cast<TarotCard>()
            )
            .ToList();
}

public class MinorTarotCard : TarotCard
{
    public int SuitId { get; }
    public int Value { get; }

    public MinorTarotCard(
        int id,
        int value,
        TarotSuit suit,
        string image,
        string link,
        string[] upright,
        string[] reversed
    ) : base(id, "Minor", image, link, upright, reversed)
    {
        Value = value;
        SuitId = suit.Id;
    }

    public TarotSuit Suit => TarotSuits.Suits.Get(SuitId);

    private string ValueName => Value switch
    {
        1 => "Ace",
        11 => "Page",
        12 => "Knight",
        13 => "Queen",
        14 => "King",
        _ => Value.ToString()
    };
    public override string Name =>
        $"{ValueName} of {Suit.Name}";
}

public class MajorTarotCard : TarotCard
{
    public override string Name { get; }
    public int AstrologyId { get; }
    public int ElementId { get; }
    public int Value { get; }
    public string AstrologyType { get; }

    public MajorTarotCard(
        string name,
        int value,
        TarotAstrology astrology,
        TarotElement element,
        string image,
        string link,
        string[] upright,
        string[] reversed
    ) : base(value, "Major", image, link, upright, reversed)
    {
        Name = name;
        Value = value;
        AstrologyId = astrology.Id;
        AstrologyType = astrology.Type;
        ElementId = element.Id;
    }

    public TarotAstrology Astrology => TarotAstrology.Get(AstrologyType, AstrologyId);
    public TarotElement Element => TarotElements.Elements.Get(ElementId);
}