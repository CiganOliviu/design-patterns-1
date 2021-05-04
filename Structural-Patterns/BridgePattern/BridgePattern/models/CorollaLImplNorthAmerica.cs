using System;

namespace BridgePattern.models
{
    public class CorollaLImplNorthAmerica : AbstractCorollaImpl
    {
        public override void ListSafetyEquipment()
        {
            Console.WriteLine("High safety standards!");
        }

        public override bool IsCarRightHanded()
        {
            return true;
        }
    }
}