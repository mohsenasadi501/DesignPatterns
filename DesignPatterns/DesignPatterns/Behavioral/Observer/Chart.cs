namespace DesignPatterns.Behavioral.Observer
{
    /// <summary>
    /// Concrete Observer
    /// </summary> 
    internal class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart got Updated");
        }
    }
}
