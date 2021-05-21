namespace ChainOfResponsabilityPattern
{
    public class FireDetectedRequest : AbstractRequest {
        public FireDetectedRequest(int requestCode) : base(requestCode)
        {
        }
    }

    public class LowFuelRequest : AbstractRequest
    {
        public LowFuelRequest(int requestCode) : base(requestCode)
        {
        }
    }

    public class FireHandler : AbstractHandler
    {
        private static int _code = 1;
        
        public FireHandler(AbstractHandler next) : base(next)
        {
        }

        public new static void HandlerRequest(AbstractRequest request)
        {
            // if (_code == request.GetRequestCode()) ;
        }
    } 
}