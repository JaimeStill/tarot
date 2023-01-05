namespace Tarot.Models;

public abstract class TarotCard : TarotBase, ICard
{
    public abstract string Name { get; }
    public abstract string Image { get; }
    public string Type { get; }
    public string Link { get; }
    public string[] Upright { get; }
    public string[] Reversed { get; }
    public bool IsUpright { get; }

    public TarotCard(
        int id,
        string type,
        string link,
        string[] upright,
        string[] reversed
    ) : base(id)
    {
        Upright = upright;
        Reversed = reversed;
        Type = type;
        Link = link;

        IsUpright = new Random().Next() % 2 == 0;
    }

    protected static string ImageUrl(string suit, int value) =>
        $"https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/{suit}-{value}.jpg";

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

public class MajorTarotCard : TarotCard
{
    public override string Name { get; }
    public override string Image { get; }
    public int AstrologyId { get; }
    public int ElementId { get; }
    public int Value { get; }
    public string AstrologyType { get; }

    public MajorTarotCard(
        string name,
        int value,
        TarotAstrology astrology,
        TarotElement element,
        string link,
        string[] upright,
        string[] reversed
    ) : base(value, "Major", link, upright, reversed)
    {
        Name = name;
        Value = value;
        AstrologyId = astrology.Id;
        AstrologyType = astrology.Type;
        ElementId = element.Id;
        Image = ImageUrl("major", value);
    }

    public TarotAstrology Astrology => TarotAstrology.Get(AstrologyType, AstrologyId);
    public TarotElement Element => TarotElements.Elements.Get(ElementId);
}

public class MinorTarotCard : TarotCard
{
    public int SuitId { get; }
    public int Value { get; }
    public override string Image { get; }

    public MinorTarotCard(
        int id,
        int value,
        TarotSuit suit,
        string link,
        string[] upright,
        string[] reversed
    ) : base(id, "Minor", link, upright, reversed)
    {
        Value = value;
        SuitId = suit.Id;
        Image = ImageUrl(suit.Name.ToLower(), value);
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