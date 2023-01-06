namespace Tarot.Models;
public abstract class TarotBase
{
    public int Id { get; }

    public TarotBase(int id)
    {
        Id = id;
    }

    protected static string IconUrl(string icon) =>
        $"https://ishtarcollective.blob.core.windows.net/symbol-icons/{icon}.svg";
}
