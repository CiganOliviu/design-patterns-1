using System.Collections;
using System.Collections.Generic;

namespace MediatorPattern
{
    public class ControlTower
    {
        private readonly ArrayList _airplanes = new ArrayList();

        public void RequestToLand(IAircraft aircraft)
        {
            _airplanes.Add(aircraft);
        }

        public void Run()
        {
            while (true)
            {
                while (_airplanes.Count == 0);

                IAircraft aircraft;

                aircraft = _airplanes.RemoveAt(0);

                aircraft.Land();
            }
        }
    }
}