namespace Tarot.Models;
public static class CardExtensions
{
    public static List<T> Shuffle<T>(this List<T> cards, uint shuffles = 0) where T : ICard
    {
        Random rng = new();
        int n = cards.Count;

        do
        {
            for (int i = 0; i < n - 1; i++)
            {
                int r = i + rng.Next(n - i);
                (cards[i], cards[r]) = (cards[r], cards[i]);
            }

            if (shuffles > 0)
                shuffles--;
        }
        while (shuffles > 0);

        return cards;
    }

    public static T Deal<T>(this List<T> cards) where T : ICard
    {
        T card = cards[0];
        cards.RemoveAt(0);
        return card;
    }
}