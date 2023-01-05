namespace Tarot.Models;

public static class Pentacles
{
    static string LinkUrl(string card) => $"https://labyrinthos.co/blogs/tarot-card-meanings-list/{card}-of-pentacles-meaning-tarot-card-meanings";

    public static List<MinorTarotCard> Cards => new()
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, Page, Knight, Queen, King
    };

    public static MinorTarotCard Ace => new(
        36,
        1,
        TarotSuits.Pentacles,
        LinkUrl("ace"),
        new string[]{
            "Opportunity", "Prosperity", "New Venture"
        },
        new string[]{
            "Lost Opportunity", "Missed Chance", "Bad Investment"
        }
    );

    public static MinorTarotCard Two => new(
        37,
        2,
        TarotSuits.Pentacles,
        LinkUrl("two"),
        new string[]{
            "Balancing Decisions", "Priorties", "Adapting to Change"
        },
        new string[]{
            "Loss of Balance", "Disorganized", "Overwhelmed"
        }
    );

    public static MinorTarotCard Three => new(
        38,
        3,
        TarotSuits.Pentacles,
        LinkUrl("three"),
        new string[]{
            "Teamwork", "Collaboration", "Building"
        },
        new string[]{
            "Lack of Teamwork", "Disorganized", "Group Conflict"
        }
    );

    public static MinorTarotCard Four => new(
        39,
        4,
        TarotSuits.Pentacles,
        LinkUrl("four"),
        new string[]{
            "Conservation", "Security", "Frugality"
        },
        new string[]{
            "Greediness", "Stinginess", "Possessiveness"
        }
    );

    public static MinorTarotCard Five => new(
        40,
        5,
        TarotSuits.Pentacles,
        LinkUrl("five"),
        new string[]{
            "Need", "Poverty", "Insecurity"
        },
        new string[]{
            "Recovery", "Charity", "Improvement"
        }
    );

    public static MinorTarotCard Six => new(
        41,
        6,
        TarotSuits.Pentacles,
        LinkUrl("six"),
        new string[]{
            "Charity", "Generosity", "Sharing"
        },
        new string[]{
            "Strings Attached", "Stinginess", "Power and Domination"
        }
    );

    public static MinorTarotCard Seven => new(
        42,
        7,
        TarotSuits.Pentacles,
        LinkUrl("seven"),
        new string[]{
            "Hard Work", "Perseverance", "Diligence"
        },
        new string[]{
            "Work without Results", "Distractions", "Lack of Rewards"
        }
    );

    public static MinorTarotCard Eight => new(
        43,
        8,
        TarotSuits.Pentacles,
        LinkUrl("eight"),
        new string[]{
            "Diligence", "Passion", "High Standards"
        },
        new string[]{
            "No Passion", "Uninspired", "No Motivation"
        }
    );

    public static MinorTarotCard Nine => new(
        44,
        9,
        TarotSuits.Pentacles,
        LinkUrl("nine"),
        new string[]{
            "Fruits of Labor", "Spending", "Rewards"
        },
        new string[]{
            "Living Beyond Means", "Obsession With Work", "False Success"
        }
    );

    public static MinorTarotCard Ten => new(
        45,
        10,
        TarotSuits.Pentacles,
        LinkUrl("ten"),
        new string[]{
            "Legacy", "Inheritance", "Culmination"
        },
        new string[]{
            "Fleeting Success", "Lack of Stability", "Lack of Resources"
        }
    );

    public static MinorTarotCard Page => new(
        46,
        11,
        TarotSuits.Pentacles,
        LinkUrl("page"),
        new string[]{
            "Ambition", "Desire", "Diligence"
        },
        new string[]{
            "Lack of Commitment", "Greediness", "Laziness"
        }
    );

    public static MinorTarotCard Knight => new(
        47,
        12,
        TarotSuits.Pentacles,
        LinkUrl("knight"),
        new string[]{
            "Efficiency", "Hard Work", "Responsibility"
        },
        new string[]{
            "Laziness", "Obsessed with Work", "Work without Reward"
        }
    );

    public static MinorTarotCard Queen => new(
        48,
        13,
        TarotSuits.Pentacles,
        LinkUrl("queen"),
        new string[]{
            "Practicality", "Creature Comforts", "Financial Security"
        },
        new string[]{
            "Self-Centeredness", "Jealousy", "Smothering"
        }
    );

    public static MinorTarotCard King => new(
        49,
        14,
        TarotSuits.Pentacles,
        LinkUrl("king"),
        new string[]{
            "Abundance", "Propserity", "Security"
        },
        new string[]{
            "Greed", "Indulgence", "Sensuality"
        }
    );
}