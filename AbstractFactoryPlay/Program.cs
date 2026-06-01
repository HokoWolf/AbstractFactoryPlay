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
            GameTheme.Fantasy => new(new KnightUnitCreator(), new ArcherUnitCreator()),
            GameTheme.SciFi => new(new CyberNinjaUnitCreator(), new LaserTrooperUnitCreator()),
            GameTheme.Reality => new(new InfantryUnitCreator(), new ArtillaryUnitCreator()),
            GameTheme.Japan => new(new SamuraiUnitCreator(), new YumihikiUnitCreator()),
            _ => throw new ArgumentOutOfRangeException("Entered value is not an option."),
        };
    }

    static void Main()
    {
        Init().Simulate();
    }
}
