namespace AbstractFactoryPlay.Units.Japan;

public class JapanUnitFactory : IUnitFactory
{
    public IMeleeUnit CreateMeleeUnit()
    {
        return new SamuraiUnit();
    }

    public IRangedUnit CreateRangedUnit()
    {
        return new YumihikiUnit();
    }

    public IMountUnit CreateMountUnit()
    {
        return new WarmuleUnit();
    }
}
