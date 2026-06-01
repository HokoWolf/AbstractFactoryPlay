using AbstractFactoryPlay.Units;

namespace AbstractFactoryPlay;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Choose your game theme:\n1 - Fantasy\n2 - Sci-Fi");

        int gameThemeNumber;

        bool isIntValid = int.TryParse(Console.ReadLine(), out gameThemeNumber);

        if (!isIntValid)
        {
            throw new ArgumentException("Entered value is not an integer.");
        }

        GameTheme gameTheme = (GameTheme)gameThemeNumber;

        switch (gameTheme)
        {
            case GameTheme.Fantasy:
                KnightUnit knight = new();
                knight.Attack();
                break;
            
            case GameTheme.SciFi:
                CyberNinjaUnit cyberNinja = new();
                cyberNinja.Attack();
                break;
            
            default:
                throw new ArgumentOutOfRangeException("Entered value is not an option."); 
        }
    }
}
