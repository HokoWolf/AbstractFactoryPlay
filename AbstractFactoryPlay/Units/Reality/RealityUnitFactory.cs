namespace AbstractFactoryPlay.Units.Reality;

public class RealityUnitFactory : IUnitFactory
{
    public IMeleeUnit CreateMeleeUnit()
    {
        return new InfantryUnit();
    }

    public IRangedUnit CreateRangedUnit()
    {
        return new ArtillaryUnit();
    }
}
