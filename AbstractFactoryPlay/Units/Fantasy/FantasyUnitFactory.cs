namespace AbstractFactoryPlay.Units.Fantasy;

public class FantasyUnitFactory : IUnitFactory
{
    public IMeleeUnit CreateMeleeUnit()
    {
        return new KnightUnit();
    }

    public IRangedUnit CreateRangedUnit()
    {
        return new ArcherUnit();
    }

    public IMountUnit CreateMountUnit()
    {
        return new WarhorseUnit();
    }
}
