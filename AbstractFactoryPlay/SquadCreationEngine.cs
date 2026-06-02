using AbstractFactoryPlay.Units;

namespace AbstractFactoryPlay;

public class SquadCreationEngine(IUnitFactory unitFactory)
{
    public void Simulate()
    {
        unitFactory.CreateMeleeUnit().Attack();
        unitFactory.CreateRangedUnit().Shoot();
    }
}
