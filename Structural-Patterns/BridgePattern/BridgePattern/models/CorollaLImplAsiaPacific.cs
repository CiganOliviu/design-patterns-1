using System;

namespace BridgePattern.models
{
    public class CorollaLImplAsiaPacific : AbstractCorollaImpl
    {
        public override void ListSafetyEquipment()
        {
            Console.WriteLine("Not so safe!");
        }

        public override bool IsCarRightHanded()
        {
            return false;
        }
    }
}