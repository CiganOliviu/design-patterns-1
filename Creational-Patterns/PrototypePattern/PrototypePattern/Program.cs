using System;

namespace PrototypePattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IAircraftPrototype prototype = new F16();
            var f16A = prototype.Clone();
            f16A.SetEngine("GE");
            Console.WriteLine(f16A.GetEngine());
            
            var f16B = prototype.Clone();
            f16B.SetEngine("MINX");
            Console.WriteLine(f16B.GetEngine());
        }
    }
}