using AbstractFactoryPattern.AircraftComponents;

namespace AbstractFactoryPattern.Factory
{
    public class Boeing747Factory : IAircraftFactory
    {
        public IEngine CreateEngine()
        {
            throw new System.NotImplementedException();
        }

        public ICockpit CreateCockpit()
        {
            throw new System.NotImplementedException();
        }

        public IWings CreateWings()
        {
            throw new System.NotImplementedException();
        }
    }
}