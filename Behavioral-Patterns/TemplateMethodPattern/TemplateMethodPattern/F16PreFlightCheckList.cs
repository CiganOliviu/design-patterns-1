namespace TemplateMethodPattern
{
    public class F16PreFlightCheckList : AbstractPreFlightCheckList
    {
        protected override void CheckAirPressure()
        {
            throw new System.NotImplementedException();
        }

        protected override void AreDoorsLocked()
        {
            base.AreDoorsLocked();
        }

        protected override void IsFuelEnough()
        {
            base.IsFuelEnough();
        }
    }
}