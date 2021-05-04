namespace PrototypePattern
{
    public interface IAircraftPrototype
    {
        void StartEngine();
        
        IAircraftPrototype Clone();
        
        void SetEngine(string engine);
        string GetEngine();
    }
}