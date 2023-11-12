namespace DesignPatterns.Strategy
{
    internal interface ICompressor
    {
        //byte[] Compress(byte[] image);
        void Compress(string fileName);
    }
}
