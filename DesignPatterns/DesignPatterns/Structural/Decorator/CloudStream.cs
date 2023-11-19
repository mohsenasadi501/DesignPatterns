namespace DesignPatterns.Structural.Decorator
{
    internal class CloudStream : IStream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Storing: {data}");
        }
    }
}
