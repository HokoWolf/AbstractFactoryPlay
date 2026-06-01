namespace AbstractFactoryPlay.Units.Reality;

public class ArtillaryUnit : IRangedUnit
{
    public void Shoot()
    {
        Console.WriteLine("Artillary fires a volley of fire.");
    }
}
