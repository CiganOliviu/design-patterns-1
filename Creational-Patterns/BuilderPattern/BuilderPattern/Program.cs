using System;
using BuilderPattern.Builder;

namespace BuilderPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var f16Builder = new F16Builder();
            var f16Director = new Director(f16Builder);
            f16Director.Construct(false);
            f16Builder.GetResult().GetDetails();
            
            var boeing747Builder = new Boeing747Builder();
            var boeing747Director = new Director(boeing747Builder);
            boeing747Director.Construct(true);
            boeing747Builder.GetResult().GetDetails();
        }
    }
}