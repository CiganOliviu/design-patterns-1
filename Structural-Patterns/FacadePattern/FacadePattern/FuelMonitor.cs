using System;

namespace FacadePattern
{
    public class FuelMonitor
    {
        public static int Liters { get; set; }
        
        public static void TurnOff()
        {
            Console.WriteLine("Turning Off...");
        }
    }
}