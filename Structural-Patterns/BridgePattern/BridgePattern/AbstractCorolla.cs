namespace BridgePattern
{
    public abstract class AbstractCorolla
    {
        protected readonly AbstractCorollaImpl AbstractCorollaImpl;

        protected AbstractCorolla(AbstractCorollaImpl abstractCorollaImpl)
        {
            AbstractCorollaImpl = abstractCorollaImpl;
        }
        
        public virtual void ListSafetyEquipment()
        {
            throw new System.NotImplementedException();
        }

        public virtual bool IsCarRightHanded()
        {
            throw new System.NotImplementedException();
        }
    }
}