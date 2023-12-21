namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Concrete Decoratror
    /// </summary>
    internal class EncryptedCloudStream : StreamDecorator
    {
        public EncryptedCloudStream(IStream stream) : base(stream) { }

        public void Write(string data)
        {
            var encryptedData = Encrypt(data);
            base.Write(encryptedData);
        }
        private string Encrypt(string data)
        {
            return "@#$EWSFSDF#$@#$@R";
        }
    }
}
