namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Decorator
    /// </summary>
    internal abstract class StreamDecorator : IStream
    {
        private readonly IStream _stream;

        public StreamDecorator(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            _stream.Write(data);
        }
    }
}
