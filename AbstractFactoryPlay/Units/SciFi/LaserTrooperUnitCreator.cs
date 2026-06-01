namespace AbstractFactoryPlay.Units.SciFi;

public class LaserTrooperUnitCreator : RangedUnitCreator
{
    public override IRangedUnit CreateUnit()
    {
        return new LaserTrooperUnit();
    }
}
