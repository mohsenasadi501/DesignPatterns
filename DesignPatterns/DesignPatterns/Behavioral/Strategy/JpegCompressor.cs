namespace DesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// Concrete Startegy Class
    /// </summary>
    internal class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using Jpeg");
        }
    }
}
