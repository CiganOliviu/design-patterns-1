using BuilderPattern.Aircraft;

namespace BuilderPattern.Builder
{
    public class F16Builder : AircraftBuilder
    {
        private readonly F16.F16 _f16 = new F16.F16();
        
        public new void BuildEngine()
        {
            _f16.SetEngine("");
        }

        public new void BuildWings()
        {
            _f16.SetWings("");
        }

        public new void BuildCockpit()
        {
            _f16.SetCockpit("");
        }

        public IAircraft GetResult()
        {
            return _f16;
        }
    }
}