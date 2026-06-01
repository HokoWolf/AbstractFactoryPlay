using AbstractFactoryPlay.Units;

namespace AbstractFactoryPlay;

public class SquadCreationEngine(MeleeUnitCreator meleeUnitCreator, RangedUnitCreator rangedUnitCreator)
{
    public void Simulate()
    {
        meleeUnitCreator.CreateUnit().Attack();
        rangedUnitCreator.CreateUnit().Shoot();
    }
}
