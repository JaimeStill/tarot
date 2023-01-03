namespace Tarot.Models;

public static class TarotModalities
{
    public static List<TarotModality> Modalities => new()
    {
        Cardinal,
        Fixed,
        Mutable
    };

    public static TarotModality Cardinal => new(
        1,
        "Cardinal",
        "Action", "Dynamic", "Initiative", "Great Force"
    );

    public static TarotModality Fixed => new(
        2,
        "Fixed",
        "Resistance to Change", "Great Willpower", "Inflexible"
    );

    public static TarotModality Mutable => new(
        3,
        "Mutable",
        "Adaptability", "Flexibility", "Resourcefulness"
    );
}