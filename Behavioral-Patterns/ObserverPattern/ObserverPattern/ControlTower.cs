using System.Collections.ObjectModel;

namespace ObserverPattern
{
    public class ControlTower : ISubject
    {
        private readonly Collection<IObserver> _observers = new Collection<IObserver>();
        
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            throw new System.NotImplementedException();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(null);
            }
        }

        public void Run()
        {
            while (true)
            {
                NotifyObservers();
            }
        }
    }
}