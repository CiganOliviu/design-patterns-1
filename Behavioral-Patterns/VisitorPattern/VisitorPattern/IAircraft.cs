namespace VisitorPattern
{
    public interface IAircraft
    {
        void Accept(IAircraftVisitor visitor);
    }
}