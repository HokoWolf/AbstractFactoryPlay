namespace AbstractFactoryPlay.Units.Fantasy;

public class ArcherUnitCreator : RangedUnitCreator
{
    public override IRangedUnit CreateUnit()
    {
        return new ArcherUnit();
    }
}
