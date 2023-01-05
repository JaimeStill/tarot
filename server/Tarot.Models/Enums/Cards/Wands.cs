namespace Tarot.Models;

public static class Wands
{
    static string LinkUrl(string card) => $"https://labyrinthos.co/blogs/tarot-card-meanings-list/{card}-of-wands-meaning-tarot-card-meanings";

    public static List<MinorTarotCard> Cards => new()
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, Page, Knight, Queen, King
    };

    public static MinorTarotCard Ace => new(
        64,
        1,
        TarotSuits.Wands,
        LinkUrl("ace"),
        new string[]{
            "Creation", "Willpower", "Inspiration", "Desire"
        },
        new string[]{
            "Lack of Energy", "Lack of Passion", "Boredom"
        }
    );

    public static MinorTarotCard Two => new(
        65,
        2,
        TarotSuits.Wands,
        LinkUrl("two"),
        new string[]{
            "Planning", "Making Decisions", "Leaving Home"
        },
        new string[]{
            "Fear of Change", "Playing it Safe", "Bad Planning"
        }
    );

    public static MinorTarotCard Three => new(
        66,
        3,
        TarotSuits.Wands,
        LinkUrl("three"),
        new string[]{
            "Looking Ahead", "Expansion", "Rapid Growth"
        },
        new string[]{
            "Obstacles", "Delays", "Frustration"
        }
    );

    public static MinorTarotCard Four => new(
        67,
        4,
        TarotSuits.Wands,
        LinkUrl("four"),
        new string[]{
            "Community", "Home", "Celebration"
        },
        new string[]{
            "Lack of Support", "Transience", "Home Conflicts"
        }
    );

    public static MinorTarotCard Five => new(
        68,
        5,
        TarotSuits.Wands,
        LinkUrl("five"),
        new string[]{
            "Competition", "Conflict", "Rivalry"
        },
        new string[]{
            "Avoiding Conflict", "Respect Differences"
        }
    );

    public static MinorTarotCard Six => new(
        69,
        6,
        TarotSuits.Wands,
        LinkUrl("six"),
        new string[]{
            "Victory", "Success", "Public Reward"
        },
        new string[]{
            "Excess Pride", "Lack of Recognition", "Punishment"
        }
    );

    public static MinorTarotCard Seven => new(
        70,
        7,
        TarotSuits.Wands,
        LinkUrl("seven"),
        new string[]{
            "Perseverance", "Mount Defense", "Maintaining Control"
        },
        new string[]{
            "Giving Up", "No Confidence", "Overwhelmed"
        }
    );

    public static MinorTarotCard Eight => new(
        71,
        8,
        TarotSuits.Wands,
        LinkUrl("eight"),
        new string[]{
            "Rapid Action", "Movement", "Quick Decisions"
        },
        new string[]{
            "Panic", "Waiting", "Slowing Down"
        }
    );

    public static MinorTarotCard Nine => new(
        72,
        9,
        TarotSuits.Wands,
        LinkUrl("nine"),
        new string[]{
            "Resilience", "Grit", "Last Stand"
        },
        new string[]{
            "Exhaustion", "Fatigue", "Unsure Motivations"
        }
    );

    public static MinorTarotCard Ten => new(
        73,
        10,
        TarotSuits.Wands,
        LinkUrl("ten"),
        new string[]{
            "Accomplishment", "Responsibility", "Burden"
        },
        new string[]{
            "Can't Delegate", "Overstressed", "Burnt Out"
        }
    );

    public static MinorTarotCard Page => new(
        74,
        11,
        TarotSuits.Wands,
        LinkUrl("page"),
        new string[]{
            "Exploration", "Excitement", "Freedom"
        },
        new string[]{
            "Lack of Direction", "Procrastination", "Creating Conflict"
        }
    );

    public static MinorTarotCard Knight => new(
        75,
        12,
        TarotSuits.Wands,
        LinkUrl("knight"),
        new string[]{
            "Action", "Adventure", "Fearlessness"
        },
        new string[]{
            "Anger", "Impulsivity", "Recklessness"
        }
    );

    public static MinorTarotCard Queen => new(
        76,
        13,
        TarotSuits.Wands,
        LinkUrl("queen"),
        new string[]{
            "Courage", "Determination", "Joy"
        },
        new string[]{
            "Selfishness", "Jealousy", "Insecurity"
        }
    );

    public static MinorTarotCard King => new(
        77,
        14,
        TarotSuits.Wands,
        LinkUrl("king"),
        new string[]{
            "Big Picture", "Leader", "Overcoming Challenges"
        },
        new string[]{
            "Impulsive", "Overbearing", "Impossible Expectations"
        }
    );
}