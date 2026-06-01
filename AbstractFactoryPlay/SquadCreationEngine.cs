using AbstractFactoryPlay.UnitCreators;

namespace AbstractFactoryPlay;

public class SquadCreationEngine(UnitCreator unitCreator)
{
    public void Simulate()
    {
        unitCreator.CreateUnit().Attack();
    }
}
