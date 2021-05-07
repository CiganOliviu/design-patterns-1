using System;

namespace FacadePattern
{
    public class NavigationSystem
    {
        public string Direction { get; set; }

        public static void SetDirectionBasedOnSpeedAndFuel(int fuel, int engineSpeed)
        {
            Console.WriteLine("Setting the course...");
        }
        
        public static void TurnOff()
        {
            Console.WriteLine("Turning Off...");
        }
    }
}