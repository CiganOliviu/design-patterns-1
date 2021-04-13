using System.Collections.ObjectModel;

namespace FactoryMethodPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var airForce = new Collection<F16>();

            F16 f16A = new F16A();
            F16 f16B = new F16B();
            
            airForce.Add(f16A);
            airForce.Add(f16B);
            
            foreach (var f16 in airForce)
                f16.Fly();
        }
    }
}
