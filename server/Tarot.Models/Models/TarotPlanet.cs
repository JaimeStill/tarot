namespace Tarot.Models;

public class TarotPlanet : TarotAstrology
{
    public override string Name { get; }
    public override string[] Keywords { get; }
    public string Transition { get; }

    public TarotPlanet(
        int id,
        string name,
        string transition,
        params string[] keywords
    ) : base(id, "Planet")
    {
        Name = name;
        Transition = transition;
        Keywords = keywords;
    }
}
