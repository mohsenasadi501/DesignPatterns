namespace DesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// Context Class
    /// </summary>
    internal class ImageStorage
    {
        public void Store(string fileName, ICompressor compressor)
        {
            compressor.Compress(fileName);
        }
    }
}
