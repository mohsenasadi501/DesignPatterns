namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Concrete Component
    /// </summary>
    internal class CloudStream : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Storing: {data}");
        }
    }
}
