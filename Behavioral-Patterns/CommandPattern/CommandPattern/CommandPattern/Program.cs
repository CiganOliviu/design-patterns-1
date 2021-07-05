using System;

namespace CommandPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var landingGear = new LandingGear();
            var landingGearDownCommands = new LandingGearDownCommand(landingGear);
            
            landingGearDownCommands.Execute();
        }
    }
}