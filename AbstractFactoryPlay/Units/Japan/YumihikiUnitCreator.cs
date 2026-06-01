namespace AbstractFactoryPlay.Units.Japan;

public class YumihikiUnitCreator : RangedUnitCreator
{
    public override IRangedUnit CreateUnit()
    {
        return new YumihikiUnit();
    }
}
