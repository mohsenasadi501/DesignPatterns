namespace DesignPatterns.Behavioral.Observer
{
    internal class SpreadSheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("SpreadSheet got Notified");
        }
    }
}
