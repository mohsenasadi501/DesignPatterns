namespace DesignPatterns.Behavioral.Observer
{
    internal interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
