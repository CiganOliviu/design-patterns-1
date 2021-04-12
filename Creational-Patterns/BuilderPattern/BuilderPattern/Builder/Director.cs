namespace BuilderPattern.Builder
{
    public class Director
    {
        private readonly AircraftBuilder _aircraftBuilder;

        public Director(AircraftBuilder aircraftBuilder)
        {
            _aircraftBuilder = aircraftBuilder;
        }

        public void Construct(bool isPassenger)
        {
            _aircraftBuilder.BuildEngine();
            _aircraftBuilder.BuildWings();
            _aircraftBuilder.BuildCockpit();

            if (isPassenger)
                _aircraftBuilder.BuildBathroom();
        }
    }
}