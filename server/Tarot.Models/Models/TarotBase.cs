namespace Tarot.Models;
public abstract class TarotBase
{
    public int Id { get; }

    public TarotBase(int id)
    {
        Id = id;
    }
}