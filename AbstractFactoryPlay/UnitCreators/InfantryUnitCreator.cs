using AbstractFactoryPlay.Units;

namespace AbstractFactoryPlay.UnitCreators;

public class InfantryUnitCreator : UnitCreator
{
    public override IUnit CreateUnit()
    {
        return new InfantryUnit();
    }
}
