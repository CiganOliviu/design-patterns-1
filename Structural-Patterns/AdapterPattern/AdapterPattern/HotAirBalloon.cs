using System;

namespace AdapterPattern
{
    public class HotAirBalloon
    {
        private const string GasUsed = "Helium";

        public void Fly(string gasUsed)
        {
            Console.Write("The gas used is" + gasUsed);
        }

        public string InflateWithGas()
        {
            return GasUsed;
        }
    }
}