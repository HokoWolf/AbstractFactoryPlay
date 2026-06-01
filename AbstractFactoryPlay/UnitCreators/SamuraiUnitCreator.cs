using AbstractFactoryPlay.Units;

namespace AbstractFactoryPlay.UnitCreators;

public class SamuraiUnitCreator : UnitCreator
{
    public override IUnit CreateUnit()
    {
        return new SamuraiUnit();
    }
}
