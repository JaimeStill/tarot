namespace Tarot.Models;

public static class TarotZodiacs
{
    public static List<TarotZodiac> Zodiacs => new()
    {
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Sagittarius,
        Capricorn,
        Aquarius,
        Pisces
    };

    public static IEnumerable<TarotZodiac> GetByElement(TarotElement element) =>
        Zodiacs.Where(x => x.ElementId == element.Id);

    public static IEnumerable<TarotZodiac> GetByModality(TarotModality modality) =>
        Zodiacs.Where(x => x.ModalityId == modality.Id);

    public static IEnumerable<TarotZodiac> GetByRuler(TarotPlanet ruler) =>
        Zodiacs.Where(x => x.RulerId == ruler.Id);

    public static TarotZodiac Aries => new(
        11,
        "Aries",
        new DateOnly(DateTime.Now.Year, 3, 19),
        new DateOnly(DateTime.Now.Year, 4, 19),
        TarotElements.Fire,
        TarotModalities.Fixed,
        TarotPlanets.Sun,
        new string[]{
            "Brave", "Direct", "Fearless", "Independent",
            "Deep Sense of Justice", "Natural Leader"
        },
        new string[]{
            "Aggressive", "Self-centered", "Pushy",
            "Inconsistent", "Bad-tempered", "Selfish"
        }
    );

    public static TarotZodiac Taurus => new(
        12,
        "Taurus",
        new DateOnly(DateTime.Now.Year, 4, 20),
        new DateOnly(DateTime.Now.Year, 5, 20),
        TarotElements.Earth,
        TarotModalities.Fixed,
        TarotPlanets.Venus,
        new string[]{
            "Steady", "Driven", "Tenacious", "Enduring",
            "Persistent", "Trustworthy", "Patient"
        },
        new string[]{
            "Materialistic", "Resistant to Change",
            "Indulgent", "Possessive", "Stubborn"
        }
    );

    public static TarotZodiac Gemini => new(
        13,
        "Gemini",
        new DateOnly(DateTime.Now.Year, 5, 21),
        new DateOnly(DateTime.Now.Year, 6, 20),
        TarotElements.Air,
        TarotModalities.Mutable,
        TarotPlanets.Mercury,
        new string[]{
            "Intelligent", "Adaptable", "Agile",
            "Communicative", "Informative", "Connected"
        },
        new string[]{
            "Talkative", "Exaggerating", "Deceptive",
            "Cunning", "Superficial", "Inconsistent"
        }
    );

    public static TarotZodiac Cancer => new(
        14,
        "Cancer",
        new DateOnly(DateTime.Now.Year, 6, 21),
        new DateOnly(DateTime.Now.Year, 7, 22),
        TarotElements.Water,
        TarotModalities.Cardinal,
        TarotPlanets.Moon,
        new string[]{
            "Nurturing", "Supportive", "Healing",
            "Compassionate", "Unconditionally Loving"
        },
        new string[]{
            "Dependent", "Indirect", "Moody",
            "Passive Aggressive", "Unable to Let Go"
        }
    );

    public static TarotZodiac Leo => new(
        15,
        "Leo",
        new DateOnly(DateTime.Now.Year, 7, 23),
        new DateOnly(DateTime.Now.Year, 8, 22),
        TarotElements.Fire,
        TarotModalities.Fixed,
        TarotPlanets.Sun,
        new string[]{
            "Brave", "Playful", "Leader", "Fun", "Warm",
            "Protective", "Generous", "Charismatic"
        },
        new string[]{
            "Egotistical", "Dominating", "Stubborn",
            "Controlling", "A Show-off", "Vain"
        }
    );

