using BuilderPattern.Aircraft;

namespace BuilderPattern.Builder
{
    public class F16Builder : AircraftBuilder
    {
        private readonly F16.F16 _f16 = new F16.F16();
        
        public override void BuildEngine()
        {
            _f16.SetEngine("Pratt & Whitney F100");
        }

        public override void BuildWings()
        {
            _f16.SetWings("Small Wings");
        }

        public override void BuildCockpit()
        {
            _f16.SetCockpit("Integrated Cockpit");
        }

        public IAircraft GetResult()
        {
            return _f16;
        }
    }
}