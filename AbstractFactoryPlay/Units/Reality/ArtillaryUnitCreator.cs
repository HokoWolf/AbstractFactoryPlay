namespace AbstractFactoryPlay.Units.Reality;

public class ArtillaryUnitCreator : RangedUnitCreator
{
    public override IRangedUnit CreateUnit()
    {
        return new ArtillaryUnit();
    }
}
