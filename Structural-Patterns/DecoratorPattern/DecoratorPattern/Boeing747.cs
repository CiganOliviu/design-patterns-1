using System;

namespace DecoratorPattern
{
    public class Boeing747 : IAircraft
    {
        private const int BaseWeight = 1000;

        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        public void Land()
        {
            Console.WriteLine("Land");
        }

        public float GetWeight()
        {
            return BaseWeight;
        }
    }
}