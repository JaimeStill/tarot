namespace Tarot.Models;

public abstract class TarotAstrology : TarotBase
{
    public string Type { get; }
    public abstract string Name { get; }
    public abstract string[] Keywords { get; }

    public TarotAstrology(int id, string type) : base(id)
    {
        Type = type;
    }

    public static TarotAstrology Get(string type, int id) => type switch
    {
        "Planet" => TarotPlanets.Planets.Get(id),
        "Zodiac" => TarotZodiacs.Zodiacs.Get(id),
        _ => throw new ArgumentOutOfRangeException($"{type} is not an Astrology type")
    };
}