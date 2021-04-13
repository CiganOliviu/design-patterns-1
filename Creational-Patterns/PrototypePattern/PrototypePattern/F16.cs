using System;

namespace PrototypePattern
{
    public class F16 : IAircraftPrototype
    {
        private string _engine;
        
        public void StartEngine()
        {
            Console.WriteLine("Start engine!");
        }

        public IAircraftPrototype Clone()
        {
            return new F16();
        }

        public void SetEngine(string engine)
        {
            _engine = engine;
        }

        public string GetEngine()
        {
            return _engine;
        }
    }
}