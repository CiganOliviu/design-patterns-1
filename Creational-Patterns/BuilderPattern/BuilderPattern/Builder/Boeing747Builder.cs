using BuilderPattern.Aircraft;

namespace BuilderPattern.Builder
{
    public class Boeing747Builder : AircraftBuilder
    {
        private readonly Boeing747.Boeing747 _boeing747 = new Boeing747.Boeing747();
        
        public new void BuildEngine()
        {
            _boeing747.SetEngine("");
        }

        public new void BuildWings()
        {
            _boeing747.SetWings("");
        }

        public new void BuildCockpit()
        {
            _boeing747.SetCockpit("");
        }

        public new void BuildBathroom()
        {
            _boeing747.SetBathroom("");
        }

        public IAircraft GetResult()
        {
            return _boeing747;
        }
    }
}