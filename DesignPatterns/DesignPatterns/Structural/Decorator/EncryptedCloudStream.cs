namespace DesignPatterns.Structural.Decorator
{
    internal class EncryptedCloudStream : IStream
    {
        private IStream _stream;

        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
            {
            var encryptedData = Encrypt(data);
            _stream.Write(encryptedData);
        }
        private string Encrypt(string data)
        {
            return "@#$EWSFSDF#$@#$@R";
        }
    }
}
