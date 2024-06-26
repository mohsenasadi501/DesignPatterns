﻿namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Observable Class
    /// </summary>
    internal class Subject : ISubject
    {
        List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObserver()
        {
            foreach (var observer in _observers)
                observer.Update();
        }
    }
}
