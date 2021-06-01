using System;

namespace FacadePattern
{
    public class AltitudeMonitor
    {
        public static int GetStandardAltitude()
        {
            return 11000;
        }

        public static void AutoMonitor()
        {
            Console.WriteLine("Auto monitoring...");
        }

        public static void TurnOff()
        {
            Console.WriteLine("Turning Off...");
        }
    }
}