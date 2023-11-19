namespace DesignPatterns.Structural.Proxy
{
    internal class Ebook
    {
        private readonly string _fileName;

        public Ebook(string fileName)
        {
            _fileName = fileName;
        }
        private void Load()
        {
            Console.WriteLine($"Loading the Ebook: {_fileName}");
        }
        public void Show()
        {
            Console.WriteLine($"Showing the Ebook: {_fileName}");
        }
        public string getFileName()
        {
            return _fileName;
        }
    }
}
