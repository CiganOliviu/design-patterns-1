using BuilderPattern.Aircraft;

namespace BuilderPattern.Builder
{
    public class Boeing747Builder : AircraftBuilder
    {
        private readonly Boeing747.Boeing747 _boeing747 = new();
        
        public new void BuildEngine()
        {
            _boeing747.SetEngine("General Electric GEnx");
        }

        public override void BuildWings()
        {
            _boeing747.SetWings("Huge Wings");
        }

        public override void BuildCockpit()
        {
            _boeing747.SetCockpit("Dedicated Cockpit");
        }

        public override void BuildBathroom()
        {
            _boeing747.SetBathroom("Small Bathrooms");
        }

        public IAircraft GetResult()
        {
            return _boeing747;
        }
    }
}