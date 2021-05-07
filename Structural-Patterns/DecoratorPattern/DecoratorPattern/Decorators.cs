namespace DecoratorPattern
{
    internal class LuxuryClass : IAircraft
    {
        private readonly IAircraft _boeing;

        public LuxuryClass(IAircraft boeing)
        {
            this._boeing = boeing;
        }

        public void Fly()
        {
            _boeing.Fly();
        }

        public void Land()
        {
            _boeing.Land();
        }

        public float GetWeight()
        {
            return 10 * _boeing.GetWeight();
        }
    }

    internal class BulletProof : IAircraft
    {
        private IAircraft _boeing;

        public BulletProof(IAircraft boeing)
        {
            this._boeing = boeing;
        }

        public void Fly()
        {
            _boeing.Fly();
        }

        public void Land()
        {
            _boeing.Land();
        }

        public float GetWeight()
        {
            return 30 + _boeing.GetWeight();
        }
    }
}