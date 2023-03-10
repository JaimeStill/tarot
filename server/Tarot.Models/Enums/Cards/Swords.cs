namespace Tarot.Models;

public static class Swords
{
    static string LinkUrl(string card) => $"https://labyrinthos.co/blogs/tarot-card-meanings-list/{card}-of-swords-meaning-tarot-card-meanings";

    public static List<MinorTarotCard> Cards => new()
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Ten, Page, Knight, Queen, King
    };

    public static MinorTarotCard Ace => new(
        50,
        1,
        TarotSuits.Swords,
        LinkUrl("ace"),
        new string[]{
            "Breakthrough", "Clarity", "Sharp Mind"
        },
        new string[]{
            "Confusion", "Brutality", "Chaos"
        }
    );

    public static MinorTarotCard Two => new(
        51,
        2,
        TarotSuits.Swords,
        LinkUrl("two"),
        new string[]{
            "Difficult Choices", "Indecision", "Stalemate"

        },
        new string[]{
            "Lesser of Two Evils", "No Right Choice", "Confusion"
        }
    );

    public static MinorTarotCard Three => new(
        52,
        3,
        TarotSuits.Swords,
        LinkUrl("three"),
        new string[]{
            "Heartbreak", "Suffering", "Grief"
        },
        new string[]{
            "Recovery", "Forgiveness", "Moving On"
        }
    );

    public static MinorTarotCard Four => new(
        53,
        4,
        TarotSuits.Swords,
        LinkUrl("four"),
        new string[]{
            "Rest", "Restoration", "Contemplation"
        },
        new string[]{
            "Restlessness", "Burnout", "Stress"
        }
    );

    public static MinorTarotCard Five => new(
        54,
        5,
        TarotSuits.Swords,
        LinkUrl("five"),
        new string[]{
            "Unbridled Ambition", "Win at All Costs", "Sneakiness"
        },
        new string[]{
            "Resentment", "Desire to Reconcile", "Desire to Forgive"
        }
    );

    public static MinorTarotCard Six => new(
        55,
        6,
        TarotSuits.Swords,
        LinkUrl("six"),
        new string[]{
            "Transition", "Leaving Behind", "Moving On"
        },
        new string[]{
            "Emotional Baggage", "Unresolved Issues", "Resisting Transition"
        }
    );

    public static MinorTarotCard Seven => new(
        56,
        7,
        TarotSuits.Swords,
        LinkUrl("seven"),
        new string[]{
            "Deception", "Trickery", "Tactics & Strategy"
        },
        new string[]{
            "Coming Clean", "Rethinking Approach", "Deception"
        }
    );

    public static MinorTarotCard Eight => new(
        57,
        8,
        TarotSuits.Swords,
        LinkUrl("eight"),
        new string[]{
            "Imprisonment", "Entrapment", "Self-Victimization"
        },
        new string[]{
            "Self-Acceptance", "New Perspective", "Freedom"
        }
    );

    public static MinorTarotCard Nine => new(
        58,
        9,
        TarotSuits.Swords,
        LinkUrl("nine"),
        new string[]{
            "Anxiety", "Hopelessness", "Trauma"
        },
        new string[]{
            "Hope", "Reaching Out", "Despair"
        }
    );

    public static MinorTarotCard Ten => new(
        59,
        10,
        TarotSuits.Swords,
        LinkUrl("ten"),
        new string[]{
            "Failure", "Collapse", "Defeat"
        },
        new string[]{
            "Can't Get Worse", "Only Upwards", "Inevitable End"
        }
    );

    public static MinorTarotCard Page => new(
        60,
        11,
        TarotSuits.Swords,
        LinkUrl("page"),
        new string[]{
            "Curiosity", "Restlessness", "Mental Energy"
        },
        new string[]{
            "Deception", "Manipulation", "All Talk"
        }
    );

    public static MinorTarotCard Knight => new(
        61,
        12,
        TarotSuits.Swords,
        LinkUrl("knight"),
        new string[]{
            "Action", "Impulsiveness", "Defending Beliefs"
        },
        new string[]{
            "No Direction", "Disregarding Consequences", "Unpredictability"
        }
    );

    public static MinorTarotCard Queen => new(
        62,
        13,
        TarotSuits.Swords,
        LinkUrl("queen"),
        new string[]{
            "Complexity", "Perceptiveness", "Clear Mindedness"
        },
        new string[]{
            "Cold Hearted", "Cruel", "Bitterness"
        }
    );

    public static MinorTarotCard King => new(
        63,
        14,
        TarotSuits.Swords,
        LinkUrl("king"),
        new string[]{
            "Head Over Heart", "Discipline", "Truth"
        },
        new string[]{
            "Manipulative", "Cruel", "Weakness"
        }
    );
}