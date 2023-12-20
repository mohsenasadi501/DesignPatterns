namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Concrete Observer
    /// </summary>
    internal class SpreadSheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("SpreadSheet got Notified");
        }
    }
}
