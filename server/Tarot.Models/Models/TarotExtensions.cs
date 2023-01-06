namespace Tarot.Models;

public static class TarotExtensions
{
    public static T Get<T>(this List<T> values, int id) where T : TarotBase =>
        values.First(x => x.Id == id);

    public static T Get<T>(this List<T> values, string name) where T : TarotCard =>
        values.First(x => x.Name.ToLower() == name.ToLower());
}
