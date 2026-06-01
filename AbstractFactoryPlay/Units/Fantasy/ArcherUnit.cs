namespace AbstractFactoryPlay.Units.Fantasy;

public class ArcherUnit : IRangedUnit
{
    public void Shoot()
    {
        Console.WriteLine("Archer fires a piercing arrow.");
    }
}
