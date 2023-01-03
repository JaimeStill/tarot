namespace Tarot.Models;

public static class TarotElements
{
    public static List<TarotElement> Elements => new()
    {
        Air,
        Earth,
        Fire,
        Water
    };

    public static TarotElement Air => new(
        1,
        "Air",
        TarotPolarity.Active,
        "Logic", "Ideas", "Intellect", "Communication",
        "Conflict", "Awareness", "Perception"
    );

    public static TarotElement Earth => new(
        2,
        "Earth",
        TarotPolarity.Passive,
        "Physical", "Nature", "Health", "Stability", "Reliability",
        "Finances", "Practicality"
    );

    public static TarotElement Fire => new(
        3,
        "Fire",
        TarotPolarity.Active,
        "Energy", "Passion", "Action", "Inspiration", "Drive",
        "Willpower", "Ambition"
    );

    public static TarotElement Water => new(
        4,
        "Water",
        TarotPolarity.Passive,
        "Emotions", "Feelings", "Relationships", "Intuition",
        "Love", "Serenity", "Spirituality"
    );
}