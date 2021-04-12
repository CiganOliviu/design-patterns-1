using System;
using BuilderPattern.Aircraft;

namespace BuilderPattern.Boeing747
{
    public class Boeing747 : IAircraft
    {
        private string _engine;
        private string _wings;
        private string _cockpit;
        private string _bathroom;

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

        public void SetBathroom(string bathroom)
        {
            _bathroom = bathroom;
        }
        
        private string GetBathroom()
        {
            return _bathroom;
        }
        
        public void GetDetails()
        {
            Console.WriteLine(GetEngine());
            Console.WriteLine(GetWings());
            Console.WriteLine(GetCockpit());
            Console.WriteLine(GetBathroom());
        }
    }
}