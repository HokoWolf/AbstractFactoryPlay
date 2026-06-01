namespace AbstractFactoryPlay.Units.Reality;

public class InfantryUnitCreator : MeleeUnitCreator
{
    public override IMeleeUnit CreateUnit()
    {
        return new InfantryUnit();
    }
}
