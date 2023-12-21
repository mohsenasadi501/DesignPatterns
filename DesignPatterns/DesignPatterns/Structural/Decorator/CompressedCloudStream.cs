namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Concrete Decoratror
    /// </summary>
    internal class CompressedCloudStream : StreamDecorator
    {
        public CompressedCloudStream(IStream stream):base(stream) { }
        public void Write(string data)
        {
            var compressedData = Compress(data);
            base.Write(compressedData);
        }
        private string Compress(string data)
        {
            return data.Substring(0, data.Length - 1);
        }
    }

    #region Inheritance 

    //internal class CompressedCloudStream : CloudStream
    //{
    //    public new void Write(string data)
    //    {
    //        var compressedData = Compress(data);
    //        base.Write(compressedData);
    //    }
    //    private string Compress(string data)
    //    {
    //        return data.Substring(0, data.Length - 1);
    //    }
    //}

    #endregion
}
