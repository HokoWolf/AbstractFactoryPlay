namespace AbstractFactoryPlay.Units.SciFi;

public class SciFiUnitFactory : IUnitFactory
{
    public IMeleeUnit CreateMeleeUnit()
    {
        return new CyberNinjaUnit();
    }

    public IRangedUnit CreateRangedUnit()
    {
        return new LaserTrooperUnit();
    }
}
