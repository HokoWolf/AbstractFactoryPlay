namespace AbstractFactoryPlay.Units;

public class InfantryUnit : IUnit
{
    public void Attack()
    {
        Console.WriteLine("Infantry man fires from a rifle.");
    }
}
