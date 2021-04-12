namespace BuilderPattern.Aircraft
{
    public interface IAircraft
    {
        public void SetEngine(string engine);
        public string GetEngine();

        public void SetWings(string wings);
        public string GetWings();

        public void SetCockpit(string cockpit);
        public string GetCockpit();

        public void GetResults();
    }
}