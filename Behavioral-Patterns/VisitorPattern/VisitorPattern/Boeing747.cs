namespace VisitorPattern
{
    public class Boeing747 : IAircraft
    {
        public void Accept(IAircraftVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}