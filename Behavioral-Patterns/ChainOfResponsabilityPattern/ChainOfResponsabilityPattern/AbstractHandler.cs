namespace ChainOfResponsabilityPattern
{
    public abstract class AbstractHandler
    {
        private AbstractHandler _next;

        public AbstractHandler(AbstractHandler next)
        {
            _next = next;
        }

        public void SetNext(AbstractHandler next)
        {
            this._next = next;
        }

        public void HandlerRequest(AbstractRequest request)
        {
            _next?.HandlerRequest(request);
        }
    }
}