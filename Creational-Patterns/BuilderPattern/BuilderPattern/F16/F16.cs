using System;
using BuilderPattern.Aircraft;

namespace BuilderPattern.F16
{
    public class F16 : IAircraft
    {
        private string _engine;
        private string _wings;
        private string _cockpit;
        
        public void SetEngine(string engine)
        {
            _engine = engine;
        }

        public string GetEngine()
        {
            return _engine;
        }

        public void SetWings(string wings)
        {
            _wings = wings;
        }

        public string GetWings()
        {
            return _wings;
        }

        public void SetCockpit(string cockpit)
        {
            _cockpit = cockpit;
        }

        public string GetCockpit()
        {
            return _cockpit;
        }
                
        public void GetDetails()
        {
            Console.WriteLine(GetEngine());
            Console.WriteLine(GetWings());
            Console.WriteLine(GetCockpit());
        }
    }
}