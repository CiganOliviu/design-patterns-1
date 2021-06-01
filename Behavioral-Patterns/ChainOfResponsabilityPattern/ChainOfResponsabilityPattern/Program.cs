namespace ChainOfResponsabilityPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            AbstractHandler lowFuelHandler = new FireHandler(null);
            var fireHandler = new FireHandler(lowFuelHandler);

            var lowFuelRequest = new LowFuelRequest(1);
            ((AbstractHandler) fireHandler).HandlerRequest(lowFuelRequest);
        }
    }
}