namespace Tarot.Models;

public static class TarotExtensions
{
    public static T Get<T>(this List<T> values, int id) where T : TarotBase =>
        values.First(x => x.Id == id);
}