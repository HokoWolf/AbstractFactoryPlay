using AbstractFactoryPlay.Units.Fantasy;
using AbstractFactoryPlay.Units.Japan;
using AbstractFactoryPlay.Units.Reality;
using AbstractFactoryPlay.Units.SciFi;

namespace AbstractFactoryPlay;

internal class Program
{
    static SquadCreationEngine Init()
    {
        Console.Write("Choose your game theme:\n1 - Fantasy\n2 - Sci-Fi\n3 - Reality\n4 - Japan\n\nYour theme: ");

        bool isIntValid = int.TryParse(Console.ReadLine(), out int gameThemeNumber);
        Console.WriteLine();

        if (!isIntValid)
        {
            throw new ArgumentException("Entered value is not an integer.");
        }

        GameTheme gameTheme = (GameTheme)gameThemeNumber;

        return gameTheme switch
        {
            GameTheme.Fantasy => new(new FantasyUnitFactory()),
            GameTheme.SciFi => new(new SciFiUnitFactory()),
            GameTheme.Reality => new(new RealityUnitFactory()),
            GameTheme.Japan => new(new JapanUnitFactory()),
            _ => throw new ArgumentOutOfRangeException("Entered value is not an option."),
        };
    }

    static void Main()
    {
        Init().Simulate();
    }
}
