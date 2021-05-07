using System;

namespace FacadePattern
{
    internal class AutopilotFacade
    {
        private AltitudeMonitor _altitudeMonitor;
        private EngineController _engineController;
        private FuelMonitor _fuelMonitor;
        private NavigationSystem _navigationSystem;

        public AutopilotFacade(AltitudeMonitor altitudeMonitor, EngineController engineController, FuelMonitor fuelMonitor, NavigationSystem navigationSystem)
        {
            _altitudeMonitor = altitudeMonitor;
            _engineController = engineController;
            _fuelMonitor = fuelMonitor;
            _navigationSystem = navigationSystem;
        }

        public static void AutopilotOn()
        {
            AltitudeMonitor.AutoMonitor();
            EngineController.EngineSpeed = 1100;
            NavigationSystem.SetDirectionBasedOnSpeedAndFuel(
                FuelMonitor.Liters,
                EngineController.EngineSpeed
                );
        }

        public static void AutopilotOff()
        {
            AltitudeMonitor.TurnOff();
            EngineController.TurnOff();
            NavigationSystem.TurnOff();
            FuelMonitor.TurnOff();
        }
    }
    
    internal static class Program
    {
        private static void Main(string[] args)
        {
            
        }
    }
}