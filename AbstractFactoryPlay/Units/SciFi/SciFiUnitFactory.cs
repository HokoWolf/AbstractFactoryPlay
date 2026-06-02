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

    public IMountUnit CreateMountUnit()
    {
        return new HoverBikeUnit();
    }
}
