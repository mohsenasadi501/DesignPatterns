namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Subject Interface
    /// </summary>
    internal interface ISubject
    {
        /// <summary>
        /// Add an Observer to the Subject
        /// </summary>
        /// <param name="observer"></param>
        void AddObserver(IObserver observer);

        /// <summary>
        /// Remove an Observer from the Subject
        /// </summary>
        /// <param name="observer"></param>
        void RemoveObserver(IObserver observer);

        /// <summary>
        /// Notify all observers about the events
        /// </summary>
        void NotifyObserver();
    }
}
