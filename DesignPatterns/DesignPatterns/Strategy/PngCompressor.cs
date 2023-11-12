namespace DesignPatterns.Strategy
{
    internal class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
