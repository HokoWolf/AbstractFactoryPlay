namespace AbstractFactoryPlay.Units.Fantasy;

public class WarhorseUnit : IMountUnit
{
    public void Move()
    {
        Console.WriteLine("Warhorse gallops across the field.");
    }
}
