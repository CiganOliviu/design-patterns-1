using System;
using AbstractFactoryPattern.AircraftComponents;

namespace AbstractFactoryPattern
{
    public class Aircraft
    {
        private IEngine engine;
        private ICockpit _cockpit;
        private IWings _wings;

        private IAircraftFactory _factory;

        public Aircraft(IAircraftFactory factory)
        {
            _factory = factory;
        }

        private Aircraft MakeAircraft()
        {
            return this;
        }

        private void Taxi()
        {
            Console.Write("Taxi on runway!");
        }

        public void Fly()
        {
            var aircraft = MakeAircraft();
            aircraft.Taxi();
            
            Console.Write("Flying!");
        }
    }
}