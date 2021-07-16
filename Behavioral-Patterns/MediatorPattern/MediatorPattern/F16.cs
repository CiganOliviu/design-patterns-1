namespace MediatorPattern
{
    public class F16 : IAircraft
    {
        private readonly ControlTower _controlTower;

        public F16(ControlTower controlTower)
        {
            _controlTower = controlTower;
        }

        public void Land()
        {
            throw new System.NotImplementedException();
        }

        public void RequestControlTowerToLand()
        {
            _controlTower.RequestToLand(this);
        }
    }
}