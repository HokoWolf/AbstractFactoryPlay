namespace AbstractFactoryPlay.Units.Reality;

public class InfantryUnit : IMeleeUnit
{
    public void Attack()
    {
        Console.WriteLine("Infantry man fires from a rifle.");
    }
}
