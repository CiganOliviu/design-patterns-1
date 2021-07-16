namespace VisitorPattern
{
    internal class MetricsVisitor : IAircraftVisitor
    {
        public void VisitF16(F16 f16)
        {
            throw new System.NotImplementedException();
        }

        public void VisitBoeing747(Boeing747 boeing747)
        {
            throw new System.NotImplementedException();
        }

        public static void PrintAccumulatedResults()
        {
            
        }
    }
    
    internal class PriceVisitor : IAircraftVisitor
    {
        public void VisitF16(F16 f16)
        {
            throw new System.NotImplementedException();
        }

        public void VisitBoeing747(Boeing747 boeing747)
        {
            throw new System.NotImplementedException();
        }
        
        public static void PrintAccumulatedResults()
        {
            
        }
    }
}