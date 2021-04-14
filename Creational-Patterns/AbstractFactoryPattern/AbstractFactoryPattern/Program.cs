using System.Collections.ObjectModel;
using AbstractFactoryPattern.Factory;

namespace AbstractFactoryPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var f16Factory = new F16Factory();
            var boeing747Factory = new Boeing747Factory();

            var myPlanes = new Collection<Aircraft> {new Aircraft(f16Factory), new Aircraft(boeing747Factory)};


            foreach (var aircraft in myPlanes)
                aircraft.Fly();
                
        }
    }
}