namespace VisitorPattern
{
    public interface IAircraftVisitor
    {
        void VisitF16(F16 f16);
        void VisitBoeing747(Boeing747 boeing747);
    }
}