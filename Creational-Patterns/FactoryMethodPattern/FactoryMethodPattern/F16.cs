using System;
using FactoryMethodPattern.AircraftComponents;
using FactoryMethodPattern.F16Aircrafts;

namespace FactoryMethodPattern
{
    public class F16
    {
        public IEngine Engine;
        public ICockpit Cockpit;

        protected virtual F16 MakeF16()
        {
            Engine = new F16Engine();
            Cockpit = new F16Cockpit();

            return this;
        }

        private void Taxi()
        {
            Console.WriteLine("F16 is taxing on the runway!");
        }

        public void Fly()
        {
            var f16 = MakeF16();
            f16.Taxi();
            Console.WriteLine("F16 is in the air!");
        }
    }

    internal class F16A : F16
    {
        protected override F16 MakeF16()
        {
            base.MakeF16();
            Engine = new F16AEngine();

            return this;
        }
    }

    internal class F16B : F16
    {
        protected override F16 MakeF16()
        {
            base.MakeF16();
            Engine = new F16BEngine();

            return this;
        }
    }
}