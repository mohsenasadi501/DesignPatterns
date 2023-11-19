namespace DesignPatterns.Structural.Decorator
{
    internal class CompressedCloudStream : IStream
    {
        private IStream _stream;
        public CompressedCloudStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            var compressedData = Compress(data);
            _stream.Write(compressedData);
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
