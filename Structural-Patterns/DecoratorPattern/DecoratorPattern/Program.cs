using System;

namespace DecoratorPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IAircraft boeing = new Boeing747();
            var luxuryClass = new LuxuryClass(boeing);
            var bulletProof = new BulletProof(luxuryClass);
            
            Console.WriteLine(bulletProof.GetWeight());
        }
    }
}