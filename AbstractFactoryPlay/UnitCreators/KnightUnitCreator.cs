using AbstractFactoryPlay.Units;

namespace AbstractFactoryPlay.UnitCreators;

public class KnightUnitCreator : UnitCreator
{
    public override IUnit CreateUnit()
    {
        return new KnightUnit();
    }
}
