namespace DesignPatterns.Behavioral.Strategy
{
    internal class ImageStorage
    {
        public void Store(string fileName, ICompressor compressor)
        {
            compressor.Compress(fileName);
        }
    }
}
