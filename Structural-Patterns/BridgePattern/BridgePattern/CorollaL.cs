using System;

namespace BridgePattern
{
    public class CorollaL : AbstractCorolla
    {
        public CorollaL(AbstractCorollaImpl abstractCorollaImpl) : base(abstractCorollaImpl)
        {
            
        }

        public override void ListSafetyEquipment()
        {
            AbstractCorollaImpl.ListSafetyEquipment();
        }

        public override bool IsCarRightHanded()
        {
            return AbstractCorollaImpl.IsCarRightHanded();
        }
    }
}