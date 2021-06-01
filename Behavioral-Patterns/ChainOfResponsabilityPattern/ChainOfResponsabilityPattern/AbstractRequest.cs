namespace ChainOfResponsabilityPattern
{
    public abstract class AbstractRequest
    {
        private readonly int _requestCode;

        public AbstractRequest(int requestCode)
        {
            _requestCode = requestCode;
        }

        public int GetRequestCode()
        {
            return _requestCode;
        }
    }
}