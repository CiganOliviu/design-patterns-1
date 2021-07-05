namespace CommandPattern
{
    public class LandingGear
    {
        public LandingGear()
        {
            
        }
    }
    
    public class LandingGearDownCommand : ICommand
    {
        private LandingGear _landingGear;
        
        public LandingGearDownCommand(LandingGear landingGear)
        {
            _landingGear = landingGear;
        }


        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}