namespace AbstractFactoryPlay.Units.SciFi;

public class CyberNinjaUnitCreator : MeleeUnitCreator
{
    public override IMeleeUnit CreateUnit()
    {
        return new CyberNinjaUnit();
    }
}
