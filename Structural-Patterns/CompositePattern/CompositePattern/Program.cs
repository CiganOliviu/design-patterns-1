using System;

namespace CompositePattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var airforce = new Airforce();

            var f16 = new F16();
            var f35 = new F35();
            
            airforce.Add(f16);
            airforce.Add(f35);
            
            Console.WriteLine(airforce.GetPersonnel());
        }
    }
}