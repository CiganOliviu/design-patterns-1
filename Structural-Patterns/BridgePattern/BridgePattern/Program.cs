using System;
using BridgePattern.models;

namespace BridgePattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            AbstractCorolla corollaAsia = new CorollaL(new CorollaLImplAsiaPacific());
            corollaAsia.ListSafetyEquipment();

            AbstractCorolla corollaUs = new CorollaL(new CorollaLImplNorthAmerica());
            corollaUs.ListSafetyEquipment();
        }
    }
}
