namespace Tarot.Models;

public static class Cups
{
    static string LinkUrl(string card) => $"https://labyrinthos.co/blogs/tarot-card-meanings-list/{card}-of-cups-meaning-tarot-card-meanings";

    public static List<MinorTarotCard> Cards => new()
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, Page, Knight, Queen, King
    };

    public static MinorTarotCard Ace => new(
        22,
        1,
        TarotSuits.Cups,
        LinkUrl("ace"),
        new string[]{
            "New Feelings", "Spirituality", "Intuition"
        },
        new string[]{
            "Emotional Loss", "Blocked Creativity", "Emptiness"
        }
    );

    public static MinorTarotCard Two => new(
        23,
        2,
        TarotSuits.Cups,
        LinkUrl("two"),
        new string[]{
            "Unity", "Partnership", "Connection"
        },
        new string[]{
            "Imbalance", "Broken Communication", "Tension"
        }
    );

    public static MinorTarotCard Three => new(
        24,
        3,
        TarotSuits.Cups,
        LinkUrl("three"),
        new string[]{
            "Friendship", "Community", "Happiness"
        },
        new string[]{
            "Overindulgence", "Gossip", "Isolation"
        }
    );

    public static MinorTarotCard Four => new(
        25,
        4,
        TarotSuits.Cups,
        LinkUrl("four"),
        new string[]{
            "Apathy", "Contemplation", "Disconnectedness"
        },
        new string[]{
            "Sudden Awareness", "Choosing Happiness", "Acceptance"
        }
    );

    public static MinorTarotCard Five => new(
        26,
        5,
        TarotSuits.Cups,
        LinkUrl("five"),
        new string[]{
            "Loss", "Grief", "Disappointment"
        },
        new string[]{
            "Acceptance", "Moving On", "Finding Peace"
        }
    );

    public static MinorTarotCard Six => new(
        27,
        6,
        TarotSuits.Cups,
        LinkUrl("six"),
        new string[]{
            "Familiarity", "Happy Memories", "Healing"
        },
        new string[]{
            "Moving Forward", "Leaving Home", "Independence"
        }
    );

    public static MinorTarotCard Seven => new(
        28,
        7,
        TarotSuits.Cups,
        LinkUrl("seven"),
        new string[]{
            "Searching for Purpose", "Choices", "Daydreaming"
        },
        new string[]{
            "Lack of Purpose", "Disarray", "Diversion", "Confusion"
        }
    );

    public static MinorTarotCard Eight => new(
        29,
        8,
        TarotSuits.Cups,
        LinkUrl("eight"),
        new string[]{
            "Walking Away", "Disillusionment", "Leaving Behind"
        },
        new string[]{
            "Avoidance", "Fear of Change", "Fear of Loss"
        }
    );

    public static MinorTarotCard Nine => new(
        30,
        9,
        TarotSuits.Cups,
        LinkUrl("nine"),
        new string[]{
            "Satisfaction", "Emotional Stability", "Luxury"
        },
        new string[]{
            "Lack of Inner Joy", "Smugness", "Dissatisfaction"
        }
    );

    public static MinorTarotCard Ten => new(
        31,
        10,
        TarotSuits.Cups,
        LinkUrl("ten"),
        new string[]{
            "Inner Happiness", "Fulfillment", "Dreams Coming True"
        },
        new string[]{
            "Shattered Dreams", "Broken Family", "Domestic Disharmony"
        }
    );

    public static MinorTarotCard Page => new(
        32,
        11,
        TarotSuits.Cups,
        LinkUrl("page"),
        new string[]{
            "Happy Surprise", "Dreamer", "Sensitivity"
        },
        new string[]{
            "Emotional Immaturity", "Insecurity", "Disappointment"
        }
    );

    public static MinorTarotCard Knight => new(
        33,
        12,
        TarotSuits.Cups,
        LinkUrl("knight"),
        new string[]{
            "Following the Heart", "Idealist", "Romantic"
        },
        new string[]{
            "Moodiness", "Disappointment"
        }
    );

    public static MinorTarotCard Queen => new(
        34,
        13,
        TarotSuits.Cups,
        LinkUrl("queen"),
        new string[]{
            "Compassion", "Calm", "Comfort"
        },
        new string[]{
            "Martyrdom", "Insecurity", "Dependence"
        }
    );

    public static MinorTarotCard King => new(
        35,
        14,
        TarotSuits.Cups,
        LinkUrl("king"),
        new string[]{
            "Compassion", "Control", "Balance"
        },
        new string[]{
            "Coldness", "Moodiness", "Bad Advice"
        }
    );
}