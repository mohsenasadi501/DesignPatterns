namespace DesignPatterns.Behavioral.Strategy
{
    /// <summary>
    /// Strategy Class
    /// </summary>
    internal interface ICompressor
    {
        //byte[] Compress(byte[] image);
        void Compress(string fileName);
    }
}
