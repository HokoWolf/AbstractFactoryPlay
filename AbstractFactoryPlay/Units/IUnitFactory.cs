namespace AbstractFactoryPlay.Units;

public interface IUnitFactory
{
    IMeleeUnit CreateMeleeUnit();
    IRangedUnit CreateRangedUnit();
}
