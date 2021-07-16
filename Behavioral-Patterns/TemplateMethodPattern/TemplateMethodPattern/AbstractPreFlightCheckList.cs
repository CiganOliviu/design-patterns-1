namespace TemplateMethodPattern
{
    public abstract class AbstractPreFlightCheckList
    {
        public void RunCheckList()
        {
            IsFuelEnough();
            AreDoorsLocked();
        }

        protected virtual void IsFuelEnough()
        {
            
        }

        protected virtual void AreDoorsLocked()
        {
            
        }

        protected abstract void CheckAirPressure();
    }
}