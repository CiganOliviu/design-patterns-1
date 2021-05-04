namespace AdapterPattern
{
    public class Adapter : IAircraft
    {
        private HotAirBalloon _hotAirBalloon;

        public Adapter(HotAirBalloon hotAirBalloon)
        {
            _hotAirBalloon = hotAirBalloon;
        }
        
        public void Fly()
        {
            var fuelUsed = _hotAirBalloon.InflateWithGas();
            _hotAirBalloon.Fly(fuelUsed);
        }
    }
}