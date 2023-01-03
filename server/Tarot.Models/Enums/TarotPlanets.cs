namespace Tarot.Models;

public static class TarotPlanets
{
    public static List<TarotPlanet> Planets => new()
    {
        Jupiter,
        Mars,
        Mercury,
        Moon,
        Neptune,
        Pluto,
        Saturn,
        Sun,
        Uranus,
        Venus
    };

    public static TarotPlanet Jupiter => new(
        1,
        "Jupiter",
        "Every 12 - 13 Months",
        "Luck", "Growth", "Expansion",
        "Optimism", "Abundance",
        "Understanding"
    );

    public static TarotPlanet Mars => new(
        2,
        "Mars",
        "Every 6 - 7 Weeks",
        "Aggression", "Sex", "Action", "Desire",
        "Competition", "Courage", "Passion"
    );

    public static TarotPlanet Mercury => new(
        3,
        "Mercury",
        "Every 3 - 4 Weeks",
        "Mind", "Communication", "Intellect",
        "Reason", "Language", "Intelligence"
    );

    public static TarotPlanet Moon => new(
        4,
        "Moon",
        "Every 2 - 3 Days",
        "Unconsciousness", "Emotions", "Instincts",
        "Habits", "Moods"
    );

    public static TarotPlanet Neptune => new(
        5,
        "Neptune",
        "Every 10 - 12 Years",
        "Dreams", "Intuition", "Mysticism",
        "Imagination", "Delusions"
    );

    public static TarotPlanet Pluto => new(
        6,
        "Pluto",
        "Every 12 - 15 Years",
        "Transformation", "Power", "Death",
        "Rebirth", "Evolution"
    );

    public static TarotPlanet Saturn => new(
        7,
        "Saturn",
        "Every 2 - 3 Years",
        "Structure", "Law", "Restriction",
        "Discipline", "Responsiblity",
        "Obligation", "Ambition"
    );

    public static TarotPlanet Sun => new(
        8,
        "Sun",
        "Every Month",
        "Ego", "Basic Personality", "Consciousness",
        "Vitality", "Stamina"
    );

    public static TarotPlanet Uranus => new(
        9,
        "Uranus",
        "Every 7 Years",
        "Eccentricity", "Unpredictable Changes",
        "Rebellion", "Reformation"
    );

    public static TarotPlanet Venus => new(
        10,
        "Venus",
        "Every 4 - 5 Weeks",
        "Attraction", "Love", "Relationships",
        "Art", "Beauty", "Harmony"
    );
}