    public static TarotZodiac Virgo => new(
        16,
        "Virgo",
        new DateOnly(DateTime.Now.Year, 8, 23),
        new DateOnly(DateTime.Now.Year, 9, 22),
        TarotElements.Earth,
        TarotModalities.Mutable,
        TarotPlanets.Mercury,
        new string[]{
            "Modest", "Humble", "Orderly", "Altruistic",
            "Logical", "Responsible", "Organized"
        },
        new string[]{
            "Obsessive", "Critical", "Excessive", "Perfectionist",
            "Attention to Insignificant Details"
        }
    );

    public static TarotZodiac Libra => new(
        17,
        "Libra",
        new DateOnly(DateTime.Now.Year, 9, 23),
        new DateOnly(DateTime.Now.Year, 10, 22),
        TarotElements.Air,
        TarotModalities.Cardinal,
        TarotPlanets.Venus,
        new string[]{
            "Charming", "Harmonious","Diplomatic",
            "Easy-going Nature", "Polished"
        },
        new string[]{
            "Indecisive", "Superficial", "Hypocritical",
            "Gullible", "Passive Aggressive"
        }
    );

    public static TarotZodiac Scorpio => new(
        18,
        "Scorpio",
        new DateOnly(DateTime.Now.Year, 10, 23),
        new DateOnly(DateTime.Now.Year, 11, 21),
        TarotElements.Water,
        TarotModalities.Fixed,
        TarotPlanets.Pluto,
        new string[]{
            "Passionate", "Driven", "Perceptive",
            "Emotional", "Sacrificing", "Determined"
        },
        new string[]{
            "Vindictive", "Paranoid", "Destructive",
            "Possessive", "Jealous", "Clingy"
        }
    );

    public static TarotZodiac Sagittarius => new(
        19,
        "Sagittarius",
        new DateOnly(DateTime.Now.Year, 11, 22),
        new DateOnly(DateTime.Now.Year, 12, 21),
        TarotElements.Fire,
        TarotModalities.Mutable,
        TarotPlanets.Jupiter,
        new string[]{
            "Ambitious", "Lucky", "Moral", "Optimistic",
            "Enthusiastic", "Open-minded", "Versatile"
        },
        new string[]{
            "Gluttonous", "Lazy", "Restless", "Irresponsible",
            "Blindly Optimistic", "Tactless"
        }
    );

    public static TarotZodiac Capricorn => new(
        20,
        "Capricorn",
        new DateOnly(DateTime.Now.Year, 12, 22),
        new DateOnly(DateTime.Now.Year, 1, 19),
        TarotElements.Earth,
        TarotModalities.Cardinal,
        TarotPlanets.Saturn,
        new string[]{
            "Driven", "Patient", "Strategic", "Determined",
            "Disciplined", "Responsible", "Persistent"
        },
        new string[]{
            "Pessimistic", "Greedy", "Cynical", "Fearful",
            "Ruthless", "Rigid", "Miserly"
        }
    );

    public static TarotZodiac Aquarius => new(
        21,
        "Aquarius",
        new DateOnly(DateTime.Now.Year, 1, 20),
        new DateOnly(DateTime.Now.Year, 2, 18),
        TarotElements.Air,
        TarotModalities.Fixed,
        TarotPlanets.Uranus,
        new string[]{
            "Intelligent", "Inventive", "Humanistic",
            "Friendly", "Altruistic", "Reformative"
        },
        new string[]{
            "Emotionally Detached", "Scatterbrained",
            "Irresponsible", "Impersonal"
        }
    );

    public static TarotZodiac Pisces => new(
        22,
        "Pisces",
        new DateOnly(DateTime.Now.Year, 2, 19),
        new DateOnly(DateTime.Now.Year, 3, 20),
        TarotElements.Water,
        TarotModalities.Mutable,
        TarotPlanets.Neptune,
        new string[]{
            "Mystical", "Intuitive", "Creative",
            "Romantic", "Compassionate", "Sensitive"
        },
        new string[]{
            "Escapist", "Unrealistic", "Submissive",
            "Self-pitying", "Dependent", "Codependent"
        }
    );
}