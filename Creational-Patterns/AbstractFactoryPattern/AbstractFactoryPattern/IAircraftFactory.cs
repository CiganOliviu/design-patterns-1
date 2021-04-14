using AbstractFactoryPattern.AircraftComponents;

namespace AbstractFactoryPattern
{
    public interface IAircraftFactory
    {
        IEngine CreateEngine();
        ICockpit CreateCockpit();
        IWings CreateWings();
    }
}