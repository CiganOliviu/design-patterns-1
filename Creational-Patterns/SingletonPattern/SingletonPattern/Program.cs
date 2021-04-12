using System;

namespace SingletonPattern
{
    internal class Audi
    {
        private static Audi _onlyInstance;
        
        private Audi()
        {
            
        }
        
        public void StartEngine()
        {
            Console.WriteLine("Start engine!");
        }

        public static Audi GetInstance()
        {
            _onlyInstance ??= new Audi();

            return _onlyInstance;
        }
    }
    
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var audi = Audi.GetInstance();
            audi.StartEngine();
        }
    }
}