namespace AbstractFactoryPlay.Units.Fantasy;

public class KnightUnitCreator : MeleeUnitCreator
{
    public override IMeleeUnit CreateUnit()
    {
        return new KnightUnit();
    }
}
