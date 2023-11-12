namespace DesignPatterns.Strategy
{
    internal class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using Jpeg");
        }
    }
}
