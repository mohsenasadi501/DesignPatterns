namespace DesignPatterns.Structural.Proxy
{
    internal class Library
    {
        Dictionary<string, Ebook> ebooks = new Dictionary<string, Ebook>();

        public void Add(Ebook ebook)
        {
            ebooks.Add(ebook.getFileName(), ebook);
            Console.WriteLine($"Loading the Ebook: {ebook.getFileName()}");
        }
         
        public void OpenEbook(string fileName)
        {
            ebooks[fileName].Show();
        }
    }
}
