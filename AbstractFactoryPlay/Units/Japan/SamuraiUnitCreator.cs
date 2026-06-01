namespace AbstractFactoryPlay.Units.Japan;

public class SamuraiUnitCreator : MeleeUnitCreator
{
    public override IMeleeUnit CreateUnit()
    {
        return new SamuraiUnit();
    }
}
