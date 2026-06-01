using AbstractFactoryPlay.Units;

namespace AbstractFactoryPlay.UnitCreators;

public class CyberNinjaUnitCreator : UnitCreator
{
    public override IUnit CreateUnit()
    {
        return new CyberNinjaUnit();
    }
}
