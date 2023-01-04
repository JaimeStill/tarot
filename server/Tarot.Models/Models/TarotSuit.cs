namespace Tarot.Models;

public class TarotSuit : TarotBase
{
    public string Name { get; }
    public int ElementId { get; }

    public TarotSuit(
        int id,
        string name,
        TarotElement element
    ) : base(id)
    {
        Name = name;
        ElementId = element.Id;
    }

    public TarotElement Element => TarotElements.Elements.Get(ElementId);
}