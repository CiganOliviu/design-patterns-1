namespace FlyweightPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var f16 = new F16();
            f16.PredictRemainedFuel(300, 900);
        }
    }
}