using System;

namespace FacadePattern
{
    public class EngineController
    {
        public static int EngineSpeed { get; set; }

        public static void TurnOff()
        {
            Console.WriteLine("Turning Off...");
        }
    }
}