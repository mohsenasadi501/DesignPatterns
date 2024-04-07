namespace DesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// Concrete Startegy Class
    /// </summary>
    internal class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
