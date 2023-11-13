namespace DesignPatterns.Observer
{
    internal class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart got Updated");
        }
    }
}
